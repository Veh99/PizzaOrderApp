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
    public partial class PizzaCRUD : Form
    {
        private BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

        public PizzaCRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminPanel = new AdminPanel();
            adminPanel.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.PizzaDELETEAsync(PizzaId.Id).GetAwaiter().GetResult();
            MessageBox.Show("Pizza was deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != string.Empty && decriptionBox.Text != string.Empty && priceBox.Text != string.Empty)
            {
                double price = Convert.ToDouble(priceBox.Text);
                var pizza = new PizzaRequest
                {
                    Name = nameBox.Text,
                    Description = decriptionBox.Text,
                    Price = price,
                };

                api.PizzaPUTAsync(PizzaId.Id, pizza).GetAwaiter().GetResult();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != string.Empty && decriptionBox.Text != string.Empty && priceBox.Text != string.Empty)
            {
                double price = Convert.ToDouble(priceBox.Text);
                var pizza = new PizzaRequest
                {
                    Name = nameBox.Text,
                    Description = decriptionBox.Text,
                    Price = price,
                };

                var pizzas = api.PizzaAllAsync().GetAwaiter().GetResult();
                bool pizzaExist = pizzas.Any(p => p.Name == pizza.Name);
                if (!pizzaExist) api.PizzaPOSTAsync(Guid.NewGuid(), pizza).GetAwaiter().GetResult();
                else MessageBox.Show("This pizza already exists");
            }
        }

        private void PizzaCRUD_Load(object sender, EventArgs e)
        {
            var pizza = api.PizzaGETAsync(PizzaId.Id).GetAwaiter().GetResult();
            nameBox.Text = pizza.Name;
            decriptionBox.Text = pizza.Description;
            priceBox.Text = pizza.Price.ToString();
        }
    }
}