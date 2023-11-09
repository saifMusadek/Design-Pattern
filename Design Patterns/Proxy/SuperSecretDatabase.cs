using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    internal class SuperSecretDatabase : ISuperSecretDatabase
    {
        private string _database; 
        public SuperSecretDatabase(string database)
        {
            _database = database;
        }
        public void DisplaydatabaseName() {
            Console.WriteLine("display database name: "+_database);

        }
    }
}
