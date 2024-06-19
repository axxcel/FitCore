using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для MainAdminFrame.xaml
    /// </summary>
    public partial class MainAdminFrame : Page
    {
        SqliteConnection con = new SqliteConnection("Data Source=bd.db");
        List<Trainer> users = new();
        public MainAdminFrame()
        {
            InitializeComponent();

            con.Open();
            SqliteCommand command = new SqliteCommand("Select c.fio, c.timetable FROM Coachs AS c", con);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    int i = 0;
                    while (reader.Read())   // построчно считываем данные
                    {
                        var fio = reader.GetString(0);
                        var time = reader.GetString(1);
                        Trainer trainer = new Trainer(fio, time);
                        users.Add(trainer);
                    }                
                }
            }
            con.Close();
            TableForUsers.ItemsSource = users;
        }
    }
}
