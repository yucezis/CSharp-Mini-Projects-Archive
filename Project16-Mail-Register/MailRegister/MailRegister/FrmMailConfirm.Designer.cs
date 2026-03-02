namespace MailRegister
{
    partial class FrmMailConfirm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtConfirmCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.Location = new System.Drawing.Point(217, 204);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(285, 56);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Aktivasyonu Tamamla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtConfirmCode
            // 
            this.txtConfirmCode.Location = new System.Drawing.Point(338, 155);
            this.txtConfirmCode.Name = "txtConfirmCode";
            this.txtConfirmCode.Size = new System.Drawing.Size(164, 22);
            this.txtConfirmCode.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(131, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Aktivasyon Kodu";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(338, 108);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(164, 22);
            this.txtMail.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mail";
            // 
            // FrmMailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(725, 416);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtConfirmCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Name = "FrmMailConfirm";
            this.Text = "FrmMailConfirm";
            this.Load += new System.EventHandler(this.FrmMailConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtConfirmCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
    }
}