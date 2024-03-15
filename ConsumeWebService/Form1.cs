using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeWebService
{
    public partial class Form1 : Form
    {
        localhost.ContactLessQRCodeWithdrawalService objservice = new localhost.ContactLessQRCodeWithdrawalService();
        localhost1.CCWQRCodeValidation QRCodeValidation = new localhost1.CCWQRCodeValidation();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":"""",""IPAddress"":""172.25.30.78"" ,""ServiceType"":""Test Service"", ""Location"":""ABC""}";
            }
            objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = objservice.GenerateQRCode(inpuJson);
            bool isValidBase64 = IsBase64String(respStr);
            if (isValidBase64)
            {
                byte[] imageBytes = Convert.FromBase64String(respStr);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    QRCodeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    QRCodeImage.Image = Image.FromStream(ms);
                    txtResponse.Text = respStr;
                }
            }
            else
            {
                txtResponse.Text = respStr;
            }
        }
        private void btnValidateQRCode_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230616115920"", ""DynamicCode"":""1493083911653841"",""TxnType"": ""02"",""TerminalID"":""AMRH0002"",""Location"":""AMRH0002"",""CardNumber"":""4111111111111111"",""AccountNo"":""4111111111111111"",""WalletAccountNumber"":""411111111111111198765"" }";
            }
            objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = objservice.ValidateQRCode(inpuJson);
            txtResponse.Text = respStr;
        }
        private void btnValidateOtp_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230614120821"", ""DynamicCode"":""0544541041238437"",""TerminalID"":""AMRH0002"",""Location"":""AMRH0002"",""OTPNumber"": ""8639"" }";
            }
            objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = objservice.ValidateQROTP(inpuJson);
            txtResponse.Text = respStr;
        }
        private void btnDispenceCash_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230616115501"",""TerminalID"":""AMRH0002"",""Location"":""AMRH0002"",""CardNumber"":""4111111111111111"",""WalletAccountNumber"":""411111111111111198765"", ""TxnType"": ""02"", ""CIF"":"""", ""txnAmount"":""300""}";
            }
            objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = objservice.DispenseCash(inpuJson);
            txtResponse.Text = respStr;
        }
        private void btnCancelTxn_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {

                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230614120821"",""TerminalID"":""AMRH0002"",""TxnCancelDesc"":""Request for cancel""}";
            }
            objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = objservice.TxnCancel(inpuJson);
            txtResponse.Text = respStr;
        }
        #region common Function
        public bool IsBase64String(string input)
        {
            bool respo = false;
            try
            {
                if (input.Length % 4 != 0)
                {
                    respo = false;
                }
                else
                {
                    byte[] data = Convert.FromBase64String(input);
                    respo = true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
            return respo;
        }
        #endregion

        private void btnQRValidated_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""IPAddress"":""172.25.30.78""}";
            }
           
            QRCodeValidation.AuthenticationHeaderValue = new localhost1.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = QRCodeValidation.IsQRCodeValidated(inpuJson);
            txtResponse.Text = respStr;
        }

        private void btnUpdateTxnStatus_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230704222159""}";
            }
            objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = objservice.UpdateTransactionStatus(inpuJson);
            txtResponse.Text = respStr;
        }

        private void btnOTPValidated_Click(object sender, EventArgs e)
        {
            //string inpuJson = txtRequest.Text;
            //if (string.IsNullOrEmpty(inpuJson))
            //{
            //    inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230704222159""}";
            //}
            //objservice.AuthenticationHeaderValue = new localhost.AuthenticationHeader()
            //{
            //    Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
            //    Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            //};
            //var respStr = objservice.IsOTPValidated(inpuJson);
            //txtResponse.Text = respStr;
        }

        private void btnOTPAndAmount_Click(object sender, EventArgs e)
        {
            string inpuJson = txtRequest.Text;
            if (string.IsNullOrEmpty(inpuJson))
            {
                inpuJson = @"{""MessageType"":""ENQUIRY"",""MsgFormat"":""REQUEST"",""ChannelId"":""ATM"",""TimeStamp"":""20230614103412"",""TransactionID"":""CCWAMRH000220230704222159""}";
            }
            QRCodeValidation.AuthenticationHeaderValue = new localhost1.AuthenticationHeader()
            {
                Username = txtUserName.Text.Trim() == "" ? "Admin" : txtUserName.Text,
                Password = txtPassword.Text.Trim() == "" ? "1009" : txtPassword.Text,
            };
            var respStr = QRCodeValidation.IsOTPAndAmountValidated(inpuJson);
            txtResponse.Text = respStr;
        }
    }
}