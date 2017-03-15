using System;

using UIKit;

namespace testing
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			UILabel _helloLabel;

			_helloLabel = new UILabel
			{
				Frame = new CoreGraphics.CGRect(50, 50, 120, 40),
				Text = "TEST", TextColor = UIColor.Magenta
			};

			View.AddSubview(_helloLabel);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
