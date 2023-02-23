using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MultiWindowWPF.Core;
using MultiWindowWPF.Core.Dialogs;
using MultiWindowWPF.Dialogs;

namespace MultiWindowWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            // Register the API type with our API instance
            IoC.Register<IUserDialogService>(new UserDialogService());
            this.DataContext = new UserManagerViewModel();
        }
    }
}
