using System.Windows;

namespace MultiWindowWPF.Dialogs {
    /// <summary>
    /// Interaction logic for NewUserWindow.xaml
    /// </summary>
    public partial class NewUserWindow : Window, IView {
        public NewUserViewModel ViewModel => (NewUserViewModel) this.DataContext;

        public NewUserWindow() {
            InitializeComponent();
            this.DataContext = new NewUserViewModel(this);
        }

        public void CloseDialog(bool result) {
            this.DialogResult = result;
            this.Close();
        }
    }
}
