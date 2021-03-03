using System;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 1. Get domain and domain controllers
            var currDomain = Domain.GetCurrentDomain();
            txtDomain.Text = currDomain.Name;

            if (!string.IsNullOrEmpty(currDomain.Name))
            {
                btnExecute.Enabled = true;
            }
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {
            CheckForEmpty(txtDomain);
        }

        private void txtSamAccountName_TextChanged(object sender, EventArgs e)
        {
            CheckForEmpty(txtSamAccountName);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!CheckForEmpty(txtSamAccountName) || !CheckForEmpty(txtDomain)) return;

            // Create object data for passing to background thread
            var data = new object[]
                       {
                           txtDomain.Text, 
                           txtSamAccountName.Text,
                           chkMustChangePassword.Checked,
                           chkCantChangePassword.Checked,
                           chkDisableAccount.Checked,
                           chkUseDesEncryption.Checked,
                           chkNotRequireKerberos.Checked,
                           chkPassNeverExpire.Checked,
                           chkTrustedForDelegation.Checked,
                           chkReversibleEncryption.Checked,
                           chkSmartCardRequire.Checked,
                           chkSensitiveForDelegation.Checked
                       };

            btnExecute.Enabled = false;
            bgWorker.RunWorkerAsync(data);
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Retrieve different details from array
            var data = (object[])e.Argument;
            var domainName = (string)data[0];
            var sAMAccountName = (string)data[1];
            var mustChangePass = (bool)data[2];
            var cantChangePass = (bool)data[3];
            var disableAccount = (bool)data[4];
            var useDesEncryp = (bool)data[5];
            var notRequireKerberos = (bool)data[6];
            var passNeverExpire = (bool)data[7];
            var trustedForDelegation = (bool)data[8];
            var reversibleEncryption = (bool)data[9];
            var smartCardRequire = (bool)data[10];
            var sensitiveForDelegation = (bool)data[11];

            // Partial credit : http://support.microsoft.com/kb/305144
            using (var principalContext = new PrincipalContext(ContextType.Domain, domainName))
            {
                var userPrincipal = UserPrincipalEx.FindByIdentity(principalContext, sAMAccountName);
                if (userPrincipal == null) return;

                // 1. Must change password
                if (mustChangePass)
                    userPrincipal.ExpirePasswordNow();
                else
                    userPrincipal.MustChangePassword = -1;

                // 2. Can't change password
                userPrincipal.UserCannotChangePassword = cantChangePass;

                // 3. Account disable
                userPrincipal.Enabled = !disableAccount;

                // 4. Use DES Encryption
                if (useDesEncryp)
                    userPrincipal.UseDESEncryption = userPrincipal.UseDESEncryption | 0x200000;
                else
                    userPrincipal.UseDESEncryption = userPrincipal.UseDESEncryption & ~0x200000;

                // 5. Don't require kerberos pre-authentication
                if (notRequireKerberos)
                    userPrincipal.NotRequireKerberos = userPrincipal.NotRequireKerberos | 0x400000;
                else
                    userPrincipal.NotRequireKerberos = userPrincipal.NotRequireKerberos & ~0x400000;

                // 6. Password never expires
                userPrincipal.PasswordNeverExpires = passNeverExpire;

                // 7. Trusted for delegation  (NOT PRESENT)
                if (trustedForDelegation)
                    userPrincipal.TrustedForDelegation = userPrincipal.TrustedForDelegation | 0x80000;
                else
                    userPrincipal.TrustedForDelegation = userPrincipal.TrustedForDelegation & ~0x80000;

                // 8. Store password using reversible encryption
                userPrincipal.AllowReversiblePasswordEncryption = reversibleEncryption;

                // 9. Smart card is required for interactive logon
                userPrincipal.SmartcardLogonRequired = smartCardRequire;

                // 10. Account is sensitive and cannot be delegated
                userPrincipal.DelegationPermitted = !sensitiveForDelegation;

                // Save all modifications done
                userPrincipal.Save();
                e.Result = string.Format("Account options executed on user '{0}' successfully!", sAMAccountName);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = (string)e.UserState;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnExecute.Enabled = true;
            if (e.Error != null)
            {
                lblStatus.Text = "Error occured";
                MessageBox.Show("Error occured\n\n" + e.Error.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                lblStatus.Text = (string)e.Result;
            }
        }

        #region HELPERS

        /// <summary>
        /// Show error for text controls if the text is blank.
        /// </summary>
        /// <param name="textBox">The textbox control</param>
        /// <returns>Return true if there is text else false</returns>
        private bool CheckForEmpty(Control textBox)
        {
            bool valid;

            if (textBox.Text.Trim().Length > 0)
            {
                valid = true;
                errorProvider.SetError(textBox, string.Empty);
            }
            else
            {
                valid = false;
                errorProvider.SetIconPadding(textBox, 5);
                errorProvider.SetError(textBox, "Value can't be blank.");
            }

            return valid;
        }

        #endregion
    }
}
