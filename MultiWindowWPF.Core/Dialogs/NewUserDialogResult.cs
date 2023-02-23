using System;
using System.Collections.Generic;
using System.Text;

namespace MultiWindowWPF.Core.Dialogs {
    /// <summary>
    /// Contains information about a dialog result for creating a user
    /// </summary>
    public class NewUserDialogResult {
        public bool IsSuccess { get; set; }

        public string Username { get; set; }

        public int Age { get; set; }
    }
}
