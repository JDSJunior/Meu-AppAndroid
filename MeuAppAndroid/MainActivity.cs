using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MeuAppAndroid
{
    [Activity(Label = "MeuAppAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //int count = 1; 

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            /*Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate 
            {
                button.SetBackgroundColor(Android.Graphics.Color.Aqua);
                button.SetTextColor(Android.Graphics.Color.Black);
                button.Text = string.Format("{0} clicks!", count++); 
            };

            Button btnJunior = FindViewById<Button>(Resource.Id.btnJunior);
            btnJunior.Click += delegate
            {
                btnJunior.SetTextColor(Android.Graphics.Color.White);
                btnJunior.SetBackgroundColor(Android.Graphics.Color.DarkBlue);
                btnJunior.SoundEffectsEnabled = false;
            };*/

            LinearLayout layout = new LinearLayout(this);
            layout.SetBackgroundColor(Android.Graphics.Color.Gray);
            layout.Orientation = Orientation.Vertical;

            Button button = new Button(this);
            button.Text = "Junior";
            button.SetBackgroundColor(Android.Graphics.Color.Red);
            layout.AddView(button, ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            SetContentView(layout);

        }
    }
}

