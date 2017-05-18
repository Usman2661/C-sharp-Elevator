using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Insert
    {
        OleDbConnection connection; 
        OleDbCommand command;



        private void connectTo()
        {
            connection = new OleDbConnection();
            command = connection.CreateCommand();

        }
    }

}
