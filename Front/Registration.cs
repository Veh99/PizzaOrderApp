using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Front
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void signInFormButton_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.Show();
            Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

            string login = loginRegBox.Text.Trim();
            string password = passwordRegBox.Text.Trim();
            string address = addressRegBox.Text.Trim();
            string phone = phoneRegBox.Text.Trim();

            var users = api.UserAllAsync().GetAwaiter().GetResult();
            var userExist = users.Any(u => u.UserName == login);
            if (!userExist && login != string.Empty && password != string.Empty && address != string.Empty && phone != string.Empty)
            {
                var newUser = new UserRequest
                {
                    UserName = login,
                    Address = address,
                    Password = password,
                    PhoneNumber = phone,
                };

                api.RegisterAsync(newUser).GetAwaiter().GetResult();
            }
            else
            {
                MessageBox.Show("User with this login already exists or you have to fill the empty fields");
            }
        }
    }
}