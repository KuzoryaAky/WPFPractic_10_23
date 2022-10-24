using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("opanforever1992@gmail.com", "Yaroslav");
            // кому отправляем
            MailAddress to = new MailAddress("dcaxarokb@yandex.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            
            
            // логин и пароль
            smtp.Credentials = new NetworkCredential 
            {
                UserName = LoginEdit.Text,
                //Password = PasswordEdit.Text
                SecurePassword = PasswordEdit.SecurePassword
            };
            smtp.EnableSsl = true;


            try
            {
                smtp.Send(m);

                MessageBox.Show("Сообщение успешно отправленно!", "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch (SmtpException)
            {
                MessageBox.Show("Ошибка авторизации", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (TimeoutException)
            {
                MessageBox.Show("Ошибка адреса сервера", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
