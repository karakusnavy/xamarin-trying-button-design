using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace StoryTR
{
    [Activity(Label = "@string/app_name", Theme = "@android:style/Theme.Material.Light.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btn,btn3;
        LinearLayout btn2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
            SetContentView(Resource.Layout.activity_main);
            btn = FindViewById<Button>(Resource.Id.button2);
            btn3 = FindViewById<Button>(Resource.Id.button1);
            btn2 = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            btn2.Click += Btn2_Click;
            btn.Click += Btn_Click;            
            btn3.Click+= Btn2_Click;
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            btn3.Text = "Thanks for click";                        
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            btn.Text = "Thanks for click";
        }
    }
}