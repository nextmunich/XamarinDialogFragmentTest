# Xamarin Android.Support.V4.App.DialogFragment Issue on Android 5 / ART

When using Android.Support.V4.App.DialogFragment in a Xamarin-based project, overriding the OnStart () method of DialogFragment causes the dialog to not be displayed on screen. The code in this repo is a simple way of reproducing the issue for reference by people interested in the problem.

The very same code is confirmed to work when Android.App.DialogFragment is used (overriding OnStart () will not cause problems) instead.