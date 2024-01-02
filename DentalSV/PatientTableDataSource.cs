using System;
using AppKit;
using System.Collections.Generic;
using Foundation;

namespace DentalSV
{
	public class PatientTableDataSource:NSTableViewDataSource
	{
        #region Public Variables
        public List<Patient> PatientS = new List<Patient>();
        #endregion

        #region Constructors
        public PatientTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return PatientS.Count;
        }
        #endregion


        public void Sort(string key, bool ascending)
        {
            // Take action based on key
            switch (key)
            {
                case "Id":
                    if (ascending)
                    {
                        PatientS.Sort((x, y) => x.Id.CompareTo(y.Id));
                    }
                    else
                    {
                        PatientS.Sort((x, y) => -1 * x.Id.CompareTo(y.Id));
                    }
                    break;

                case "FIO":
                    if (ascending)
                    {
                        PatientS.Sort((x, y) => x.FIO.CompareTo(y.FIO));
                    }
                    else
                    {
                        PatientS.Sort((x, y) => -1 * x.FIO.CompareTo(y.FIO));
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

