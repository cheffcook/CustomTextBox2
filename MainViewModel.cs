using Prism.Mvvm;

namespace CustomTextBox
{
    internal class MainViewModel : BindableBase
    {
        private float _customValue1;
        public float CustomValue1
        {
            get => _customValue1;
            set => SetProperty(ref _customValue1, value, nameof(CustomValue1));
        }

        private float _customValue2;
        public float CustomValue2
        {
            get => _customValue2;
            set => SetProperty(ref _customValue2, value, nameof(CustomValue2));
        }

        private float _customValue3;
        public float CustomValue3
        {
            get => _customValue3;
            set => SetProperty(ref _customValue3, value, nameof(CustomValue3));
        }

        public MainViewModel()
        {
            CustomValue1 = 12.3f;
            CustomValue2 = 45.6f;
            CustomValue3 = 78.9f;
        }
    }
}
