using Foundation;
using System;
using UIKit;

namespace HotelApp.iOS
{
    public partial class HotelListController : UIViewController
    {
        


        public HotelListController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            string[] data = new string[] { "Hotel 1", "Hotel 2", "Hotel 3" };

            UITableView _table;

            _table = new UITableView()
            {
                Frame = new CoreGraphics.CGRect(0, 30, View.Bounds.Width, View.Bounds.Height - 30),
                Source = new TableSource(data),
            };

            View.AddSubview(_table);

        }
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
       {
            base.PrepareForSegue(segue, sender);

            if(segue.Identifier == "segueHotel") {
                var navctlr = segue.DestinationViewController as HotelController;
                var source = UITableView as TableSource;
            }
        }
    }
}