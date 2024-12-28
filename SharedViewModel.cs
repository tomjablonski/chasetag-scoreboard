using System.ComponentModel;

namespace chasetag_scoreboard
{
    public class SharedViewModel : INotifyPropertyChanged
    {
        private string _name1;
        private string _name2;

        public string Name1
        {
            get => _name1;
            set
            {
                if (_name1 != value)
                {
                    _name1 = value;
                    OnPropertyChanged(nameof(Name1));
                }
            }
        }

        public string Name2
        {
            get => _name2;
            set
            {
                if (_name2 != value)
                {
                    _name2 = value;
                    OnPropertyChanged(nameof(Name2));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}