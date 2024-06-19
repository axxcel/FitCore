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
using Microsoft.Data.Sqlite;


namespace GymProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqliteConnection con = new SqliteConnection("Data Source=bd.db");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn(object sender, RoutedEventArgs e)
        {
            bool have = false;
            con.Open();
            SqliteCommand command = new SqliteCommand("SELECT * FROM Users", con);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var id = reader.GetInt32(0);
                        var login = reader.GetString(1);
                        var password = reader.GetString(2);
                        var post = reader.GetString(3);

                        if (loginT.Text == login && passwordT.Text == password)
                        {
                            have = true;
                            if (post == "admin")
                            {
                                Admin admin = new Admin(post);
                                Main.Content = admin;
                            }
                            else if (post == "trainer")
                            {

                            }
                            else if (post == "manager")
                            {
                            }
                            break;
                        }
                    }
                    if (have == false)
                    {
                        MessageBox.Show("Вы ввели неправильный пароль или логин. Повторите попытку");
                    }
                }
            }
            con.Close();
        }
    }
}
