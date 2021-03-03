/********************** Module - UserPrincipal Extension *****************\
* Module Name:  Extension.cs
* Project:      AccountManager
* Date:         11th Jan, 2015
* Copyright (c) Vikram Singh Saini      
* Credit:       http://www.codeproject.com/Articles/118122/How-to-use-AD-Attributes-not-represented-in-UserPr
* 
* Provide way for modifying AD Attributes not represented in UserPrincipal.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\**************************************************************************/
using System.DirectoryServices.AccountManagement;

namespace AccountManager
{
    [DirectoryRdnPrefix("CN")]
    [DirectoryObjectClass("user")]
    public class UserPrincipalEx : UserPrincipal
    {
        #region Constructors

        public UserPrincipalEx(PrincipalContext context) : base(context)
        {
        }

        public UserPrincipalEx(PrincipalContext context,
            string samAccountName,
            string password,
            bool enabled)
            : base(context, samAccountName, password, enabled)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get or sets nullable int value that specifies whether user must change password at next logon.
        /// </summary>
        [DirectoryProperty("pwdLastSet")]
        public int? MustChangePassword
        {
            get
            {
                if (ExtensionGet("pwdLastSet").Length != 1)
                    return null;
                return (int)ExtensionGet("pwdLastSet")[0];
            }
            set { ExtensionSet("pwdLastSet", value); }
        }

        /// <summary>
        /// Get or sets nullable int value that specifies whether DES encryption be used.
        /// </summary>
        [DirectoryProperty("userAccountControl")]
        public int? UseDESEncryption
        {
            get
            {
                if (ExtensionGet("userAccountControl").Length != 1)
                    return null;
                return (int)ExtensionGet("userAccountControl")[0];
            }
            set { ExtensionSet("userAccountControl", value); }
        }

        /// <summary>
        /// Get or sets nullable int value that specifies whether kerberos preauthentication required.
        /// </summary>
        [DirectoryProperty("userAccountControl")]
        public int? NotRequireKerberos
        {
            get
            {
                if (ExtensionGet("userAccountControl").Length != 1)
                    return null;
                return (int)ExtensionGet("userAccountControl")[0];
            }
            set { ExtensionSet("userAccountControl", value); }
        }

        /// <summary>
        /// Get or sets nullable int value that specifies whether account is trusted for delegation.
        /// </summary>
        [DirectoryProperty("userAccountControl")]
        public int? TrustedForDelegation
        {
            get
            {
                if (ExtensionGet("userAccountControl").Length != 1)
                    return null;
                return (int)ExtensionGet("userAccountControl")[0];
            }
            set { ExtensionSet("userAccountControl", value); }
        }

        #endregion

        #region Methods

        public new static UserPrincipalEx FindByIdentity(PrincipalContext context, string identityValue)
        {
            return (UserPrincipalEx) FindByIdentityWithType(context, typeof (UserPrincipalEx), identityValue);
        }

        public new static UserPrincipalEx FindByIdentity(PrincipalContext context, IdentityType identityType,
            string identityValue)
        {
            return
                (UserPrincipalEx) FindByIdentityWithType(context, typeof (UserPrincipalEx), identityType, identityValue);
        }

        #endregion
    }
}
