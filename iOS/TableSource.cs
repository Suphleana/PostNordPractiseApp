using System;
using UIKit;
using 

namespace HotelApp.iOS
{
    public class TableSource : UITableViewSource
    {
        string[] tableItems;
        string cellIdentifier = "TableCell";

        public TableSource(string[] items)
        {
            tableItems = items;
        }

        //returns nint - var int förut men visual studio gör saker
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }
        //everytime clicked
        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            //base.RowSelected(tableView, indexPath);
            //send to new screen with info

        }

        //gör cell:
        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            // använder bara reusable för dem som inte finns i view
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if(cell == null) {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }
            cell.TextLabel.Text = tableItems[indexPath.Row];
            return cell;
        }
    }
}
