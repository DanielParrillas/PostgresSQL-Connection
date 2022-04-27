using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PostgreSQL_Connection
{
    public class Connection
    {
        //Se crea un objeto de conexion
        NpgsqlConnection postgreSQLConnection = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = 1325; Database = postgres");
        //Indica si el objeto esta conectado
        bool isConnected = false;

        //Establece conexion con la base de datos
        public void Connect()
        {
            //Se intenta conectar
            try
            {
                //Si no estamos conectados
                if (!isConnected)
                {
                    //Abre conexion con la base de datos
                    postgreSQLConnection.Open();
                }
                //Indica que estamos conectados
                isConnected = true;
                MessageBox.Show("List");
            }//Si no se logro establecer la conexion se indica
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.MessageText);
            }
        }

        //Ciera la conexion con la base de datos
        public void Disconnect()
        {
            //Se cierra la conexion
            postgreSQLConnection.Close();
            //Cambia el estado de la conexion
            isConnected = false;
            MessageBox.Show("La conexion se cerro");
        }

        //Retorna el estado de la conexion
        public bool IsConnected()
        {
            return isConnected;
        }
    }
}
