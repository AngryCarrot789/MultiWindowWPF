using System.Threading.Tasks;
using System.Windows;
using MultiWindowWPF.Core.Dialogs;

namespace MultiWindowWPF.Dialogs {
    public class UserDialogService : IUserDialogService {
        public NewUserDialogResult ShowNewUserDialog(string defaultUsername = null, int defaultAge = 0) {
            NewUserWindow window = new NewUserWindow();
            // set default parameters for the UI
            window.ViewModel.Name = defaultUsername ?? "New user";
            window.ViewModel.Age = defaultAge;

            bool result = window.ShowDialog() == true; // ShowDialog() returns a nullable bool

            if (!result) {
                // DialogResult failed, so return an empty result with a failure state
                return new NewUserDialogResult() { IsSuccess = false };
            }

            return new NewUserDialogResult() {
                Username = window.ViewModel.Name,
                Age = window.ViewModel.Age,
                IsSuccess = true
            };
        }

        // async so that it can await the dispatcher
        public async Task<NewUserDialogResult> ShowNewUserDialogAsync(string defaultUsername = null, int defaultAge = 0) {
            return await Application.Current.Dispatcher.InvokeAsync(() => {
                return ShowNewUserDialog(defaultUsername, defaultAge);
            });
        }
    }
}
