using System;
namespace DentalSV
{
	public class Protezes
	{
        #region Computed Properties

        public int Protez_ID { get; set; } = 0;
        public string Materials { get; set; } = "";
        public string Size { get; set; } = "";
        public string DentalSet { get; set; } = "";
        public string Clammers { get; set; } = "";
        public int Saddles { get; set; } = 0;
        public int ClammersQuantity { get; set; } = 0;
        #endregion


        public Protezes(int log_id, string materials, string size, string dentalset, string clammers, int saddles, int clammersquantity)
        {
            this.Protez_ID = log_id;
            this.Materials = materials;
            this.Size = size;
            this.DentalSet = dentalset;
            this.Clammers = clammers;
            this.Saddles = saddles;
            this.ClammersQuantity = clammersquantity;
        }
        public Protezes()
		{
		}
	}
}

