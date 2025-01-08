using Microsoft.Win32;
using pr33_ChatStudents_Lipina.Classes;
using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Text.RegularExpressions;
using pr33_ChatStudents_Lipina.Models;
using System.Linq;
using System.IO;

namespace pr33_ChatStudents_Lipina.Pages
{
    public partial class Login : Page
    {
        public string srcUserImage = "";
        UsersContext usersContext = new UsersContext();

        public Login()
        {
            InitializeComponent();
        }
        private void SelectPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите фотографию:";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                imgUser.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                srcUserImage = openFileDialog.FileName;
            }
        }
        public bool CheckEmpty(string Pattern, string Input)
        {
            Match m = Regex.Match(Input, Pattern);
            return m.Success;
        }
        private void Continue(object sender, RoutedEventArgs e)
        {
            if (!CheckEmpty("^[А-ЯЁ][а-яА-ЯёЁ]*$", Lastname.Text))
            {
                MessageBox.Show("Укажите фамилию.");
                return;
            }
            if (!CheckEmpty("^[А-ЯЁ][а-яА-ЯёЁ]*$", Firstname.Text))
            {
                MessageBox.Show("Укажите имя.");
                return;
            }
            if (!CheckEmpty("^[А-ЯЁ][а-яА-ЯёЁ]*$", Surname.Text))
            {
                MessageBox.Show("Укажите отчество.");
                return;
            }
            if (String.IsNullOrEmpty(srcUserImage))
            {
                MessageBox.Show("Выберите изображение.");
                return;
            }
            if (usersContext.Users.Where(x => x.Firstname == Firstname.Text &&
                                            x.Lastname == Lastname.Text &&
                                            x.Surname == Surname.Text).Count() > 0)
            {
                MainWindow.Instance.LoginUser = usersContext.Users.Where(x => x.Firstname == Firstname.Text &&
                                                                            x.Lastname == Lastname.Text &&
                                                                            x.Surname == Surname.Text).First();
                MainWindow.Instance.LoginUser.Photo = File.ReadAllBytes(srcUserImage);
                usersContext.SaveChanges();
            }
            else
            {
                usersContext.Users.Add(new Users(Lastname.Text, Firstname.Text, Surname.Text, File.ReadAllBytes(srcUserImage)));
                usersContext.SaveChanges();
                MainWindow.Instance.LoginUser = usersContext.Users.Where(x => x.Firstname == Firstname.Text &&
           x.Surname == Surname.Text).First();
            }
            MainWindow.Instance.OpenPages(new Pages.Main());
        }
    }
}
