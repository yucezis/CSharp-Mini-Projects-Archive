namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblHava = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFeel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWind = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFah = new System.Windows.Forms.Label();
            this.lblNem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Istanbul",
            "London",
            "Roma",
            "Paris"});
            this.comboBox1.Location = new System.Drawing.Point(163, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ŞEHİR:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(330, 135);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(108, 21);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Şehir,Ülke";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCel.ForeColor = System.Drawing.Color.White;
            this.lblCel.Location = new System.Drawing.Point(297, 167);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(183, 71);
            this.lblCel.TabIndex = 3;
            this.lblCel.Text = "00.00";
            // 
            // lblHava
            // 
            this.lblHava.AutoSize = true;
            this.lblHava.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHava.ForeColor = System.Drawing.Color.White;
            this.lblHava.Location = new System.Drawing.Point(298, 238);
            this.lblHava.Name = "lblHava";
            this.lblHava.Size = new System.Drawing.Size(182, 27);
            this.lblHava.TabIndex = 4;
            this.lblHava.Text = "Hava Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rüzgar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(346, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fahreheit:";
            // 
            // lblFeel
            // 
            this.lblFeel.AutoSize = true;
            this.lblFeel.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFeel.ForeColor = System.Drawing.Color.White;
            this.lblFeel.Location = new System.Drawing.Point(273, 404);
            this.lblFeel.Name = "lblFeel";
            this.lblFeel.Size = new System.Drawing.Size(145, 27);
            this.lblFeel.TabIndex = 8;
            this.lblFeel.Text = "Hissedilen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWind.ForeColor = System.Drawing.Color.White;
            this.lblWind.Location = new System.Drawing.Point(187, 332);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(25, 28);
            this.lblWind.TabIndex = 10;
            this.lblWind.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(424, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "0";
            // 
            // lblFah
            // 
            this.lblFah.AutoSize = true;
            this.lblFah.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFah.ForeColor = System.Drawing.Color.White;
            this.lblFah.Location = new System.Drawing.Point(184, 403);
            this.lblFah.Name = "lblFah";
            this.lblFah.Size = new System.Drawing.Size(25, 28);
            this.lblFah.TabIndex = 12;
            this.lblFah.Text = "0";
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNem.ForeColor = System.Drawing.Color.White;
            this.lblNem.Location = new System.Drawing.Point(424, 332);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(25, 28);
            this.lblNem.TabIndex = 13;
            this.lblNem.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(379, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "SEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(563, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.lblFah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFeel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHava);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblHava;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFeel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFah;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.Button button1;
    }
}

