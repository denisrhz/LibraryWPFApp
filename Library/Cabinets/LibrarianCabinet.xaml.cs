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
using System.Windows.Shapes;

namespace Library.Cabinets
{
    /// <summary>
    /// Логика взаимодействия для LibrarianCabinet.xaml
    /// </summary>
    public partial class LibrarianCabinet : Window
    {
        int _userId;

        public LibrarianCabinet()
        {
            InitializeComponent();
        }

        public void SetData(int userId, string login)
        {
            _userId = userId;
            this.Title = $"Личный кабинет библиотекаря {login}";
        }
    }
}
