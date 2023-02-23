using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindowWPF.Core.Dialogs {
    public interface IUserDialogService {
        // An async version that will just delegate the non-async version
        Task<NewUserDialogResult> ShowNewUserDialogAsync(string defaultUsername = null, int defaultAge = 0);

        NewUserDialogResult ShowNewUserDialog(string defaultUsername = null, int defaultAge = 0);
    }
}
