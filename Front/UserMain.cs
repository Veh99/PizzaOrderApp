using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Front
{
    public partial class UserMain : Form
    {
        private readonly HubConnection? hubConnection;
        private BackApi api = new BackApi("http://localhost:5119/", new HttpClient());

        public UserMain()
        {
            InitializeComponent();

            hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5119/chat")
                .Build();
        }

        public void MenuCall()
        {
            bool flag = false;
            foreach (DataGridViewRow row in menuGrid.Rows)
            {
                var state = Convert.ToBoolean(row.Cells["CheckBox"].Value);
                if (state == true)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                var pizzas = api.PizzaAllAsync().GetAwaiter().GetResult();
                menuGrid.DataSource = pizzas;
            }
        }

        private void accountSettingsButton_Click(object sender, EventArgs e)
        {
            var accSet = new AccountSettings();
            accSet.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pizzazId = new List<Guid>();
            foreach (DataGridViewRow row in menuGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    var str = menuGrid.Rows[row.Index].Cells[1].Value.ToString();
                    Guid id = new Guid(str!);
                    pizzazId.Add(id);
                }
            }
            if (pizzazId.Count != 0)
            {
                api.OrderPOSTAsync(Guid.NewGuid(), UserIDHolder.Id, "new", pizzazId).GetAwaiter().GetResult();
                MessageBox.Show("You successfully made order");
            }
            else
                MessageBox.Show("You have to choose at least one pizza");
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            var byteCount = ASCIIEncoding.Unicode.GetByteCount(messageBox.Text);
            if (messageBox.Text != string.Empty && byteCount <= 1024)
            {
                try
                {
                    hubConnection!.On<string, string>("Recieve", (user, message) =>
                    {
                        Invoke(() =>
                        {
                            var newMessage = $"{user}: {message}";
                            chatBox.Items.Add(newMessage);
                        });
                    });
                    var user = api.UserGETAsync(UserIDHolder.Id).GetAwaiter().GetResult();
                    hubConnection!.InvokeAsync("SendMessage", user.UserName, messageBox.Text).GetAwaiter().GetResult();
                    messageBox.Clear();
                }
                catch (Exception ex)
                {
                    chatBox.Items.Add(ex.Message);
                }
            }
            else
            {
                messageBox.Clear();
                messageBox.Text = "Too long message";
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            MenuCall();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            try
            {
                hubConnection!.StartAsync().GetAwaiter().GetResult();
                chatBox.Items.Add("You entered the chat");
                SendMessage.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var pizzas = api.PizzaAllAsync().GetAwaiter().GetResult().ToList();
            menuGrid.DataSource = pizzas;
            menuGrid.Columns["Id"].Visible = false;
        }
    }
}