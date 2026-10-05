using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;

namespace TCP_client
{
    public partial class ServerForm : Form
    {
        TcpListener listener;
        TcpClient client;
        int port = 12345;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {
            if (listener != null)
            {
                listener.Stop();
                listener = null;
                btnStarta.Text = "Starta";
                return;
            }
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}");
            }
            btnStarta.Text = "Aktiv";
            StartReceiver();
        }

        public async void StartReceiver()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accepting client: {ex.Message}");
                return;
            }
            StartReading(client);
        }

        public async void StartReading(TcpClient c)
        {
            byte[] buffer = new byte[1024];
            int n = 0;
            try
            {
                n = await c.GetStream().ReadAsync(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from client: {ex.Message}");
                return;
            }
            tbxInkorg.Text = Encoding.UTF8.GetString(buffer, 0, n);
    
            StartReading(c);
        }


    }
}

