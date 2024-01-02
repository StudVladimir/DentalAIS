using System;
namespace DentalSV
{
	public class Reception
	{
        #region Computed Properties
        public int Reception_id { get; set; } = new int();
        public string DateTime { get; set; } = "";
        public int Cabinet_id { get; set; } = new int();
        public string Patient_id { get; set; } = "";
        public string Discription { get; set; } = "";
        #endregion

        #region Constructors
        public Reception()
        {
        }

        public Reception(int reception_id, string datetime, int cabinet_id, string patient_id, string discription)
        {
            this.Reception_id = reception_id;
            this.DateTime = datetime;
            this.Cabinet_id = cabinet_id;
            this.Patient_id = patient_id;
            this.Discription = discription;
        }
        #endregion
    }
}

