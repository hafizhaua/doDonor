using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal class DonorRequest
    {
        private string? idDonorRequest;
        private int idRequester;
        private string? patientName;
        private string? bloodType;
        private int bagQuantity;
        private string? donorType;
        private string? region;
        private string? hospitalName;
        private string? cpName;
        private string? cpPhoneNumber;

        public string IdDonorRequest { get => idDonorRequest; set => idDonorRequest = value; }
        public int IdRequester { get => idRequester; set => idRequester = value; }
        public string? PatientName { get => patientName; set => patientName = value; }
        public string? BloodType { get => bloodType; set => bloodType = value; }
        public int BagQuantity { get => bagQuantity; set => bagQuantity = value; }
        public string? DonorType { get => donorType; set => donorType = value; }
        public string? Region { get => region; set => region = value; }
        public string? HospitalName { get => hospitalName; set => hospitalName = value; }
        public string? CpName { get => cpName; set => cpName = value; }
        public string? CpPhoneNumber { get => cpPhoneNumber; set => cpPhoneNumber = value; }

        public DonorRequest(string? patientName, string? bloodType, int bagQuantity, string? donorType, string? region, string? hospitalName, string? cpName, string? cpPhoneNumber)
        {
            //this.IdDonorRequest = idDonorRequest;
            //this.IdRequester = idRequester;
            this.PatientName = patientName;
            this.BloodType = bloodType;
            this.BagQuantity = bagQuantity;
            this.DonorType = donorType;
            this.Region = region;
            this.HospitalName = hospitalName;
            this.CpName = cpName;
            this.CpPhoneNumber = cpPhoneNumber;

            validateValue();
        }

        public DonorRequest(string? idDonorRequest, string? patientName, string? bloodType, int bagQuantity, string? donorType, string? region, string? hospitalName, string? cpName, string? cpPhoneNumber)
        {
            this.IdDonorRequest = idDonorRequest;
            this.PatientName = patientName;
            this.BloodType = bloodType;
            this.BagQuantity = bagQuantity;
            this.DonorType = donorType;
            this.Region = region;
            this.HospitalName = hospitalName;
            this.CpName = cpName;
            this.CpPhoneNumber = cpPhoneNumber;

            validateValue();
        }

        private void validateValue()
        {
            PatientName = Utils.NullIfEmpty(PatientName);
            BloodType = Utils.NullIfEmpty(BloodType);
            BagQuantity = Utils.PositiveOnly(BagQuantity);
            DonorType = Utils.NullIfEmpty(DonorType);
            Region = Utils.NullIfEmpty(Region);
            HospitalName = Utils.NullIfEmpty(HospitalName);
            cpName = Utils.NullIfEmpty(cpName);
            cpPhoneNumber = Utils.NullIfEmpty(cpPhoneNumber);
        }
    }
}
