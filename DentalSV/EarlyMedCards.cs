using System;
namespace DentalSV
{
	public class EarlyMedCards
	{
        #region Computed Properties
        public string DateTime { get; set; } = "";
        public int medCard_id { get; set; }=0;
        #endregion


        public EarlyMedCards (string datetime, int medcard_id)
        {
            this.DateTime = datetime;
            this.medCard_id = medcard_id;
        }
        public EarlyMedCards()
		{
		}
	}
}

