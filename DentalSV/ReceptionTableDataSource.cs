using System;
using AppKit;
using System.Collections.Generic;
using Foundation;

namespace DentalSV
{
	public class ReceptionTableDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<Reception> ReceptionS = new List<Reception>();
        #endregion

        #region Constructors
        public ReceptionTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return ReceptionS.Count;
        }
        #endregion

        public void Sort(string key, bool ascending)
        {
            // Take action based on key
            switch (key)
            {
                case "Datetime":
                    if (ascending)
                    {
                        ReceptionS.Sort((x, y) => x.DateTime.CompareTo(y.DateTime));
                    }
                    else
                    {
                        ReceptionS.Sort((x, y) => -1 * x.DateTime.CompareTo(y.DateTime));
                    }
                    break;

                case "Patient":
                    if (ascending)
                    {
                        ReceptionS.Sort((x, y) => x.Patient_id.CompareTo(y.Patient_id));
                    }
                    else
                    {
                        ReceptionS.Sort((x, y) => -1 * x.Patient_id.CompareTo(y.Patient_id));
                    }
                    break;
            }
        }

        public override void SortDescriptorsChanged(NSTableView tableView, NSSortDescriptor[] oldDescriptors)
        {
            // Sort the data
            if (oldDescriptors.Length > 0)
            {
                // Update sort
                Sort(oldDescriptors[0].Key, oldDescriptors[0].Ascending);
            }
            else
            {
                // Grab current descriptors and update sort
                NSSortDescriptor[] tbSort = tableView.SortDescriptors;
                Sort(tbSort[0].Key, tbSort[0].Ascending);
            }

            // Refresh table
            tableView.ReloadData();
        }
    }
}

