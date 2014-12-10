using System;

using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.App;

namespace XamarinDialogFragmentTest
{
	[Activity (Label = "XamarinDialogFragmentTest", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : FragmentActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				var fragment = new MyDialogFragment ();
				fragment.Show (SupportFragmentManager, "MyDialogFragment");
			};
		}
	}

	public class MyDialogFragment : Android.Support.V4.App.DialogFragment
	{

		public override Dialog OnCreateDialog (Bundle savedInstanceState)
		{
			return new AlertDialog.Builder (Activity).SetMessage ("Hello World").Create ();
		}


		// Remove the following lines to make the dialog appear

		public override void OnStart ()
		{
			base.OnStart ();
		}

	}
}


