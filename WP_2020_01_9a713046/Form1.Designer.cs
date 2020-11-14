namespace WP_2020_01_9a713046
{
    partial class Formgame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbtoptext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbmoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.btnbig = new System.Windows.Forms.Button();
            this.btnsmall = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lbmoney = new System.Windows.Forms.Label();
            this.bwinlose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtoptext
            // 
            this.lbtoptext.AutoSize = true;
            this.lbtoptext.BackColor = System.Drawing.Color.Transparent;
            this.lbtoptext.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbtoptext.ForeColor = System.Drawing.Color.Purple;
            this.lbtoptext.Location = new System.Drawing.Point(58, 30);
            this.lbtoptext.Name = "lbtoptext";
            this.lbtoptext.Size = new System.Drawing.Size(898, 64);
            this.lbtoptext.TabIndex = 27;
            this.lbtoptext.Text = "2~7小牌，9以上大牌，A是大牌";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(730, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 310);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbmoney
            // 
            this.tbmoney.BackColor = System.Drawing.Color.AliceBlue;
            this.tbmoney.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmoney.Location = new System.Drawing.Point(147, 324);
            this.tbmoney.Name = "tbmoney";
            this.tbmoney.Size = new System.Drawing.Size(100, 52);
            this.tbmoney.TabIndex = 2;
            this.tbmoney.Text = "10";
            this.tbmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(139, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "你的籌碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(139, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "押注金額";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.BackColor = System.Drawing.Color.Transparent;
            this.infolabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infolabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.infolabel.Location = new System.Drawing.Point(139, 508);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(32, 48);
            this.infolabel.TabIndex = 22;
            this.infolabel.Text = " ";
            // 
            // btnbig
            // 
            this.btnbig.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbig.Location = new System.Drawing.Point(381, 132);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(153, 132);
            this.btnbig.TabIndex = 20;
            this.btnbig.Text = "大";
            this.btnbig.UseVisualStyleBackColor = true;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click_1);
            // 
            // btnsmall
            // 
            this.btnsmall.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsmall.Location = new System.Drawing.Point(561, 132);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(153, 132);
            this.btnsmall.TabIndex = 7;
            this.btnsmall.Text = "小";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click_1);
            // 
            // btnend
            // 
            this.btnend.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnend.Location = new System.Drawing.Point(561, 310);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(153, 132);
            this.btnend.TabIndex = 8;
            this.btnend.Text = "結束遊戲";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click_1);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeal.Location = new System.Drawing.Point(381, 310);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(153, 132);
            this.btnDeal.TabIndex = 9;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.BackColor = System.Drawing.Color.Transparent;
            this.lbmoney.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbmoney.ForeColor = System.Drawing.Color.Red;
            this.lbmoney.Location = new System.Drawing.Point(140, 200);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(68, 37);
            this.lbmoney.TabIndex = 23;
            this.lbmoney.Text = "100";
            // 
            // bwinlose
            // 
            this.bwinlose.AutoSize = true;
            this.bwinlose.BackColor = System.Drawing.Color.Transparent;
            this.bwinlose.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bwinlose.ForeColor = System.Drawing.Color.SteelBlue;
            this.bwinlose.Location = new System.Drawing.Point(373, 508);
            this.bwinlose.Name = "bwinlose";
            this.bwinlose.Size = new System.Drawing.Size(32, 48);
            this.bwinlose.TabIndex = 28;
            this.bwinlose.Text = " ";
            // 
            // Formgame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WP_2020_01_9a713046.Properties.Resources._001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.bwinlose);
            this.Controls.Add(this.lbmoney);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnsmall);
            this.Controls.Add(this.btnbig);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbmoney);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtoptext);
            this.Name = "Formgame";
            this.Text = "猜大小";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtoptext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label lbwinlose;
        private System.Windows.Forms.Button btnbig;
        private System.Windows.Forms.Button btnsmall;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lbmoney;
        private System.Windows.Forms.Label bwinlose;
    }
}

