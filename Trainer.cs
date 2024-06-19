using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string Time { get; set; }

        public Trainer(string fullName, string time)
        {
            FullName = fullName;
            Time = time;
        }

        public Trainer(int id, string fullName, string specialization, string time)
        {
            Id = id;
            FullName = fullName;
            Specialization = specialization;
            Time = time;
        }
    }
}
