namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Simple validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please enter both username and password.", "OK");
                return;
            }

            // Here, you would typically check the credentials against a database or API
            if (username == "admin" && password == "password") // Example credentials
            {
                await DisplayAlert("Success", "Login successful!", "OK");
                // Navigate to the next page or perform additional actions
            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password. Please try again.", "OK");
            }
        }
    }

}
