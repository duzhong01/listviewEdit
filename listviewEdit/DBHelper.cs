using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace listviewEdit
{
    public class DBHelper
    {
        public static OleDbConnection getCon()
        {
            string strcon ="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\visual studio 2010\\listviewEdit\\listviewDB.mdb";
            return new OleDbConnection(strcon);
        }
    }

    public class Person
    {
        public string username { get; set; }
        public string pwd { get; set; }
        public int age { get; set; }
        public DateTime createdate { get; set; }
        public DateTime updatedate { get; set; }
        public string classroom { get; set; }
        public int id { get; set; }
    }
}
