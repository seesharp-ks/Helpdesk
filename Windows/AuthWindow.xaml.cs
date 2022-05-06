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
using helpdesk.Baza;
using System.Security.Cryptography;

namespace helpdesk.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window {
        Entities Entities = new Entities();
        public static Account acc;
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void btnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            acc = Entities.Account.FirstOrDefault(i => i.Login == tbLogin.Text && i.Password == pbPass.Password);
            if (acc != null)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                Hide();
            }
            else
            {
                if (tbLogin.Text.Length == 0 && pbPass.Password.Length != 0)
                    MessageBox.Show("Вы не ввели пароль.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (tbLogin.Text.Length == 0 && pbPass.Password.Length == 0)
                    MessageBox.Show("Вы не заполнили данные для авторизации.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (tbLogin.Text.Length != 0 && pbPass.Password.Length != 0)
                    MessageBox.Show("В доступе отказано. Проверьте правильность введенных данных.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (tbLogin.Text.Length == 0 && pbPass.Password.Length != 0)
                    MessageBox.Show("Вы не ввели логин.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string enhash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower(); //сравнить хэши со значением в БД и готово
        }
    }
}
