using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class Admin : User
    {
        private string? name;
        private string? region;
        private string? address;
        private string? phoneNumber;
        private List<string>? scheduleList;
        private List<string>? bloodStockList;

        public Admin(string? username, string? password) : base(username, password)
        {
            //UserID = id;
            Username = username;
            Password = password;
            //Name = name;
            //Region = region;
            //Address = address;
            //PhoneNumber = phoneNumber;
            //ScheduleList = scheduleList;
            //BloodStockList = bloodStockList;
        }

        public string? Name { get => name; set => name = value; }
        public string? Region { get => region; set => region = value; }
        public string? Address { get => address; set => address = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public List<string>? ScheduleList { get => scheduleList; set => scheduleList = value; }
        public List<string>? BloodStockList { get => bloodStockList; set => bloodStockList = value; }

        public void setProfile() { }

        public void addSchedule() { }

        public void setBloodStock() { }

        public override bool login()
        {
            DbUser dbAuth = new DbUser();
            return dbAuth.AdminLogin(Username, Password);
        }
    }
}
