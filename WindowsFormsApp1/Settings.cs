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
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName+ "/Everything4Rent.accdb");
     //   public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:/Users/noybensh/Source/EveryThing4Rent/EveryThing4Rent/WindowsFormsApp1" + "/Everything4Rent.accdb");
    }
}
