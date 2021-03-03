namespace AccountManager
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblUserSamAccountName = new System.Windows.Forms.Label();
            this.txtSamAccountName = new System.Windows.Forms.TextBox();
            this.lblDomainControllers = new System.Windows.Forms.Label();
            this.gbAccountOptions = new System.Windows.Forms.GroupBox();
            this.chkUseDesEncryption = new System.Windows.Forms.CheckBox();
            this.chkDisableAccount = new System.Windows.Forms.CheckBox();
            this.chkCantChangePassword = new System.Windows.Forms.CheckBox();
            this.chkMustChangePassword = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExecute = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.chkPassNeverExpire = new System.Windows.Forms.CheckBox();
            this.chkNotRequireKerberos = new System.Windows.Forms.CheckBox();
            this.chkTrustedForDelegation = new System.Windows.Forms.CheckBox();
            this.chkReversibleEncryption = new System.Windows.Forms.CheckBox();
            this.chkSmartCardRequire = new System.Windows.Forms.CheckBox();
            this.chkSensitiveForDelegation = new System.Windows.Forms.CheckBox();
            this.gbAccountOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(177, 15);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Manage user\'s account options -";
            // 
            // lblUserSamAccountName
            // 
            this.lblUserSamAccountName.AutoSize = true;
            this.lblUserSamAccountName.Location = new System.Drawing.Point(12, 80);
            this.lblUserSamAccountName.Name = "lblUserSamAccountName";
            this.lblUserSamAccountName.Size = new System.Drawing.Size(111, 15);
            this.lblUserSamAccountName.TabIndex = 1;
            this.lblUserSamAccountName.Text = "sAMAccountName:";
            // 
            // txtSamAccountName
            // 
            this.txtSamAccountName.Location = new System.Drawing.Point(126, 72);
            this.txtSamAccountName.Name = "txtSamAccountName";
            this.txtSamAccountName.Size = new System.Drawing.Size(166, 23);
            this.txtSamAccountName.TabIndex = 2;
            this.txtSamAccountName.Text = "Viru";
            this.txtSamAccountName.TextChanged += new System.EventHandler(this.txtSamAccountName_TextChanged);
            // 
            // lblDomainControllers
            // 
            this.lblDomainControllers.AutoSize = true;
            this.lblDomainControllers.Location = new System.Drawing.Point(68, 42);
            this.lblDomainControllers.Name = "lblDomainControllers";
            this.lblDomainControllers.Size = new System.Drawing.Size(52, 15);
            this.lblDomainControllers.TabIndex = 3;
            this.lblDomainControllers.Text = "Domain:";
            // 
            // gbAccountOptions
            // 
            this.gbAccountOptions.Controls.Add(this.chkSensitiveForDelegation);
            this.gbAccountOptions.Controls.Add(this.chkSmartCardRequire);
            this.gbAccountOptions.Controls.Add(this.chkReversibleEncryption);
            this.gbAccountOptions.Controls.Add(this.chkTrustedForDelegation);
            this.gbAccountOptions.Controls.Add(this.chkNotRequireKerberos);
            this.gbAccountOptions.Controls.Add(this.chkPassNeverExpire);
            this.gbAccountOptions.Controls.Add(this.chkUseDesEncryption);
            this.gbAccountOptions.Controls.Add(this.chkDisableAccount);
            this.gbAccountOptions.Controls.Add(this.chkCantChangePassword);
            this.gbAccountOptions.Controls.Add(this.chkMustChangePassword);
            this.gbAccountOptions.Location = new System.Drawing.Point(15, 121);
            this.gbAccountOptions.Name = "gbAccountOptions";
            this.gbAccountOptions.Size = new System.Drawing.Size(277, 288);
            this.gbAccountOptions.TabIndex = 5;
            this.gbAccountOptions.TabStop = false;
            this.gbAccountOptions.Text = "Account Options";
            // 
            // chkUseDesEncryption
            // 
            this.chkUseDesEncryption.AutoSize = true;
            this.chkUseDesEncryption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDesEncryption.Location = new System.Drawing.Point(6, 105);
            this.chkUseDesEncryption.Name = "chkUseDesEncryption";
            this.chkUseDesEncryption.Size = new System.Drawing.Size(127, 19);
            this.chkUseDesEncryption.TabIndex = 13;
            this.chkUseDesEncryption.Text = "Use DES encryption";
            this.chkUseDesEncryption.UseVisualStyleBackColor = true;
            // 
            // chkDisableAccount
            // 
            this.chkDisableAccount.AutoSize = true;
            this.chkDisableAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisableAccount.Location = new System.Drawing.Point(6, 80);
            this.chkDisableAccount.Name = "chkDisableAccount";
            this.chkDisableAccount.Size = new System.Drawing.Size(135, 19);
            this.chkDisableAccount.TabIndex = 12;
            this.chkDisableAccount.Text = "Disable user account";
            this.chkDisableAccount.UseVisualStyleBackColor = true;
            // 
            // chkCantChangePassword
            // 
            this.chkCantChangePassword.AutoSize = true;
            this.chkCantChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCantChangePassword.Location = new System.Drawing.Point(6, 55);
            this.chkCantChangePassword.Name = "chkCantChangePassword";
            this.chkCantChangePassword.Size = new System.Drawing.Size(183, 19);
            this.chkCantChangePassword.TabIndex = 11;
            this.chkCantChangePassword.Text = "User cannot change password";
            this.chkCantChangePassword.UseVisualStyleBackColor = true;
            // 
            // chkMustChangePassword
            // 
            this.chkMustChangePassword.AutoSize = true;
            this.chkMustChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMustChangePassword.Location = new System.Drawing.Point(6, 30);
            this.chkMustChangePassword.Name = "chkMustChangePassword";
            this.chkMustChangePassword.Size = new System.Drawing.Size(244, 19);
            this.chkMustChangePassword.TabIndex = 10;
            this.chkMustChangePassword.Text = "User must change password at next logon";
            this.chkMustChangePassword.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(217, 415);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(126, 39);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(166, 23);
            this.txtDomain.TabIndex = 9;
            this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
            // 
            // chkPassNeverExpire
            // 
            this.chkPassNeverExpire.AutoSize = true;
            this.chkPassNeverExpire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPassNeverExpire.Location = new System.Drawing.Point(6, 155);
            this.chkPassNeverExpire.Name = "chkPassNeverExpire";
            this.chkPassNeverExpire.Size = new System.Drawing.Size(147, 19);
            this.chkPassNeverExpire.TabIndex = 14;
            this.chkPassNeverExpire.Text = "Password never expires";
            this.chkPassNeverExpire.UseVisualStyleBackColor = true;
            // 
            // chkNotRequireKerberos
            // 
            this.chkNotRequireKerberos.AutoSize = true;
            this.chkNotRequireKerberos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotRequireKerberos.Location = new System.Drawing.Point(6, 130);
            this.chkNotRequireKerberos.Name = "chkNotRequireKerberos";
            this.chkNotRequireKerberos.Size = new System.Drawing.Size(229, 19);
            this.chkNotRequireKerberos.TabIndex = 15;
            this.chkNotRequireKerberos.Text = "Not require kerberos preauthentication";
            this.chkNotRequireKerberos.UseVisualStyleBackColor = true;
            // 
            // chkTrustedForDelegation
            // 
            this.chkTrustedForDelegation.AutoSize = true;
            this.chkTrustedForDelegation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrustedForDelegation.Location = new System.Drawing.Point(6, 180);
            this.chkTrustedForDelegation.Name = "chkTrustedForDelegation";
            this.chkTrustedForDelegation.Size = new System.Drawing.Size(195, 19);
            this.chkTrustedForDelegation.TabIndex = 16;
            this.chkTrustedForDelegation.Text = "Account is trusted for delegation";
            this.chkTrustedForDelegation.UseVisualStyleBackColor = true;
            // 
            // chkReversibleEncryption
            // 
            this.chkReversibleEncryption.AutoSize = true;
            this.chkReversibleEncryption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReversibleEncryption.Location = new System.Drawing.Point(6, 205);
            this.chkReversibleEncryption.Name = "chkReversibleEncryption";
            this.chkReversibleEncryption.Size = new System.Drawing.Size(248, 19);
            this.chkReversibleEncryption.TabIndex = 17;
            this.chkReversibleEncryption.Text = "Store password using reversible encryption";
            this.chkReversibleEncryption.UseVisualStyleBackColor = true;
            // 
            // chkSmartCardRequire
            // 
            this.chkSmartCardRequire.AutoSize = true;
            this.chkSmartCardRequire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSmartCardRequire.Location = new System.Drawing.Point(6, 230);
            this.chkSmartCardRequire.Name = "chkSmartCardRequire";
            this.chkSmartCardRequire.Size = new System.Drawing.Size(248, 19);
            this.chkSmartCardRequire.TabIndex = 18;
            this.chkSmartCardRequire.Text = "Smart card is required for interactive logon";
            this.chkSmartCardRequire.UseVisualStyleBackColor = true;
            // 
            // chkSensitiveForDelegation
            // 
            this.chkSensitiveForDelegation.AutoSize = true;
            this.chkSensitiveForDelegation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSensitiveForDelegation.Location = new System.Drawing.Point(6, 255);
            this.chkSensitiveForDelegation.Name = "chkSensitiveForDelegation";
            this.chkSensitiveForDelegation.Size = new System.Drawing.Size(262, 19);
            this.chkSensitiveForDelegation.TabIndex = 19;
            this.chkSensitiveForDelegation.Text = "Account is sensitive and cannot be delegated";
            this.chkSensitiveForDelegation.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 476);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.gbAccountOptions);
            this.Controls.Add(this.lblDomainControllers);
            this.Controls.Add(this.txtSamAccountName);
            this.Controls.Add(this.lblUserSamAccountName);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 515);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbAccountOptions.ResumeLayout(false);
            this.gbAccountOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblUserSamAccountName;
        private System.Windows.Forms.TextBox txtSamAccountName;
        private System.Windows.Forms.Label lblDomainControllers;
        private System.Windows.Forms.GroupBox gbAccountOptions;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnExecute;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.CheckBox chkUseDesEncryption;
        private System.Windows.Forms.CheckBox chkDisableAccount;
        private System.Windows.Forms.CheckBox chkCantChangePassword;
        private System.Windows.Forms.CheckBox chkMustChangePassword;
        private System.Windows.Forms.CheckBox chkPassNeverExpire;
        private System.Windows.Forms.CheckBox chkNotRequireKerberos;
        private System.Windows.Forms.CheckBox chkSensitiveForDelegation;
        private System.Windows.Forms.CheckBox chkSmartCardRequire;
        private System.Windows.Forms.CheckBox chkReversibleEncryption;
        private System.Windows.Forms.CheckBox chkTrustedForDelegation;
    }
}

