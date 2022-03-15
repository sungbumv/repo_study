using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace study_WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        MySQL mysql = new MySQL("localhost", "newlocal", "root", "0713");

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string insertQuery = "INSERT INTO MEMBERTB(email,password) VALUES('" + EmailTextBox.Text + "'," + PasswordTextBox.Text + ")";

            MySqlConnection connection = mysql.MySQLFunc("localhost", "newlocal", "root", "0713");

            MySqlCommand command = new MySqlCommand(insertQuery, connection);


            try
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Insert Success");
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }
    }
}
