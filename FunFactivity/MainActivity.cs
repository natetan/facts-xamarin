using Android.App;
using Android.Widget;
using Android.OS;

namespace FunFactivity {
	[Activity(Label = "FunFactivity", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity {

		FactBook factBook = new FactBook();

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			TextView factTextView = FindViewById<TextView>(Resource.Id.factTextView);
			Button showFactButton = FindViewById<Button>(Resource.Id.showFactButton);

			showFactButton.Click += (sender, e) => {
				factTextView.Text = factBook.getFact(0);
			};

		}
	}
}

