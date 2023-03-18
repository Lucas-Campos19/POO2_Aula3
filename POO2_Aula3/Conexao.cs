using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO2_Aula3
{
    internal class Conexao // classe de conexão com o banco de dados.
    {
        static private string servidor = "";
        static private string banco = "bd_aula3";
        static private string usuario = "root";
        static private string senha = "cursoads"; // todos as variaveis em forma estatica cada variavel recebe os dados do banco para a classe ter acesso ao banco.

        static public string strConn = $"server={servidor};database={banco}; User Id={usuario}; password={senha}"; // conexão do banco de dados a classe conexão recebendo todos os parametros das variaveis listadas acima.

        MySqlConnection cn;

        private bool Conectar()
        {
            bool result;
            try
            {
                cn = new MySqlConnection(strConn);
                cn.Open();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }
        private void Desconectar()
        {
            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
        private bool Executar(string sql)
        {
            bool resultado = false;
            if (Conectar())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch
                {
                    resultado = false;
                }
                finally
                {
                    Desconectar();
                }
            }
            return resultado;
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
