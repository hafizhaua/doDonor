using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class Schedule
    {
        private int idSchedule;
        private int idPMI;
        private DateTime dateTime;
        private string? location;
        private string? address;

        public Schedule(int idSchedule, int idPMI, DateTime dateTime, string? location, string? address)
        {
            IdSchedule = idSchedule;
            IdPMI = idPMI;
            DateTime = dateTime;
            Location = location;
            Address = address;
        }

        public int IdSchedule { get => idSchedule; set => idSchedule = value; }
        public int IdPMI { get => idPMI; set => idPMI = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string? Location { get => location; set => location = value; }
        public string? Address { get => address; set => address = value; }
    }
}
