using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Classes
{
    internal class Conectarbanco
    {
        private static string server = @"KAIO-ALVES\SQLEXPRESS"; // Nome do servidor local 
        private static string dataBase = "PROGRAMA"; // Nome do banco de dados
        private static string user = "NomeUsuario"; //  se o banco tiver usuario
        private static string password = "senha"; // senha do banco

        public static string Cn
        {
            get
            {
                return "Data Source=" + server + ";integrated security = true;initial catalog=" +
                        dataBase + "; User id=" + user + ";Password=" + password;
            }
        }
    }


}
