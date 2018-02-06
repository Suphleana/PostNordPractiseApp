using Foundation;
using System;
using UIKit;

namespace HotelApp.iOS
{
    public partial class HotelController : UIViewController
    {
        public string hotelName;

        public HotelController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

        }
    }
}