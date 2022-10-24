using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            Rotator.Angle += 5;

            var from = new MailAddress("opanforever1992@gmail.com", "FoxTV");
            var to = new MailAddress("dcaxarokb@yandex.ru");

            var message = new MailMessage(from, to);
            message.Subject = "Заголовок";
            message.Body = "Текст письма";
            message.IsBodyHtml = true;
            

            var client = new SmtpClient("smtp.gmail.com", 465);

            client.Credentials = new NetworkCredential
            {
                UserName = LoginEdit.Text,
                SecurePassword = PasswordEdit.SecurePassword
                //Password = PasswordEdit.Password
            };
            client.EnableSsl = true;

            try
            {
                client.Send(message);

                MessageBox.Show("Почта успешно отправлена", "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SmtpException)
            {
                MessageBox.Show("Ошибка авторизации", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Ошибка адресса сервера", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
