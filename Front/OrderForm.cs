using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class OrderForm : Form
    {
        private BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

        public OrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var order = api.OrderGETAsync(OrderId.Id).GetAwaiter().GetResult();
            if (statusBox.Text != string.Empty)
            {
                var orderRequest = new OrderRequest
                {
                    Status = statusBox.Text,
                    UserId = order.UserId,
                    Pizzas = order.Pizzas,
                };
                api.OrderPUTAsync(OrderId.Id, orderRequest).GetAwaiter().GetResult();
            }
            else
            {
                MessageBox.Show("Fill the empty field");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.Show();
            Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var order = api.OrderGETAsync(OrderId.Id).GetAwaiter().GetResult();
            statusBox.Text = order.Status;
        }
    }
}