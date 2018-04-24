using System;
using System.Threading.Tasks;
using System.Windows.Media;
using TestTask.Model;

namespace TestTask.ViewModel.RandomGeneration
{
    class RandomStringsGeneratorString : IRandomStringsGenerator
    {
        public void RandomGenerate(RandomStringsModel randomString)
        {
            string[] rndNums = new string[3];
            Task.WaitAll(Task.Run(() => RandomGenerateAsync(randomString, rndNums)));
               if (rndNums[0][0] == rndNums[0][1] || rndNums[0][0] == rndNums[0][2] || rndNums[0][1] == rndNums[0][2])
                   randomString.String1Color = new SolidColorBrush(Colors.Green);
               if (rndNums[1][0] == rndNums[1][1] || rndNums[1][0] == rndNums[1][2] || rndNums[1][1] == rndNums[1][2])
                   randomString.String2Color = new SolidColorBrush(Colors.Green);
               if (rndNums[2][0] == rndNums[2][1] || rndNums[2][0] == rndNums[2][2] || rndNums[2][1] == rndNums[2][2])
                   randomString.String3Color = new SolidColorBrush(Colors.Green); 
        }

        private void RandomGenerateAsync(RandomStringsModel randomString, string[] rndNums)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                rndNums[i] = string.Format("{0}{1}{2}", (char)rnd.Next('a', 'z'), (char)rnd.Next('a', 'z'), (char)rnd.Next('a', 'z'));
            }
            randomString.RandomString1 = rndNums[0];
            randomString.RandomString2 = rndNums[1];
            randomString.RandomString3 = rndNums[2];
            History<string> addHistory = new History<string>();
            addHistory.Add(rndNums);
        }
    }
}
