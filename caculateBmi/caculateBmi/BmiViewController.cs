using System;

using UIKit;

namespace caculateBmi
{
	public partial class BmiViewController : UIViewController
	{


		protected BmiViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public Double heightNum;
		public Double weightNum;
		public int ageNum;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Caculate();

			backButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				//ViewController homwview = this.Storyboard.InstantiateViewController("homeView") as ViewController;
				//this.NavigationController.PushViewController(homwview, true);

				NavigationController.PopToRootViewController(true);
			};
		}
		public void Caculate()
		{
			Double bmi = weightNum / ((heightNum / 100) * (heightNum / 100));
			bmiResult.Text = bmi.ToString("#0.0");

			if (bmi < 18.5)
				textLable.Text = "Your weight is Underweight";
			if (18.5 <= bmi && bmi<= 24.9)
				textLable.Text = "Your weight is Healthy Weight";
			if (25 <= bmi && bmi <= 29.9)
				textLable.Text = "Your weight is Overweight";
			if (30 <= bmi && bmi <= 34.9)
				textLable.Text = "Your weight is Obese";
			if (35 <= bmi && bmi <= 39.9)
				textLable.Text = "Your weight is Severely Obese";
			if (bmi >= 40)
				textLable.Text = "Your weight is Morbidly Obese";
		}

	}
}


