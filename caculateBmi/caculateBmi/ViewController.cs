using System;

using UIKit;

namespace caculateBmi
{
	public partial class ViewController : UIViewController
	{
		public bool invalid = false;
		

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			this.NavigationController.NavigationBar.Hidden = true;

			resetButton.TouchUpInside += (sender, e) =>
			{
				Reset();
			};

			heightNum.ShouldBeginEditing += (textField) =>
			{
				heightNum.TextColor = UIColor.Black;
				invalid = false;
				return true;
			};
			weightNum.ShouldBeginEditing += (textField) =>
			{
				weightNum.TextColor = UIColor.Black;
				invalid = false;
				return true;
			};
			ageNum.ShouldBeginEditing += (textField) =>
			{
				ageNum.TextColor = UIColor.Black;
				invalid = false;
				return true;
			};



			caculateButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				
				int flag = 3;
				Double hieghtValue;
				Double weightValue;

				BmiViewController bmiController = this.Storyboard.InstantiateViewController("bmiView") as BmiViewController;
				//this.NavigationController.PushViewController(bmiController, true);
				if (invalid == false)
				{
					if (Double.TryParse(heightNum.Text, out hieghtValue))
					{
						bmiController.heightNum = hieghtValue;
					}
					else
					{
						heightNum.Text = heightNum.Text + " is Invalid Height";
						flag--;
						invalid = true;
					}

					if (Double.TryParse(weightNum.Text, out weightValue))
					{
						Console.WriteLine(weightValue);
						bmiController.weightNum = weightValue;
						//this.NavigationController.PushViewController(bmiController, true);
					}
					else
					{
						weightNum.Text = weightNum.Text + " is Invalid Weight";
						flag--;
						invalid = true;
					}

					int age = 0;
					if (int.TryParse(ageNum.Text, out age))
					{
						if (age > 120 || age < 1)
						{
							ageNum.Text = ageNum.Text + " is Invalid Age";
							flag--;
							invalid = true;
						}
					}
					else
					{
						ageNum.Text = ageNum.Text + " is Invalid Age";
						flag--;
						invalid = true;
					}
				}
					
					

				if (flag == 3 && !invalid)
					this.NavigationController.PushViewController(bmiController, true);

			};

		}

		public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesBegan(touches, evt);
			UITouch touch = touches.AnyObject as UITouch;
			if (touch != null)
			{
				
				if (heightNum.Text == "")
					heightNum.Text = "height";
				
				heightNum.ResignFirstResponder();
					
				if (weightNum.Text == "")
					weightNum.Text = "weight";
				
				weightNum.ResignFirstResponder();

				if (ageNum.Text == "")
					ageNum.Text = "age";
				
				ageNum.ResignFirstResponder();
						
			}
		}

		public void Reset()
		{
			heightNum.Text = "height";
			heightNum.TextColor = UIColor.LightGray;
			weightNum.Text = "weight";
			weightNum.TextColor = UIColor.LightGray;
			ageNum.Text = "age";
			ageNum.TextColor = UIColor.LightGray;
		}


	}
}

