using System;
namespace DentalSV
{
	public class Visit
	{
        #region Computed Properties
        public string VisitDateTime { get; set; } = "";
        public string Discription { get; set; } = "";
        #endregion

        public Visit()
		{
		}

        public Visit(string visitdatetime, string discription)
        {
            this.VisitDateTime = visitdatetime;
            this.Discription = discription;
        }
    }
}

