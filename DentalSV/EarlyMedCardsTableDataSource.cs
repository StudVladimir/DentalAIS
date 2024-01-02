using System;
using System.Collections.Generic;
using System.ComponentModel;
using AppKit;
using Foundation;

namespace DentalSV
{
	public class EarlyMedCardsTableDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<EarlyMedCards> EarlyMedCardsS = new List<EarlyMedCards>();
        #endregion
        public EarlyMedCardsTableDataSource()
		{
		}
        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return EarlyMedCardsS.Count;
        }
        #endregion
        public void Sort(string key, bool ascending)
        {
            // Take action based on key
            switch (key)
            {
                case "DateTime":
                    if (ascending)
                    {
                        EarlyMedCardsS.Sort((x, y) => x.DateTime.CompareTo(y.DateTime));
                    }
                    else
                    {
                        EarlyMedCardsS.Sort((x, y) => -1 * x.DateTime.CompareTo(y.DateTime));
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

