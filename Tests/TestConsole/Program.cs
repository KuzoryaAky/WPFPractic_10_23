using System;
using System.Net.Mail;
using System.Net;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
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
            smtp.Credentials = new NetworkCredential("opanforever1992@gmail.com","");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }
    }
}
