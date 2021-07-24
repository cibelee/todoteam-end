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
        const string server = "rm-wz9075ii95db86f9oro.mysql.rds.aliyuncs.com";
        const string database = "todolist";
        const string user_id = "iewehzil";
        const string password = "uV9!aOCHjR!3";

        public static MySqlConnection LinktoDB()
        {
            string connstr = "server=" + server + ";database=" + database + ";user id=" + user_id + ";password=" + password + ";pooling=false;charset=utf8";
            MySqlConnection conn = new(connstr);
            return conn;
        }
    }
}