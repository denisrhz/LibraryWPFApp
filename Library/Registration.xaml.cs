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

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, KeyboardFocusChangedEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void TextBox_Leave(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                switch (((TextBox)sender).Name)
                {
                    case "TextBox_FIO":
                        ((TextBox)sender).Text = "ФИО";
                        break;
                    case "TextBox_Pas":
                        ((TextBox)sender).Text = "Пароль";
                        break;
                    case "TextBox_Log":
                        ((TextBox)sender).Text = "Логин";
                        break;
                    case "TextBox_Br":
                        ((TextBox)sender).Text = "Год_рождения";
                        break;
                    case "TextBox_Tel":
                        ((TextBox)sender).Text = "Телефон";
                        break;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            TextBox_FIO
        }
    }
}
