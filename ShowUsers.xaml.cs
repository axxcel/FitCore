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
    /// Логика взаимодействия для ShowUsers.xaml
    /// </summary>
    public partial class ShowUsers : Page
    {
        SqliteConnection con = new SqliteConnection("Data Source=bd.db");
        List<Clients> users = new();
        public ShowUsers()
        {
            InitializeComponent();
            con.Open();
            SqliteCommand command = new SqliteCommand("Select Clients.fio, Clients.contact, Clients.ticket, Coachs.fio FROM Clients JOIN Coachs ON Coachs.idCoach = Clients.idCoach", con);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    int i = 0;
                    while (reader.Read())   // построчно считываем данные
                    {
                        var fio = reader.GetString(0);
                        var contact = reader.GetString(1);
                        var ticket = reader.GetString(2);
                        var fioT = reader.GetString(3);
                        Clients client = new Clients(fio, contact, ticket, fioT);
                        users.Add(client);
                    }
                }
            }
            con.Close();
            TableForUsers.ItemsSource = users;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
