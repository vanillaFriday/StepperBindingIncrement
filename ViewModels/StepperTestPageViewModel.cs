namespace StepperBindingIncrement.ViewModels
{
    public class StepperTestPageViewModel : ViewModelBase
    {
        private double _increment;
        private double _stroke01 = 0;
        private double _stroke1 = 0;
        private double _stroke10 = 0;
        private double _stroke100 = 0;

        public double Increment
        {
            set => SetProperty(ref _increment, value);
            get => _increment;
        }
        public double Stroke01
        {
            set => SetProperty<double>(ref _stroke01, value);
            get => _stroke01;
        }
        public double Stroke1
        {
            set => SetProperty<double>(ref _stroke1, value);
            get => _stroke1;
        }
        public double Stroke10
        {
            set => SetProperty<double>(ref _stroke10, value);
            get => _stroke10;
        }
        public double Stroke100
        {
            set => SetProperty<double>(ref _stroke100, value);
            get => _stroke100;
        }

        public StepperTestPageViewModel()
        {
            Increment = 11; Stroke1 = 5;
        }

        public Command ChangeDecimalExponentCommand
           => new Command<string>((exponent) =>
           {
               switch (exponent)
               {
                   case "0,1":
                       Increment = 0.1;
                       Stroke01 = 5; Stroke1 = 0; Stroke10 = 0; Stroke100 = 0;
                       break;
                   case "1":
                       Increment = 1;
                       Stroke01 = 0; Stroke1 = 5; Stroke10 = 0; Stroke100 = 0;
                       break;
                   case "10":
                       Increment = 10;
                       Stroke01 = 0; Stroke1 = 0; Stroke10 = 5; Stroke100 = 0;
                       break;
                   case "100":
                       Increment = 100;
                       Stroke01 = 0; Stroke1 = 0; Stroke10 = 0; Stroke100 = 5;
                       break;
                   default:
                       Increment = 1;
                       Stroke01 = 0; Stroke1 = 0; Stroke10 = 0; Stroke100 = 0;
                       break;
               };
           });
    }
}
