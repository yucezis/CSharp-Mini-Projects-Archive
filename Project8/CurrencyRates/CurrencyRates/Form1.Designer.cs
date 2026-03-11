namespace CurrencyRates
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDollar = new Label();
            lblEuro = new Label();
            label1 = new Label();
            label2 = new Label();
            rdbDollar = new RadioButton();
            label3 = new Label();
            lblSterlin = new Label();
            rdbEuro = new RadioButton();
            rdbSterlin = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblDollar
            // 
            lblDollar.AutoSize = true;
            lblDollar.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            lblDollar.Location = new Point(184, 69);
            lblDollar.Name = "lblDollar";
            lblDollar.Size = new Size(24, 28);
            lblDollar.TabIndex = 0;
            lblDollar.Text = "0";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            lblEuro.Location = new Point(184, 105);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(24, 28);
            lblEuro.TabIndex = 1;
            lblEuro.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            label1.Location = new Point(26, 69);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 2;
            label1.Text = "DOLAR/TL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            label2.Location = new Point(45, 105);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 3;
            label2.Text = "EURO/TL:";
            // 
            // rdbDollar
            // 
            rdbDollar.AutoSize = true;
            rdbDollar.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            rdbDollar.Location = new Point(35, 219);
            rdbDollar.Name = "rdbDollar";
            rdbDollar.Size = new Size(94, 32);
            rdbDollar.TabIndex = 4;
            rdbDollar.TabStop = true;
            rdbDollar.Text = "Dolar";
            rdbDollar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            label3.Location = new Point(11, 142);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 6;
            label3.Text = "STERLİN/TL:";
            // 
            // lblSterlin
            // 
            lblSterlin.AutoSize = true;
            lblSterlin.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            lblSterlin.Location = new Point(184, 142);
            lblSterlin.Name = "lblSterlin";
            lblSterlin.Size = new Size(24, 28);
            lblSterlin.TabIndex = 5;
            lblSterlin.Text = "0";
            // 
            // rdbEuro
            // 
            rdbEuro.AutoSize = true;
            rdbEuro.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            rdbEuro.Location = new Point(184, 219);
            rdbEuro.Name = "rdbEuro";
            rdbEuro.Size = new Size(83, 32);
            rdbEuro.TabIndex = 7;
            rdbEuro.TabStop = true;
            rdbEuro.Text = "Euro";
            rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbSterlin
            // 
            rdbSterlin.AutoSize = true;
            rdbSterlin.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold);
            rdbSterlin.Location = new Point(312, 219);
            rdbSterlin.Name = "rdbSterlin";
            rdbSterlin.Size = new Size(106, 32);
            rdbSterlin.TabIndex = 8;
            rdbSterlin.TabStop = true;
            rdbSterlin.Text = "Sterlin";
            rdbSterlin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 323);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(171, 356);
            button1.Name = "button1";
            button1.Size = new Size(158, 50);
            button1.TabIndex = 11;
            button1.Text = "ÇEVİR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 277);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 12;
            label4.Text = "Tutar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 326);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 13;
            label5.Text = "Tutar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(492, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(rdbSterlin);
            Controls.Add(rdbEuro);
            Controls.Add(label3);
            Controls.Add(lblSterlin);
            Controls.Add(rdbDollar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEuro);
            Controls.Add(lblDollar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDollar;
        private Label lblEuro;
        private Label label1;
        private Label label2;
        private RadioButton rdbDollar;
        private Label label3;
        private Label lblSterlin;
        private RadioButton rdbEuro;
        private RadioButton rdbSterlin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
