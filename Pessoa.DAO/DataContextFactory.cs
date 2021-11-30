using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pessoa.DAO
{
    public class DataContextFactory
    {
        //Metódo responsável por efetuar a conexão com o banco de dados
        private static DAODataContext dataContext;
        public static DAODataContext DataContext
        {
            get
            {
                if (dataContext == null)
                {
                    dataContext = new DAODataContext();
                }
                return dataContext;
            }
        }

    }
}
