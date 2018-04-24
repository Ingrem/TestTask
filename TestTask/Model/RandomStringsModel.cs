using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TestTask.Model
{
    public class RandomStringsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _stringOrIntRandomaze;
        private string _randomString1;
        private string _randomString2;
        private string _randomString3;
        private SolidColorBrush _buttonStringColor;
        private SolidColorBrush _buttonIntColor;
        private SolidColorBrush _colorString1;
        private SolidColorBrush _colorString2;
        private SolidColorBrush _colorString3;

        // Get or set randomaze flag
        public int StringOrIntRandomaze
        {
            get => _stringOrIntRandomaze;
            set
            {
                if (_stringOrIntRandomaze != value)
                {
                    _stringOrIntRandomaze = value;
                    OnPropertyChanged("StringOrIntRandomaze");

                }
            }
        }

        // Get or set random strings
        public string RandomString1
        {
            get => _randomString1;
            set
            {
                if (_randomString1 != value)
                {
                    _randomString1 = value;
                    OnPropertyChanged("RandomString1");
                }
            }
        }
        // Get or set random strings
        public string RandomString2
        {
            get => _randomString2;
            set
            {
                if (_randomString2 != value)
                {
                    _randomString2 = value;
                    OnPropertyChanged("RandomString2");
                }
            }
        }
        // Get or set random strings
        public string RandomString3
        {
            get => _randomString3;
            set
            {
                if (_randomString3 != value)
                {
                    _randomString3 = value;
                    OnPropertyChanged("RandomString3");
                }
            }
        }

        #region UIColorsChange

        // Get or set ButtonString color
        public SolidColorBrush ButtonStringColor
        {
            get => _buttonStringColor;
            set
            {
                if (!Equals(_buttonStringColor, value))
                {
                    _buttonStringColor = value;
                    OnPropertyChanged("ButtonStringColor");
                }
            }
        }
        // Get or set ButtonInt color
        public SolidColorBrush ButtonIntColor
        {
            get => _buttonIntColor;
            set
            {
                if (!Equals(_buttonIntColor, value))
                {
                    _buttonIntColor = value;
                    OnPropertyChanged("ButtonIntColor");
                }
            }
        }
        // Get or set String1Color color
        public SolidColorBrush String1Color
        {
            get => _colorString1;
            set
            {
                if (!Equals(_colorString1, value))
                {
                    _colorString1 = value;
                    OnPropertyChanged("String1Color");
                }
            }
        }
        // Get or set String2Color color
        public SolidColorBrush String2Color
        {
            get => _colorString2;
            set
            {
                if (!Equals(_colorString2, value))
                {
                    _colorString2 = value;
                    OnPropertyChanged("String2Color");
                }
            }
        }
        // Get or set String3Color color
        public SolidColorBrush String3Color
        {
            get => _colorString3;
            set
            {
                if (!Equals(_colorString3, value))
                {
                    _colorString3 = value;
                    OnPropertyChanged("String3Color");
                }
            }
        }
#endregion
    }
}
