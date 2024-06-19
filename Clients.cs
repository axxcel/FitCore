using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject
{
    class Clients
    {
        public int Id { get; set; } 
        public string Fio { get; set; } 
        public string Contact { get; set; } 
        public string Ticket { get; set; } 
        public string Trainer { get; set; } 

        public Clients(string fio, string contact, string ticket, string trainer)
        {
            Fio = fio;
            Contact = contact;
            Ticket = ticket;
            Trainer = trainer;
        }
    }
}
