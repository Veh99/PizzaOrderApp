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
    public partial class AdminPanel : Form
    {
        private BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

        public AdminPanel()
        {
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            var users = api.UserAllAsync().GetAwaiter().GetResult();
            usersGrid.DataSource = users;
            usersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var pizzas = api.PizzaAllAsync().GetAwaiter().GetResult();
            menuGrid.DataSource = pizzas;
            menuGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var orders = api.OrderAllAsync().GetAwaiter().GetResult();

            ordersGrid.DataSource = orders;
            ordersGrid.Columns["Pizzas"].Visible = false;
            var pizzaList = new List<string>();
            int i = 0;
            foreach (var order in orders)
            {
                double total = 0;
                foreach (var item in order.Pizzas)
                {
                    pizzaList.Add(item.Name);
                    total += item.Price;
                }
                ordersGrid["PizzaList", i].Value = string.Join(", ", pizzaList);
                ordersGrid["Total", i].Value = total;
                pizzaList.Clear();
                i++;
            }
            ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Close();
        }

        private void menuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var stringId = menuGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            PizzaId.Id = new Guid(stringId);
            var pizzaCrud = new PizzaCRUD();
            pizzaCrud.Show();
            Close();
        }

        private void OrderCall()
        {
            var orders = api.OrderAllAsync().GetAwaiter().GetResult();
            ordersGrid.DataSource = orders;
            ordersGrid.Columns["Pizzas"].Visible = false;
            var pizzaList = new List<string>();
            int i = 0;
            foreach (var order in orders)
            {
                double total = 0;
                foreach (var item in order.Pizzas)
                {
                    pizzaList.Add(item.Name);
                    total += item.Price;
                }
                ordersGrid["Total", i].Value = total;
                ordersGrid["PizzaList", i].Value = string.Join(", ", pizzaList);
                pizzaList.Clear();
                i++;
            }
            ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ordersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderId = ordersGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            OrderId.Id = new Guid(orderId);
            var orderForm = new OrderForm();
            orderForm.Show();
            Close();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UserCall();
            //OrderCall();
        }

        private void UserCall()
        {
            var users = api.UserAllAsync().GetAwaiter().GetResult();
            usersGrid.DataSource = users;
        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string userId = usersGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            UserIDHolder.Id = new Guid(userId!);
            var userCrud = new UserCRUD();
            userCrud.Show();
            Close();
        }
    }

    public class OrderId
    {
        public static Guid Id { get; set; }
    }

    public class PizzaId
    {
        public static Guid Id { get; set; }
    }
}