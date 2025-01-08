using pr33_ChatStudents_Lipina.Classes.Common;
using pr33_ChatStudents_Lipina.Models;
using System.Windows.Controls;

namespace pr33_ChatStudents_Lipina.Pages.Items
{
    /// <summary>
    /// Логика взаимодействия для Message.xaml
    /// </summary>
    public partial class Message : UserControl
    {
        public Message(Messages Messages, Users UserFrom)
        {
            InitializeComponent();
            imgUser.Source = BitmapFromArrayByte.LoadImage(UserFrom.Photo);
            FIO.Content = UserFrom.ToFIO();
            tbMessage.Text = Messages.Message;
        }
    }
}
