using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Biblioteca.Services
{
    public class ServiceConnection
    {
        // String de conexão com o banco de dados
        public SqlConnection conn = new SqlConnection("Data Source=localhost\\localhost;Initial Catalog=ESTOQUE;Integrated Security=True");

        public string GetStringConnection()
        {
            return this.conn.ToString();
        }
    }
}
