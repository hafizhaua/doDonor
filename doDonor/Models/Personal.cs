﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class Personal : User
    {
        private string? name;
        private string? bloodType;
        private string? rhesus;
        private string? region;
        private string? phoneNumber;
        private List<string>? donorRequest;
        private List<string>? donoringList;

        public Personal(int id, string? username, string? password, string? name, string? bloodType, string? rhesus, string? region, string? phoneNumber, List<string>? donorRequest, List<string>? donoringList) : base(id, username, password)
        {
            UserID = id;
            Username = username;
            Password = password;
            Name = name;
            BloodType = bloodType;
            Rhesus = rhesus;
            Region = region;
            PhoneNumber = phoneNumber;
            DonorRequest = donorRequest;
            DonoringList = donoringList;
        }

        public string? Name { get => name; set => name = value; }
        public string? BloodType { get => bloodType; set => bloodType = value; }
        public string? Rhesus { get => rhesus; set => rhesus = value; }
        public string? Region { get => region; set => region = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public List<string>? DonorRequest { get => donorRequest; set => donorRequest = value; }
        public List<string>? DonoringList { get => donoringList; set => donoringList = value; }
    }
}