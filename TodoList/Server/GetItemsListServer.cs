using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using TodoList.Model;

namespace TodoList.Server
{
    public class GetItemsListServer
    {
        public static string GetItem()
        {
            List<Items> datalist = new();
            string jsonstring;
            MySqlConnection conn = new();
            conn = LinkToDatabase.LinktoDB();
            try
            {
                string sql = "select * from items";
                MySqlCommand cmd = new(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Items item = new();
                    item.Id = reader["Id"].ToString();
                    item.Item = reader["Item"].ToString();
                    item.Tags = reader["Tags"].ToString();
                    item.SetTime = reader.GetDateTime("SetTime");
                    item.FinTime = reader.GetDateTime("FinTime");
                    item.UpdateTime = reader.GetDateTime("UpdateTime");
                    datalist.Add(item);
                }
                jsonstring = JsonConvert.SerializeObject(datalist);
                //jsonstring = jsonstring.Replace("\"", "");
                //jsonstring = jsonstring.Replace("[", "{");
                //jsonstring = jsonstring.Replace("]", "}");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return jsonstring;
        }
    }
}
