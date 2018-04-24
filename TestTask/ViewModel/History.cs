using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.ViewModel
{
    class History <T>
    {
        public void Add(T[] rndStrings)
        {
            string[] tmpStrArray = new string[rndStrings.Length];
            for (int i = 0; i < rndStrings.Length; i++)
                tmpStrArray[i] = rndStrings[i].ToString();
            MainWindowViewModel.HistoryList.Add(tmpStrArray);
        }

        public string[] TakePrevious()
        {
            if (MainWindowViewModel.HistoryList.Count > 1)
                MainWindowViewModel.HistoryList.RemoveAt(MainWindowViewModel.HistoryList.Count - 1);
            return MainWindowViewModel.HistoryList.Count > 0 ? MainWindowViewModel.HistoryList[MainWindowViewModel.HistoryList.Count - 1] : null;
        }
    }
}
