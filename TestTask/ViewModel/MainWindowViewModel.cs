using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using TestTask.Model;
using TestTask.ViewModel.RandomGeneration;

namespace TestTask.ViewModel
{
    class MainWindowViewModel
    {
        public RandomStringsModel RandomString { get; set; }
        public static List<string[]> HistoryList;

        public MainWindowViewModel()
        {
            StringButtonCommand = new Command(arg => StringButtonMethod());
            IntButtonCommand = new Command(arg => IntButtonMethod());
            RandomButtonCommand = new Command(arg => RandomButtonMethod());
            PreviousButtonCommand = new Command(arg => PreviousButtonMethod());
            HistoryList = new List<string[]>();
            RandomString = new RandomStringsModel
            {
                StringOrIntRandomaze = 1,
                RandomString1 = "",
                RandomString2 = "",
                RandomString3 = "",
                ButtonStringColor = new SolidColorBrush(Colors.Khaki),
                ButtonIntColor = new SolidColorBrush(Colors.Transparent)
        };
        }


        public ICommand StringButtonCommand { get; set; }
        private void StringButtonMethod()
        {
            RandomString.ButtonStringColor = new SolidColorBrush(Colors.Khaki);
            RandomString.ButtonIntColor = new SolidColorBrush(Colors.Transparent);
            RandomString.StringOrIntRandomaze = 1;
        }


        public ICommand IntButtonCommand { get; set; }
        private void IntButtonMethod()
        {
            RandomString.ButtonIntColor = new SolidColorBrush(Colors.Khaki);
            RandomString.ButtonStringColor = new SolidColorBrush(Colors.Transparent);
            RandomString.StringOrIntRandomaze = 2;
        }


        public ICommand RandomButtonCommand { get; set; }
        private void RandomButtonMethod()
        {
            RandomString.String1Color = new SolidColorBrush(Colors.Black);
            RandomString.String2Color = new SolidColorBrush(Colors.Black);
            RandomString.String3Color = new SolidColorBrush(Colors.Black);
            if (RandomString.StringOrIntRandomaze == 1)
            {
                RandomStringsGeneratorString tmpRandomStringsString = new RandomStringsGeneratorString();
                tmpRandomStringsString.RandomGenerate(RandomString);
            }
            else
            {
                RandomStringsGeneratorInt tmpRandomStringsInt = new RandomStringsGeneratorInt();
                tmpRandomStringsInt.RandomGenerate(RandomString);
            }           
        }


        public ICommand PreviousButtonCommand { get; set; }
        private void PreviousButtonMethod()
        {
            History<int> history = new History<int>();
            string[] rndStr = history.TakePrevious();
            int firstStr;
            if (rndStr != null)
            {
                if (Int32.TryParse(rndStr[0], out firstStr)) // int type
                {
                    RandomString.String1Color = new SolidColorBrush(Colors.Black);
                    RandomString.String2Color = new SolidColorBrush(Colors.Black);
                    RandomString.String3Color = new SolidColorBrush(Colors.Black);
                    int[] rndNums = new int[3];
                    rndNums[0] = Convert.ToInt32(firstStr);
                    rndNums[1] = Convert.ToInt32(rndStr[1]);
                    rndNums[2] = Convert.ToInt32(rndStr[2]);
                    int tmpMax = rndNums.Max();
                    if (tmpMax == rndNums[0])
                        RandomString.String1Color = new SolidColorBrush(Colors.Red);
                    if (tmpMax == rndNums[1])
                        RandomString.String2Color = new SolidColorBrush(Colors.Red);
                    if (tmpMax == rndNums[2])
                        RandomString.String3Color = new SolidColorBrush(Colors.Red);
                    RandomString.RandomString1 = rndNums[0].ToString();
                    RandomString.RandomString2 = rndNums[1].ToString();
                    RandomString.RandomString3 = rndNums[2].ToString();
                }
                else // string type
                {
                    RandomString.String1Color = new SolidColorBrush(Colors.Black);
                    RandomString.String2Color = new SolidColorBrush(Colors.Black);
                    RandomString.String3Color = new SolidColorBrush(Colors.Black);
                    if (rndStr[0][0] == rndStr[0][1] || rndStr[0][0] == rndStr[0][2] ||
                        rndStr[0][1] == rndStr[0][2])
                        RandomString.String1Color = new SolidColorBrush(Colors.Green);
                    if (rndStr[1][0] == rndStr[1][1] || rndStr[1][0] == rndStr[1][2] ||
                        rndStr[1][1] == rndStr[1][2])
                        RandomString.String2Color = new SolidColorBrush(Colors.Green);
                    if (rndStr[2][0] == rndStr[2][1] || rndStr[2][0] == rndStr[2][2] ||
                        rndStr[2][1] == rndStr[2][2])
                        RandomString.String3Color = new SolidColorBrush(Colors.Green);
                    RandomString.RandomString1 = rndStr[0];
                    RandomString.RandomString2 = rndStr[1];
                    RandomString.RandomString3 = rndStr[2];
                }
            }
        }
    }
}
