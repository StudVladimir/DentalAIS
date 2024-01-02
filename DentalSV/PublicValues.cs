using System;
namespace DentalSV
{
    public static class PublicValues
    {
        public static string DentalFormulaValue;

        public static int ChoosenPatientID;

        public static bool DentalFormulaNeedChanged;

        public static int ChoosenEarlyMedCard_id;

        public static IntPtr handle;

        public static bool DFormulaOldCardOpened;

        public static bool ChoosePatForPhoto = false;

        public static bool ChoosePatForProtez = false;
    }

    public static class ValuesForCreateReception
    {
        public static Patient ChoosenPatientEntire;

        public static DateTime ChoosenDate;

        public static DateTime ChoosenTime;

        public static string ChoosenCab;

        public static string Description;
    }

    public static class ValuesForCreateProtez
    {

    }
}