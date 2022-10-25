using IntroInWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace IntroInWPF.Data
{
    static class TestData
    {
        public static List<Server> Servers { get; set; } = Enumerable.Range(1, 10)
            .Select(i => new Server
            {
                Name = $"Сервер-{i}",
                Address = $"smtp.server{i}.com",
                Login = $"Login-{i}",
                UseSSL = i % 2 ==0
            })
            .ToList();

        public static List<Sender> Senders { get; set; } = Enumerable.Range(1, 10)
            .Select(i => new Sender
            {
                Name = $"Отправител {i}",
                Address = $"sender_{i}@server.ru"
            })
            .ToList();
        public static List<Resepient> Resepients { get; set; } = Enumerable.Range(1, 10)
            .Select(i => new Resepient
            {
                Name = $"Получатель {i}",
                Address = $"resepient_{i}@server.ru"
            })
            .ToList();
        public static List<Messege> Messages { get; set; } = Enumerable.Range(1, 10)
            .Select(i => new Messege
            {
                Title = $"Сообщение {i}",
                Text = $"Текст сообщения {i}"
            })
            .ToList();
    }
}
