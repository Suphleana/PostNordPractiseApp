// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ViewController : UIViewController {
	UIButton *_Button;
	UIButton *_buttonLogin;
	UITextField *_passwordTextField;
	UITextField *_usernameTextField;
}

@property (nonatomic, retain) IBOutlet UIButton *Button;

@property (nonatomic, retain) IBOutlet UIButton *buttonLogin;

@property (nonatomic, retain) IBOutlet UITextField *passwordTextField;

@property (nonatomic, retain) IBOutlet UITextField *usernameTextField;

- (IBAction)loginButton_TouchUpInside:(UIButton *)sender;

@end
