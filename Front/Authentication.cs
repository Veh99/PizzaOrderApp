using System.ComponentModel;
using System.Net;

namespace Front
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        public void signInButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            BackApi api = new BackApi("http://localhost:5119/", new HttpClient());
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    var request = new UserLoginRequest
                    {
                        UserName = login,
                        Password = password
                    };

                    var token = api.LoginAsync(request).GetAwaiter().GetResult();

                    if (request.UserName != "admin")
                    {
                        var allUsers = api.UserAllAsync().GetAwaiter().GetResult();
                        UserResponse? signedUser = allUsers.First(u => u.UserName == login);
                        UserIDHolder.Id = signedUser.Id;
                        UserMain main = new UserMain();
                        main.Show();
                        Close();
                    }
                    else
                    {
                        AdminPanel admin = new AdminPanel();
                        admin.Show();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}