using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using MultiWindowWPF.Core.Dialogs;

namespace MultiWindowWPF.Core {
    public class UserManagerViewModel : BaseViewModel {
        public ICommand NewUserCommand { get; }

        public ObservableCollection<UserViewModel> Users { get; }

        public UserManagerViewModel() {
            this.Users = new ObservableCollection<UserViewModel>();
            this.NewUserCommand = new RelayCommand(this.NewUserAction);
        }

        public void NewUserAction() {
            // If all is well, this should return an instance of UserDialogService, in API form!
            IUserDialogService service = IoC.Provide<IUserDialogService>();

            NewUserDialogResult result = service.ShowNewUserDialog("New user " + this.Users.Count, 69);
            if (result.IsSuccess) { // ignore failed attempts/cancelled

                // add new user!
                this.Users.Add(new UserViewModel() { Name = result.Username, Age = result.Age });
            }
        }
    }
}
