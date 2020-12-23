﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace FaceCheckIn_App
{
    class MysqlUtil
    {
        static string connetStr = "server=127.0.0.1;port=3306;user=root;password=panpande1;database=face_check;";
        static MySqlConnection conn = new MySqlConnection(connetStr);
        
        /// <summary>
        /// 插入用户签到信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        public static void addInfor(string name, string date)
        {
            //SQL语句实现表数据的插入
            String sql = "INSERT INTO check_time (name, time) VALUES (@name,@time)";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@time", date);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// 获取用户签到信息
        /// </summary>
        public static List<List<string>> listInfor()
        {
            //SQL语句实现表数据的插入
            String sql = "SELECT * FROM check_time";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<List<string>> list = new List<List<string>>();
            int i = 0;
            while (reader.Read())
            {
                List<string> field = new List<string>();
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
                Console.WriteLine(reader[2]);
                field.Add(reader[1].ToString());
                field.Add(reader[2].ToString());
                list.Add(field);
            }
            conn.Close();
            return list;
        }
    }
}
