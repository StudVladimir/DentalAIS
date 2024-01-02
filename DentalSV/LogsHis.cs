using System;
namespace DentalSV
{
	public class LogsHis
	{
        #region Computed Properties

        public int Log_ID { get; set; } = 0;
        public string FIO { get; set; } = "";
        public string DateTime { get; set; } = "";
        #endregion


        public LogsHis(int log_id, string fio, string datetime)
        {
            this.Log_ID = log_id;
            this.FIO = fio;
            this.DateTime = datetime;
        }
        public LogsHis()
		{
		}
	}
}

