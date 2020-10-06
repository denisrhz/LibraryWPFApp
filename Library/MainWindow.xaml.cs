using Library.Cabinets;
using Library.Models;
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

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LibContext libcon = new LibContext();
            List<User> users = libcon.GetUsers();
            foreach(var user in users)
            {
                if(Login__Box.Text==user.Login && Password__Box.Password == user.Password)
                {
                    if (user.isBlocked)
                    {
                        MessageBox.Show("Ты пидр");
                        return;
                    }
                    else if (user.Role == "Admin")
                    {
                        AdminCabinet adminCabinet = new AdminCabinet();
                        adminCabinet.SetData(user.UserId, user.Login);
                        adminCabinet.Show();
                    }
                    else if (user.Role == "Reader")
                    {

                        ReaderCabinet readerCabinet = new ReaderCabinet();
                        readerCabinet.SetData(user.UserId, user.Login);
                        readerCabinet.Show();
                    }
                    else if (user.Role == "Librarian")
                    {
                        LibrarianCabinet librarianCabinet = new LibrarianCabinet();
                        librarianCabinet.SetData(user.UserId,user.Login);
                        librarianCabinet.Show();
                    }
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Ты кто?");
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Close();
            registration.Show();
            
        }
    }
}
