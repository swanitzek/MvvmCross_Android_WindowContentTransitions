using Android.App;
using Android.OS;
using ContentTransitions.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace ContentTransitions.Droid.Views
{
    [Activity(Theme="@style/AppTheme")]
    public class SecondView : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }
    }
}
