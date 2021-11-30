using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pessoa.DAO
{
    // Classe usada para Conexão com banco de dados usado para o Consulta
    public class Conn
    {
        private static string server = @".\SQLEXPRESS";
        private static string dataBase = "PIM";
        private static string user = "";
        private static string password = "";

        public static string StrCon
        {
            get { return $"Data Source= {server}; Integrated Security=true ; Initial Catalog= {dataBase}; User ID= {user}; Password= {password }"; }

        }

    }
}
