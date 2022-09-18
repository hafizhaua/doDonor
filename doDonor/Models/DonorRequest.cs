using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class DonorRequest
    {
        private int idDonorRequest;
        private int idRequester;
        private string? patientName;
        private string? bloodTypeNeeded;
        private int bagQuantity;
        private string? donorType;
        private string? region;
        private string? hospitalName;
        private string? cpName;
        private string? cpPhoneNumber;

        public DonorRequest(int idDonorRequest, int idRequester, string? patientName, string? bloodTypeNeeded, int bagQuantity, string? donorType, string? region, string? hospitalName, string? cpName, string? cpPhoneNumber)
        {
            this.IdDonorRequest = idDonorRequest;
            this.IdRequester = idRequester;
            this.PatientName = patientName;
            this.BloodTypeNeeded = bloodTypeNeeded;
            this.BagQuantity = bagQuantity;
            this.DonorType = donorType;
            this.Region = region;
            this.HospitalName = hospitalName;
            this.CpName = cpName;
            this.CpPhoneNumber = cpPhoneNumber;
        }

        public int IdDonorRequest { get => idDonorRequest; set => idDonorRequest = value; }
        public int IdRequester { get => idRequester; set => idRequester = value; }
        public string? PatientName { get => patientName; set => patientName = value; }
        public string? BloodTypeNeeded { get => bloodTypeNeeded; set => bloodTypeNeeded = value; }
        public int BagQuantity { get => bagQuantity; set => bagQuantity = value; }
        public string? DonorType { get => donorType; set => donorType = value; }
        public string? Region { get => region; set => region = value; }
        public string? HospitalName { get => hospitalName; set => hospitalName = value; }
        public string? CpName { get => cpName; set => cpName = value; }
        public string? CpPhoneNumber { get => cpPhoneNumber; set => cpPhoneNumber = value; }
    }
}
