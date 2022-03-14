using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace study_WPF
{
    class MySQL
    {
        public MySQL(string serverName, string dataBase, string userId, string userPw)
        {

            MySqlConnection connection = new MySqlConnection("Server=" + serverName + ";Database=" + dataBase + ";Uid=" + userId + ";Pwd=" + userPw);

            // DB Open
            connection.Open();

            //DB 연결여부 확인
            Boolean pingFlag = connection.Ping();

            //연결이 성공하였을 경우 
            if(pingFlag == true)
            {
                MessageBox.Show("DB 연결 성공");
            }
            else
            {
                MessageBox.Show("DB 연결 실패");
            }

            connection.Close();
        }
    }
}
