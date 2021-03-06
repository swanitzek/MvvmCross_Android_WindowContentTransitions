using MvvmCross.Core.ViewModels;

namespace ContentTransitions.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
       public IMvxCommand ButtonClick { get; set; }

        public FirstViewModel()
        {
            ButtonClick = new MvxCommand(buttonClicked);
        }

        private void buttonClicked()
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}
