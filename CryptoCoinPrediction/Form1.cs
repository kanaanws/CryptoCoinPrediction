using CryptoCoinPredictionML.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace CryptoCoinPrediction
{
    public partial class Form1 : Form
    {


        // globals
        DataSet dsUrls;
        Mutex mut = new Mutex();

        private delegate void updateText(string messageText);

        private void UpdateMessageText(string newMessage)
        {
            lblMessages.Text = newMessage;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void CheckDataDirectory()
        {
            HandleDirectory("data");
        }

        private void CheckModelDirecotry()
        {
            HandleDirectory("models");
        }

        private void HandleDirectory(string DirectoryName)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\" + DirectoryName))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\" + DirectoryName);
            }
        }

        private DataSet CreateConfigFile()
        {
            DataSet ds = new DataSet("DataSourceUrls");
            DataTable dt = new DataTable("URLS");
            dt.Columns.Add("pair");
            dt.Columns.Add("url");

            dt.Rows.Add("btc/usd", "https://www.cryptodatadownload.com/cdd/Binance_BTCUSDT_d.csv");
            dt.Rows.Add("eth/usd", "https://www.cryptodatadownload.com/cdd/Binance_ETHUSDT_d.csv");
            CheckDataDirectory();
            ds.Tables.Add(dt);
            ds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\data\\config.xml");

            return ds;
        }

        private void btnPredictPrice_Click(object sender, EventArgs e)
        {
            // predict the price
            ModelInput m = new ModelInput
            {
                Date = lblDate.Text,
                Close = float.Parse(lblClose.Text),
                Low = float.Parse(lblLow.Text),
                High = float.Parse(lblHigh.Text),
                Open = float.Parse(lblOpen.Text),
                VolumeBTC = float.Parse(lblVolumeBTC.Text),
                VolumeUSDT = float.Parse(lblVolumeUSDT.Text)
            };

            ModelOutput result = ConsumeModel.Predict(m);

            lblNextDayClose.Text = result.Score.ToString();
        }

        private void DownloadFile(string Pair)
        {
            using (var client = new WebClient())
            {
                DataRow[] rTemp = dsUrls.Tables[0].Select("pair='" + Pair.Trim() + "'");
                if (rTemp.Length != 1)
                {
                    MessageBox.Show("Pair url not found");
                    return;
                }

                string TargetFilename = AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + Pair.Replace("/", "") + "_raw.csv";
                client.DownloadFile(rTemp[0]["url"].ToString(), TargetFilename);
            }
        }

        private void bTDUSDBinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadFile("btc/usd");
            string[] allLines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\btcusd_raw.csv");
            CleanData(ref allLines);

            // save the cleaned data
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\btcusd_ready.csv", allLines);

            // start the training process
            DialogResult r = MessageBox.Show("Do you want to train the model with the new data?", "Train Model?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                CheckModelDirecotry();
                CryptoCoinPredictionML.ModelBuilder.CreateModel(AppDomain.CurrentDomain.BaseDirectory + "\\data\\btcusd_ready.csv",

                    AppDomain.CurrentDomain.BaseDirectory + "\\models\\btcusdmodel.zip");
            }

        }

        private void CleanData(ref string[] fileLines)
        {
            // remove the first line
            fileLines = fileLines.Skip(1).ToArray();

            // remove spaces from titles
            fileLines[0] = fileLines[0].Replace(" ", "");


            // remove columns 0 and 2
            for (int x = 0; x < fileLines.Length; x++)
            {
                List<int> indexesOfComma = GetAllIndexesOfChar(",", ref fileLines[x]);
                fileLines[x] = fileLines[x].Substring(indexesOfComma[0] + 1, indexesOfComma[1] - indexesOfComma[0] - 1) +
                               fileLines[x].Substring(indexesOfComma[2], fileLines[x].Length - indexesOfComma[2]);
            }

            // add the new column for next day price
            fileLines[0] += ",NextDayClose";
            for (int x = 2; x < fileLines.Length; x++)
            {
                List<int> indexesOfComma = GetAllIndexesOfChar(",", ref fileLines[x - 1]);
                fileLines[x] += fileLines[x - 1].Substring(indexesOfComma[3], indexesOfComma[4] - indexesOfComma[3]);
            }

            // remove the first date as it doesn't have a next day value
            fileLines[1] = fileLines[0];
            fileLines = fileLines.Skip(1).ToArray();
        }

        private List<int> GetAllIndexesOfChar(string searchChar, ref string textToSearch)
        {
            List<int> lToReturn = new List<int>();
            int index = textToSearch.IndexOf(searchChar, 0);
            while (index > -1)
            {
                lToReturn.Add(index);
                index = textToSearch.IndexOf(searchChar, index + 1);
            }

            return lToReturn;
        }


        private void setFileSourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // laod the sources file
            CheckDataDirectory();
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\data\\Config.xml"))
            {
                dsUrls = CreateConfigFile();
            }
            else
            {
                dsUrls = new DataSet();
                dsUrls.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\data\\Config.xml");
            }

            foreach (DataRow r in dsUrls.Tables[0].Rows)
            {
                ToolStripButton b = new ToolStripButton(r["pair"].ToString().Trim());
                b.Click += B_Click;
                b.Name = "b" + r["pair"].ToString().Trim();
                downloadDataToolStripMenuItem.DropDownItems.Add(b);
                cbPairs.Items.Add(r["pair"].ToString().Trim().ToLower());
            }


            lblMessages.Text = "";

        }

        private void B_Click(object sender, EventArgs e)
        {
            ToolStripButton b = (ToolStripButton)sender;
            string pair = b.Name.Trim().Substring(1);

            DownloadFile(pair);
            string pairNoSlash = pair.Replace("/", "");
            string[] allLines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + pairNoSlash + "_raw.csv");
            CleanData(ref allLines);

            // save the cleaned data
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + pairNoSlash + "_ready.csv", allLines);

            // start the training process
            DialogResult r = MessageBox.Show("Do you want to train the model with the new data?", "Train Model?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                CheckModelDirecotry();

                lblMessages.Text = "Model training started";
                Thread t = new Thread(new ParameterizedThreadStart(doCreateModel));
                t.Start(pairNoSlash);

            }
        }

        void doCreateModel(object pair)
        {
            string pairNoSlash = pair.ToString();
            CryptoCoinPredictionML.ModelBuilder.CreateModel(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + pairNoSlash + "_ready.csv",
                    AppDomain.CurrentDomain.BaseDirectory + "\\models\\" + pairNoSlash + "model.zip");
            updateText ut = new updateText(UpdateMessageText);
            Invoke(ut, new object[] { "Model training finished" });
            Thread.Sleep(3000);
            Invoke(ut, new object[] { "" });

        }

        private void btnLoadLatestData_Click(object sender, EventArgs e)
        {
            if (cbPairs.SelectedIndex > -1)
            {

                // get the pair
                string pair = cbPairs.SelectedItem.ToString().Trim();

                string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + pair.Replace("/", "") + "_raw.csv";
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("The data file was not found. Please download the file and train the algorithm first.", "File not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string firstDataLine = "";
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // the third line holds the first line of data
                    firstDataLine = reader.ReadLine(); // source link
                    firstDataLine = reader.ReadLine(); // titles
                    firstDataLine = reader.ReadLine(); // replace with the data
                }

                //Unix Timestamp,Date,Symbol,Open,High,Low,Close,Volume BTC,Volume USDT
                string[] LineParts = firstDataLine.Split(new string[] { "," }, StringSplitOptions.None);

                // check the date
                string sDateString = LineParts[1].Trim();
                DateTime dtDate = new DateTime(
                    int.Parse(sDateString.Substring(0, 4)),
                    int.Parse(sDateString.Substring(5, 2)),
                    int.Parse(sDateString.Substring(8, 2))
                    );

                if(DateTime.Now.Date > dtDate.Date)
                {
                    MessageBox.Show("The data is old. Go to File->Download Data and select your pair to update the data and retrain the model.",
                        "Data outdated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lblPairLoaded.Text = pair;
                lblDate.Text = sDateString;
                lblOpen.Text = LineParts[3].Trim();
                lblHigh.Text = LineParts[4].Trim();
                lblLow.Text = LineParts[5].Trim();
                lblClose.Text = LineParts[6].Trim();
                lblVolumeBTC.Text = LineParts[7].Trim();
                lblVolumeUSDT.Text = LineParts[8].Trim();

                lblNextDayClose.Text = "-";

                gbData.Enabled = true;
            }

            else
            {
                lblPairLoaded.Text = "-";
                lblDate.Text = "-";
                lblOpen.Text = "-";
                lblHigh.Text = "-";
                lblLow.Text = "-";
                lblClose.Text = "-";
                lblVolumeBTC.Text = "-";
                lblVolumeUSDT.Text = "-";

                lblNextDayClose.Text = "-";

                gbData.Enabled = false;

            }
        }
    }
}
