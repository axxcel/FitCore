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

namespace GymProject
{
    /// <summary>
    /// Логика взаимодействия для ShowFrame.xaml
    /// </summary>
    public partial class ShowFrame : Page
    {
        public ShowFrame(string Text)
        {
            InitializeComponent();

            TextReg.Text = Text;
        }

        private void TableForUsers_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            SaveEdit.Visibility = Visibility.Visible;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
