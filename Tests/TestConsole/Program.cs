using System.Net;
using System.Net.Mail;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new MailAddress("ya.aleksandrovich@retailrobotics.microsoft.com", "Отправляю сообщение с рабочей почты");
            var to = new MailAddress("opanforever1992@gmail.com", "Yarosav это ты");

            var message = new MailMessage(from, to);
            message.Subject = "Заголовок";
            message.Body = "Текст письма";


            var client = new SmtpClient("smtp.yandex.ru", 465);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential 
            {
                UserName = "UserName",
                //SecurePassword = 
                Password = "Password"
            };

            client.Send(message);
        }
    }
}
