using System;
using System.Diagnostics;

using UIKit;

namespace HotelApp.iOS
{
    public partial class ViewController : UIViewController
    {
        //Array user
        private string[,] arrUsers = new string[3,2] { { "ellen", "ellen1" }, {"filippa", "filippa2"}, {"jonas", "jonas3"} };

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        partial void loginButton_TouchUpInside(UIButton sender)
        {
            if(ValidUsername()) {
                //System.Diagnostics.Debug.WriteLine("Success!");
                var hotelListVC = (HotelListController)this.Storyboard.InstantiateViewController("HotelListController");

                this.PresentViewController(hotelListVC, true, null);
            }
            else {
                //If not success login display error msg
                string errorMsg = "There was an error login in";
                var alertBox = UIAlertController.Create("Login error", errorMsg, UIAlertControllerStyle.Alert);
                alertBox.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null));
                PresentViewController(alertBox, true, null);
            }
        }
       //Check name
        private bool ValidUsername(){
            string inputName = usernameTextField.Text.Trim();
            inputName = inputName.ToLower();
            if(!String.IsNullOrEmpty(inputName)) {
                for (int i = 0; i < arrUsers.GetLength(0); i++) {
                    if(inputName == arrUsers[i, 0]) {
                        if(ValidPassword(i)) {
                            return true;
                        }
                        else {
                            return false;
                        }
                    }
                }
            }
            return false;
        }
        //Check password
        private bool ValidPassword(int place){
            if(!String.IsNullOrEmpty(passwordTextField.Text.Trim())){
                string inputPassword = passwordTextField.Text.Trim();
                if(arrUsers[place, 1] == inputPassword){
                    return true;
                }
            }
            return false;
        }
    }
}
