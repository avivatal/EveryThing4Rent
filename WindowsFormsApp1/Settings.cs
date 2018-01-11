using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class Settings
    {
        public static RegisteredUser user = null;
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+System.IO.Directory.GetCurrentDirectory()+"/Everything4Rent.accdb");

    }
}
