using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace DentalSV
{
	public class VisitTableDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<Visit> VisitS = new List<Visit>();
        #endregion

        public VisitTableDataSource()
		{
		}

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return VisitS.Count;
        }
        #endregion

        public void Sort(string key, bool ascending)
        {
            // Take action based on key
            switch (key)
            {
                case "VisitDateTime":
                    if (ascending)
                    {
                        VisitS.Sort((x, y) => x.VisitDateTime.CompareTo(y.VisitDateTime));
                    }
                    else
                    {
                        VisitS.Sort((x, y) => -1 * x.VisitDateTime.CompareTo(y.VisitDateTime));
                    }
                    break;

                case "Discription":
                    if (ascending)
                    {
                        VisitS.Sort((x, y) => x.Discription.CompareTo(y.Discription));
                    }
                    else
                    {
                        VisitS.Sort((x, y) => -1 * x.Discription.CompareTo(y.Discription));
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

