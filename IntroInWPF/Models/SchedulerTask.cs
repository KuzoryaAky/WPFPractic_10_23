using System;
using System.Collections.Generic;

namespace IntroInWPF.Models
{
    public class SchedulerTask
    {
        public DateTime Time { get; set; }
        public Server Server { get; set; }
        public Sender Sender { get; set; }
        public List<Resepient> Resepients { get; set; }
        public Messege Messege { get; set; }
        //public List<Messege> Messeges { get; set; } = new()
    }
}
