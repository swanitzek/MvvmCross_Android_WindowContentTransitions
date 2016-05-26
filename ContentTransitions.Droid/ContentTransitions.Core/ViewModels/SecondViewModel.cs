using MvvmCross.Core.ViewModels;

namespace ContentTransitions.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
       public IMvxCommand ButtonClick { get; set; }

        public SecondViewModel()
        {
            ButtonClick = new MvxCommand(buttonClicked);
        }

        private void buttonClicked()
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}
