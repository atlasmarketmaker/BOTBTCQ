namespace BOT_BTCQ
{
    partial class frmBOTBTCQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSECRET = new System.Windows.Forms.TextBox();
            this.txtBTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFEE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAcumular = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl24btc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl24btcq = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblmenor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblmaior = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(257, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "338342ca9c999caa74300b1b999c7845029588b6cc9b8ef1689c7d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Secret";
            // 
            // txtSECRET
            // 
            this.txtSECRET.Location = new System.Drawing.Point(12, 77);
            this.txtSECRET.Name = "txtSECRET";
            this.txtSECRET.Size = new System.Drawing.Size(257, 20);
            this.txtSECRET.TabIndex = 3;
            this.txtSECRET.Text = "338342c91327248e651c4779af0f21bb48eff41caa3b00e14a34709acd4afe5eb1bbf8";
            // 
            // txtBTC
            // 
            this.txtBTC.Location = new System.Drawing.Point(12, 120);
            this.txtBTC.Name = "txtBTC";
            this.txtBTC.Size = new System.Drawing.Size(257, 20);
            this.txtBTC.TabIndex = 5;
            this.txtBTC.Text = "0.02";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máximo de BTC usado na sua wallet:";
            // 
            // txtFEE
            // 
            this.txtFEE.Location = new System.Drawing.Point(12, 164);
            this.txtFEE.Name = "txtFEE";
            this.txtFEE.Size = new System.Drawing.Size(121, 20);
            this.txtFEE.TabIndex = 7;
            this.txtFEE.Text = "0.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Taxa exchange:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Eu quero acumular(em construção, somente acumulando BTC):";
            // 
            // cboAcumular
            // 
            this.cboAcumular.FormattingEnabled = true;
            this.cboAcumular.Items.AddRange(new object[] {
            "BTC",
            "BTCQ"});
            this.cboAcumular.Location = new System.Drawing.Point(12, 210);
            this.cboAcumular.Name = "cboAcumular";
            this.cboAcumular.Size = new System.Drawing.Size(121, 21);
            this.cboAcumular.TabIndex = 10;
            this.cboAcumular.Text = "BTC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Saldo em BTC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "0.00000000 BTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "0.00000000 BTCQ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Saldo em BTCQ:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(450, 35);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(102, 13);
            this.lblLast.TabIndex = 16;
            this.lblLast.Text = "0.00000000 BTC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(347, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Cotação BTCQ:";
            // 
            // lbl24btc
            // 
            this.lbl24btc.AutoSize = true;
            this.lbl24btc.Location = new System.Drawing.Point(450, 109);
            this.lbl24btc.Name = "lbl24btc";
            this.lbl24btc.Size = new System.Drawing.Size(88, 13);
            this.lbl24btc.TabIndex = 18;
            this.lbl24btc.Text = "0.00000000 BTC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Volume 24 hrs";
            // 
            // lbl24btcq
            // 
            this.lbl24btcq.AutoSize = true;
            this.lbl24btcq.Location = new System.Drawing.Point(450, 126);
            this.lbl24btcq.Name = "lbl24btcq";
            this.lbl24btcq.Size = new System.Drawing.Size(96, 13);
            this.lbl24btcq.TabIndex = 20;
            this.lbl24btcq.Text = "0.00000000 BTCQ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(347, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Volume 24 hrs";
            // 
            // lblmenor
            // 
            this.lblmenor.AutoSize = true;
            this.lblmenor.Location = new System.Drawing.Point(450, 180);
            this.lblmenor.Name = "lblmenor";
            this.lblmenor.Size = new System.Drawing.Size(88, 13);
            this.lblmenor.TabIndex = 24;
            this.lblmenor.Text = "0.00000000 BTC";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(347, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Menor val 24 hrs";
            // 
            // lblmaior
            // 
            this.lblmaior.AutoSize = true;
            this.lblmaior.Location = new System.Drawing.Point(450, 163);
            this.lblmaior.Name = "lblmaior";
            this.lblmaior.Size = new System.Drawing.Size(88, 13);
            this.lblmaior.TabIndex = 22;
            this.lblmaior.Text = "0.00000000 BTC";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(347, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Maior val 24hrs";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 372);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(618, 186);
            this.listBox1.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 356);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Log:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(8, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Iniciar bot!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(398, 6);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(13, 13);
            this.lblUpdate.TabIndex = 28;
            this.lblUpdate.Text = "--";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(123, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 29;
            this.button2.Text = "Parar Bot!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "Status: PARADO";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(12, 263);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(121, 20);
            this.txtProfit.TabIndex = 32;
            this.txtProfit.Text = "0.1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Porcentagem de lucro (0.1 padrão)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(439, 319);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 13);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://t.me/robobtcq/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(342, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Grupo do telegram:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(388, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Github";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(440, 332);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(188, 13);
            this.linkLabel2.TabIndex = 36;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/atlasmarketmaker/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmBOTBTCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 563);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblmenor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblmaior);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl24btcq);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl24btc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboAcumular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFEE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSECRET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmBOTBTCQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOT BTCQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSECRET;
        private System.Windows.Forms.TextBox txtBTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFEE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAcumular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl24btc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl24btcq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblmenor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblmaior;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

