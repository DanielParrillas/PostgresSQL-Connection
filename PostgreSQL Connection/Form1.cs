using System.Windows.Forms;

namespace PostgreSQL_Connection
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se conecta a la base de datos
            connection.Connect();
            //El label cambiara a conectado si se logro conectar con la base de datos
            if (connection.IsConnected())
            {
                labelConnectionState.Text = "Connected";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //connection.Disconnect();
            //labelConnectionState.Text = "Disconnected";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Se esta cerrando el formulario");
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            //Se desconecta de la base de datos
            connection.Disconnect();
            //Se cambia el estado del label
            labelConnectionState.Text = "Disconnected";
        }
    }
}