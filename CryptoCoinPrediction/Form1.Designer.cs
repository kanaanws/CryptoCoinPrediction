namespace CryptoCoinPrediction
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPredictPrice = new System.Windows.Forms.Button();
            this.btnLoadLatestData = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPairs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVolumeBTC = new System.Windows.Forms.Label();
            this.lblVolumeUSDT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNextDayClose = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPairLoaded = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.predictorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // downloadDataToolStripMenuItem
            // 
            this.downloadDataToolStripMenuItem.Name = "downloadDataToolStripMenuItem";
            this.downloadDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadDataToolStripMenuItem.Text = "Download Data";
            // 
            // predictorToolStripMenuItem
            // 
            this.predictorToolStripMenuItem.Name = "predictorToolStripMenuItem";
            this.predictorToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.predictorToolStripMenuItem.Text = "Predictor";
            // 
            // btnPredictPrice
            // 
            this.btnPredictPrice.Location = new System.Drawing.Point(9, 164);
            this.btnPredictPrice.Name = "btnPredictPrice";
            this.btnPredictPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPredictPrice.TabIndex = 1;
            this.btnPredictPrice.Text = "Predict price";
            this.btnPredictPrice.UseVisualStyleBackColor = true;
            this.btnPredictPrice.Click += new System.EventHandler(this.btnPredictPrice_Click);
            // 
            // btnLoadLatestData
            // 
            this.btnLoadLatestData.Location = new System.Drawing.Point(12, 67);
            this.btnLoadLatestData.Name = "btnLoadLatestData";
            this.btnLoadLatestData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLatestData.TabIndex = 2;
            this.btnLoadLatestData.Text = "Load latest date data:";
            this.btnLoadLatestData.UseVisualStyleBackColor = true;
            this.btnLoadLatestData.Click += new System.EventHandler(this.btnLoadLatestData_Click);
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.lblPairLoaded);
            this.gbData.Controls.Add(this.lblNextDayClose);
            this.gbData.Controls.Add(this.label10);
            this.gbData.Controls.Add(this.label9);
            this.gbData.Controls.Add(this.lblVolumeUSDT);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.lblVolumeBTC);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.lblClose);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.lblLow);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.lblHigh);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.lblOpen);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.lblDate);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.btnPredictPrice);
            this.gbData.Enabled = false;
            this.gbData.Location = new System.Drawing.Point(12, 96);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(776, 274);
            this.gbData.TabIndex = 3;
            this.gbData.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open";
            // 
            // cbPairs
            // 
            this.cbPairs.FormattingEnabled = true;
            this.cbPairs.Location = new System.Drawing.Point(47, 40);
            this.cbPairs.Name = "cbPairs";
            this.cbPairs.Size = new System.Drawing.Size(121, 21);
            this.cbPairs.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "High";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Close";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Volume (BTC)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(100, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(10, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "-";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(100, 36);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(10, 13);
            this.lblOpen.TabIndex = 2;
            this.lblOpen.Text = "-";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(100, 56);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(10, 13);
            this.lblHigh.TabIndex = 2;
            this.lblHigh.Text = "-";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(100, 76);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(10, 13);
            this.lblLow.TabIndex = 2;
            this.lblLow.Text = "-";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(100, 96);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(10, 13);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Volume (USDT)";
            // 
            // lblVolumeBTC
            // 
            this.lblVolumeBTC.AutoSize = true;
            this.lblVolumeBTC.Location = new System.Drawing.Point(100, 116);
            this.lblVolumeBTC.Name = "lblVolumeBTC";
            this.lblVolumeBTC.Size = new System.Drawing.Size(10, 13);
            this.lblVolumeBTC.TabIndex = 2;
            this.lblVolumeBTC.Text = "-";
            // 
            // lblVolumeUSDT
            // 
            this.lblVolumeUSDT.AutoSize = true;
            this.lblVolumeUSDT.Location = new System.Drawing.Point(100, 136);
            this.lblVolumeUSDT.Name = "lblVolumeUSDT";
            this.lblVolumeUSDT.Size = new System.Drawing.Size(10, 13);
            this.lblVolumeUSDT.TabIndex = 2;
            this.lblVolumeUSDT.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Expected Next Day Close Price:";
            // 
            // lblNextDayClose
            // 
            this.lblNextDayClose.AutoSize = true;
            this.lblNextDayClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDayClose.Location = new System.Drawing.Point(244, 230);
            this.lblNextDayClose.Name = "lblNextDayClose";
            this.lblNextDayClose.Size = new System.Drawing.Size(15, 20);
            this.lblNextDayClose.TabIndex = 3;
            this.lblNextDayClose.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pair:";
            // 
            // lblPairLoaded
            // 
            this.lblPairLoaded.AutoSize = true;
            this.lblPairLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPairLoaded.Location = new System.Drawing.Point(53, 205);
            this.lblPairLoaded.Name = "lblPairLoaded";
            this.lblPairLoaded.Size = new System.Drawing.Size(15, 20);
            this.lblPairLoaded.TabIndex = 3;
            this.lblPairLoaded.Text = "-";
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.ForeColor = System.Drawing.Color.Green;
            this.lblMessages.Location = new System.Drawing.Point(18, 384);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(10, 13);
            this.lblMessages.TabIndex = 5;
            this.lblMessages.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPairs);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnLoadLatestData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Crypto Predictor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictorToolStripMenuItem;
        private System.Windows.Forms.Button btnPredictPrice;
        private System.Windows.Forms.ToolStripMenuItem downloadDataToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadLatestData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPairs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVolumeUSDT;
        private System.Windows.Forms.Label lblVolumeBTC;
        private System.Windows.Forms.Label lblNextDayClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPairLoaded;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMessages;
    }
}

