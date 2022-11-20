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
        private string? region;
        private DateTime dateEvent;
        private string? location;
        private string? address;

        public Schedule(int idSchedule, string? region, DateTime dateEvent, string? location, string? address)
        {
            IdSchedule = idSchedule;
            Region = region;
            DateEvent = dateEvent;
            Location = location;
            Address = address;
        }

        public int IdSchedule { get => idSchedule; set => idSchedule = value; }
        public string? Region { get => region; set => region = value; }
        public DateTime DateEvent { get => dateEvent; set => dateEvent = value; }
        public string? Location { get => location; set => location = value; }
        public string? Address { get => address; set => address = value; }
    }
}
