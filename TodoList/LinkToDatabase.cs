using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using TodoList.Model;

namespace TodoList
{
    public class LinkToDatabase
    {
        const string server = "1";
        const string database = "todolist";
        const string user_id = "2;
        const string password = "3";

        public static MySqlConnection LinktoDB()
        {
            string connstr = "server=" + server + ";database=" + database + ";user id=" + user_id + ";password=" + password + ";pooling=false;charset=utf8";
            MySqlConnection conn = new(connstr);
            return conn;
        }
    }
}
