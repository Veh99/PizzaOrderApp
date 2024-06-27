using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class UserCRUD : Form
    {
        private BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

        public UserCRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != string.Empty && passwordBox.Text != string.Empty && addressBox.Text != string.Empty && phoneBox.Text != string.Empty)
            {
                var user = new UserRequest
                {
                    UserName = loginBox.Text,
                    Address = addressBox.Text,
                    PhoneNumber = phoneBox.Text,
                    Password = passwordBox.Text,
                };

                api.UserPUTAsync(UserIDHolder.Id, user).GetAwaiter().GetResult();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var adminPanel = new AdminPanel();
            adminPanel.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.UserDELETEAsync(UserIDHolder.Id).GetAwaiter().GetResult();
            MessageBox.Show("User was deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != string.Empty && passwordBox.Text != string.Empty && addressBox.Text != string.Empty && phoneBox.Text != string.Empty)
            {
                var user = new UserRequest
                {
                    UserName = loginBox.Text,
                    Address = addressBox.Text,
                    PhoneNumber = phoneBox.Text,
                    Password = passwordBox.Text,
                };
                var users = api.UserAllAsync().GetAwaiter().GetResult();
                var userExist = users.Any(u => u.UserName == user.UserName);
                if (!userExist)
                {
                    api.UserPOSTAsync(Guid.NewGuid(), user).GetAwaiter().GetResult();
                    MessageBox.Show("New user was added");
                }
                else
                {
                    MessageBox.Show("User with this login already exists");
                }
            }
        }

        private void UserCRUD_Load(object sender, EventArgs e)
        {
            var user = api.UserGETAsync(UserIDHolder.Id).GetAwaiter().GetResult();
            loginBox.Text = user.UserName;
            addressBox.Text = user.Address;
            phoneBox.Text = user.PhoneNumber;
            passwordBox.Text = user.Password;
        }
    }
}