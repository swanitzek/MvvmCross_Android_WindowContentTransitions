using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace ContentTransitions.Droid.Views
{
    [Activity(Label = "View for FirstViewModel", Theme="@style/AppTheme")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
