using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using System.Collections.Generic;
using Android.Content;

namespace TipCalculator
{
	[Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{        
		int count = 1;
        EditText editText1;
        TextView textView1, textView2;
        
        protected override void OnCreate(Bundle savedInstanceState)
		{
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            editText1 = FindViewById<EditText>(Resource.Id.myEditText1);
            textView1 = FindViewById<TextView>(Resource.Id.myTextView1);
            textView2 = FindViewById<TextView>(Resource.Id.myTextView2);
            Button button = FindViewById<Button>(Resource.Id.myButton);
			
			button.Click += delegate
			{                
                float cuota = float.Parse(editText1.Text);
                float impuesto = cuota * 0.16f;
                float total = cuota + impuesto;

                button.Text = string.Format("{0} clicks!", count++);
                textView1.Text = "Impuesto:" + impuesto.ToString();
                textView2.Text = "Total: " + total;
            };
		}       
	}
}


