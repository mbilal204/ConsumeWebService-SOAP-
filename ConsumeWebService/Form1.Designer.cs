
namespace ConsumeWebService
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
            this.QRCodeImage = new System.Windows.Forms.PictureBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidateOtp = new System.Windows.Forms.Button();
            this.btnValidateQRCode = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDispenceCash = new System.Windows.Forms.Button();
            this.txtRequest = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelTxn = new System.Windows.Forms.Button();
            this.btnQRValidated = new System.Windows.Forms.Button();
            this.btnUpdateTxnStatus = new System.Windows.Forms.Button();
            this.btnOTPAndAmount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodeImage
            // 
            this.QRCodeImage.Location = new System.Drawing.Point(811, 9);
            this.QRCodeImage.Name = "QRCodeImage";
            this.QRCodeImage.Size = new System.Drawing.Size(290, 259);
            this.QRCodeImage.TabIndex = 1;
            this.QRCodeImage.TabStop = false;
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Location = new System.Drawing.Point(18, 197);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(183, 57);
            this.btnGenerateQRCode.TabIndex = 2;
            this.btnGenerateQRCode.Text = "Generate QRCode";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(0, 431);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(1101, 222);
            this.txtResponse.TabIndex = 4;
            this.txtResponse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Response";
            // 
            // btnValidateOtp
            // 
            this.btnValidateOtp.Location = new System.Drawing.Point(607, 197);
            this.btnValidateOtp.Name = "btnValidateOtp";
            this.btnValidateOtp.Size = new System.Drawing.Size(183, 57);
            this.btnValidateOtp.TabIndex = 6;
            this.btnValidateOtp.Text = "Mob Validate OTP";
            this.btnValidateOtp.UseVisualStyleBackColor = true;
            this.btnValidateOtp.Click += new System.EventHandler(this.btnValidateOtp_Click);
            // 
            // btnValidateQRCode
            // 
            this.btnValidateQRCode.Location = new System.Drawing.Point(396, 197);
            this.btnValidateQRCode.Name = "btnValidateQRCode";
            this.btnValidateQRCode.Size = new System.Drawing.Size(205, 57);
            this.btnValidateQRCode.TabIndex = 3;
            this.btnValidateQRCode.Text = "Mob Validate QRCode";
            this.btnValidateQRCode.UseVisualStyleBackColor = true;
            this.btnValidateQRCode.Click += new System.EventHandler(this.btnValidateQRCode_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(21, 34);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(264, 26);
            this.txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(305, 34);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(264, 26);
            this.txtPassword.TabIndex = 13;
            // 
            // btnDispenceCash
            // 
            this.btnDispenceCash.Location = new System.Drawing.Point(218, 260);
            this.btnDispenceCash.Name = "btnDispenceCash";
            this.btnDispenceCash.Size = new System.Drawing.Size(183, 57);
            this.btnDispenceCash.TabIndex = 15;
            this.btnDispenceCash.Text = "Dispense Cash";
            this.btnDispenceCash.UseVisualStyleBackColor = true;
            this.btnDispenceCash.Click += new System.EventHandler(this.btnDispenceCash_Click);
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(16, 96);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(735, 84);
            this.txtRequest.TabIndex = 17;
            this.txtRequest.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Request ";
            // 
            // btnCancelTxn
            // 
            this.btnCancelTxn.Location = new System.Drawing.Point(407, 260);
            this.btnCancelTxn.Name = "btnCancelTxn";
            this.btnCancelTxn.Size = new System.Drawing.Size(183, 57);
            this.btnCancelTxn.TabIndex = 19;
            this.btnCancelTxn.Text = "Cancel Transaction";
            this.btnCancelTxn.UseVisualStyleBackColor = true;
            this.btnCancelTxn.Click += new System.EventHandler(this.btnCancelTxn_Click);
            // 
            // btnQRValidated
            // 
            this.btnQRValidated.Location = new System.Drawing.Point(207, 197);
            this.btnQRValidated.Name = "btnQRValidated";
            this.btnQRValidated.Size = new System.Drawing.Size(183, 57);
            this.btnQRValidated.TabIndex = 20;
            this.btnQRValidated.Text = "Is QR Validated";
            this.btnQRValidated.UseVisualStyleBackColor = true;
            this.btnQRValidated.Click += new System.EventHandler(this.btnQRValidated_Click);
            // 
            // btnUpdateTxnStatus
            // 
            this.btnUpdateTxnStatus.Location = new System.Drawing.Point(607, 260);
            this.btnUpdateTxnStatus.Name = "btnUpdateTxnStatus";
            this.btnUpdateTxnStatus.Size = new System.Drawing.Size(183, 57);
            this.btnUpdateTxnStatus.TabIndex = 21;
            this.btnUpdateTxnStatus.Text = "Update Txn Status";
            this.btnUpdateTxnStatus.UseVisualStyleBackColor = true;
            this.btnUpdateTxnStatus.Click += new System.EventHandler(this.btnUpdateTxnStatus_Click);
            // 
            // btnOTPAndAmount
            // 
            this.btnOTPAndAmount.Location = new System.Drawing.Point(18, 260);
            this.btnOTPAndAmount.Name = "btnOTPAndAmount";
            this.btnOTPAndAmount.Size = new System.Drawing.Size(183, 57);
            this.btnOTPAndAmount.TabIndex = 23;
            this.btnOTPAndAmount.Text = "Validate OTP and Amount";
            this.btnOTPAndAmount.UseVisualStyleBackColor = true;
            this.btnOTPAndAmount.Click += new System.EventHandler(this.btnOTPAndAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 656);
            this.Controls.Add(this.btnOTPAndAmount);
            this.Controls.Add(this.btnUpdateTxnStatus);
            this.Controls.Add(this.btnQRValidated);
            this.Controls.Add(this.btnCancelTxn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.btnDispenceCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnValidateQRCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnValidateOtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.QRCodeImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox QRCodeImage;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidateOtp;
        private System.Windows.Forms.Button btnValidateQRCode;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDispenceCash;
        private System.Windows.Forms.RichTextBox txtRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelTxn;
        private System.Windows.Forms.Button btnQRValidated;
        private System.Windows.Forms.Button btnUpdateTxnStatus;
        private System.Windows.Forms.Button btnOTPAndAmount;
    }
}

