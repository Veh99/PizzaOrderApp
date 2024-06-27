using System.Data;

namespace Front
{
    public partial class AccountSettings : Form
    {
        private BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

        public AccountSettings()
        {
            InitializeComponent();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            var orders = api.OrderAllAsync().GetAwaiter().GetResult();
            var userOrders = orders.Where(x => x.UserId == UserIDHolder.Id).ToList();

            orderGrid.DataSource = userOrders;
            orderGrid.Columns["UserId"].Visible = false;
            orderGrid.Columns["Id"].Visible = false;
            orderGrid.Columns["Pizzas"].Visible = false;
            var pizzas = new List<string>();
            int i = 0;
            foreach (var order in userOrders)
            {
                double total = 0;
                foreach (var item in order.Pizzas)
                {
                    pizzas.Add(item.Name);
                    total += item.Price;
                }
                orderGrid["PizzasList", i].Value = string.Join(", ", pizzas);
                orderGrid["Price", i].Value = total;
                pizzas.Clear();
                i++;
            }

            UserResponse user = api.UserGETAsync(UserIDHolder.Id).GetAwaiter().GetResult();
            loginBox.Text = user.UserName;
            addressBox.Text = user.Address;
            phoneBox.Text = user.PhoneNumber;
            passwordBox.Text = user.Password;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var main = new UserMain();
            main.Show();
            Close();
        }

        private void changeData_Click(object sender, EventArgs e)
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var reg = new Registration();
            reg.Show();
            Close();
        }

        private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}