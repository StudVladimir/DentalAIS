using System;
using Foundation;

namespace DentalSV
{
	public class Patient
	{
        #region Computed Properties
        public int Id { get; set; } = new int();
        public string FIO { get; set; } = "";
        public string BirthDate { get; set; } =  "";
        public string Phone { get; set; } = "";
        public string WorkingPlace { get; set; } = "";
        public string Pensioner { get; set; } = "";
        #endregion

        #region Constructors
        public Patient()
        {
        }

        public Patient(int id, string fio, string birthdate, string phone, string workingplace, string pensioner)
        {
            this.Id = id;
            this.FIO = fio;
            this.BirthDate = birthdate;
            this.Phone = phone;
            this.WorkingPlace = workingplace;
            this.Pensioner = pensioner;
        }
        #endregion
    }
}

