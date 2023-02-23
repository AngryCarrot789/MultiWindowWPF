using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MultiWindowWPF.Core;

namespace MultiWindowWPF.Dialogs {
    public class NewUserViewModel : UserViewModel {
        public ICommand OKCommand { get; }
        public ICommand CancelCommand { get; }

        public IView View { get; }

        public NewUserViewModel(IView view) {
            this.View = view;

            this.OKCommand = new RelayCommand(this.OkAction);
            this.CancelCommand = new RelayCommand(this.CancelAction);
        }

        public void OkAction() {
            this.View.CloseDialog(true); // close it with a successful result
        }

        public void CancelAction() {
            this.View.CloseDialog(false); // close it with a failed result
        }
    }
}
