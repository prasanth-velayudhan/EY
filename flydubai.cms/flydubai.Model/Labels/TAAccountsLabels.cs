using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace flydubai.Model.Labels
{
    [DisplayName("TA Login Labels")]
    public class TAAccountLabels : BaseLabels
    {
        [DisplayName("LoginModuleTitle")]
        public string LoginModuleTitle { get; set; }

        [DisplayName("ForgottenPasswordConfirmationText")]
        public string ForgottenPasswordConfirmationText { get; set; }

        [DisplayName("AccountDoesNotExist")]
        public string AccountDoesNotExist { get; set; }

        [DisplayName("LoginUserName")]
        public string LoginUserName { get; set; }

        [DisplayName("LoginPassword")]
        public string LoginPassword { get; set; }

        [DisplayName("LoginButton")]
        public string LoginButton { get; set; }


        //public string Language { get; set; }
        [DisplayName("Internal Error")]
        public string InternalError { get; set; }
        
        [DisplayName("User Note found Error")]
        public string UserNotFound { get; set; }

        [DisplayName("User Locked Error")]
        public string UserLocked { get; set; }

        [DisplayName("Password Expired error")]
        public string PasswordExpired { get; set; }

        [DisplayName("Password Mismathc error")]
        public string PasswordMatchesPrevious { get; set; }

        [DisplayName("DB User Not Found")]
        public string DBUserNotFound { get; set; }

        [DisplayName("Too Many Failed Logins Within Duration")]
        public string TooManyFailedLoginsWithinDuration { get; set; }

        [DisplayName("User Unlocked")]
        public string UserUnlocked { get; set; }

        [DisplayName("Password Does Not Match")]
        public string PasswordDoesNotMatch { get; set; }

        [DisplayName("User Created")]
        public string UserCreated { get; set; }

        [DisplayName("User Not Created")]
        public string UserNotCreated { get; set; }

        [DisplayName("Not An Administrator")]
        public string NotAnAdministrator { get; set; }

        [DisplayName("User AlreadyExists")]
        public string UserAlreadyExists { get; set; }

        [DisplayName("User Disabled Due To Inactivity")]
        public string UserDisabledDueToInactivity { get; set; }

        [DisplayName("Page Title")]
        public string PageTitle { get; set; }

        [DisplayName("Use Name")]
        public string Username { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Blank user name error message")]
        public string BlankUsernameTextBox { get; set; }

        [DisplayName("Password changed message")]
        public string PasswordChanged { get; set; }

        [DisplayName("Incomplete Data")]
        public string IncompleteData { get; set; }

        [DefaultValue("Enter your user name and email address below. Click the “Reset Password” button and we will send you a new password.")]
        public string ForgottenUserPasswordMessage { get; set; }

        [DefaultValue("Reset Password")]
        public string ForgottenUserPasswordReset { get; set; }

        [DefaultValue("The password has been reset and sent to the registered email.")]
        public string ForgottenUserPasswordSuccess { get; set; }

        [DefaultValue("System could not find a record matching the specified user name or email.")]
        public string ForgottenUserPasswordFailed { get; set; }

        [DefaultValue("Information")]
        public string ForgottenUserPasswordInformation { get; set; }

        [DefaultValue("OK")]
        public string ForgottenUserPasswordOK { get; set; }

        [DefaultValue("Agency Top-up")]
        public string AgencyTopupLinkText { get; set; }
    }
}
