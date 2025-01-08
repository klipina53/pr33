using pr33_ChatStudents_Lipina.Classes.Common;
using pr33_ChatStudents_Lipina.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr33_ChatStudents_Lipina.Pages.Items
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        Users user;
        Main main;

        public User(Users user, Main main)
        {
            InitializeComponent();
            this.user = user;
            this.main = main;
            imgUser.Source = BitmapFromArrayByte.LoadImage(user.Photo);
            FIO.Content = user.ToFIO();
        }

        private void SelectChat(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            main.SelectUser(user);
        }
    }
}
