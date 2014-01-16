using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Hello_World
{
	[Activity (Label = "Hello_World", MainLauncher = true)]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}

//		protected override void OnCreate (Bundle bundle)
//		{
//			base.OnCreate (bundle);
//			
//			//Create the user interface in code
//			var layout = new LinearLayout (this);
//			layout.Orientation = Orientation.Vertical;
//			
//			var aLabel = new TextView (this);
//			aLabel.Text = "Hello, Xamarin.Android";
//			
//			var aButton = new Button (this);      
//			aButton.Text = "Say Hello";
//			aButton.Click += (sender, e) => {
//				aLabel.Text = "Hello from the button";
//			};  
//			layout.AddView (aLabel);
//			layout.AddView (aButton);           
//			SetContentView (layout);
//		}
	}
}


