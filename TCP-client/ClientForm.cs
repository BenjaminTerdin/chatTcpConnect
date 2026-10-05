using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_client
{
    public partial class ClientForm : Form
    {
        TcpClient client = new TcpClient();
        int port = 12345;
        public ClientForm()
        {
            InitializeComponent();
            client.NoDelay = true;
        }

        private void connStart_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                MessageBox.Show("Redan ansluten till servern.");
                return;
            }
            else
            {
                string ipAddress = sendIp.Text;
                ConnectToServer(ipAddress, port);
            }
        }

        public async void ConnectToServer(string ipAddress, int port)
        {
            try
            {
                IPAddress adress = IPAddress.Parse(ipAddress);
                await client.ConnectAsync(adress, port);
                MessageBox.Show("Ansluten till servern.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte ansluta till servern: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if(client.Connected && sendIp.Text != "") {
                byte[] outData = Encoding.UTF8.GetBytes(sendMsg.Text);
                client.GetStream().Write(outData, 0, outData.Length);

            } else
            {
                MessageBox.Show("Ingen ansluta till servern.");
            }
        }
    }
}
