using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using TestTask.Model;

namespace TestTask.ViewModel.RandomGeneration
{
    class RandomStringsGeneratorInt : IRandomStringsGenerator
    {
        public void RandomGenerate(RandomStringsModel randomString)
        {
            int[] rndNums = new int[3];
            Task.WaitAll(Task.Run(() => RandomGenerateAsync(randomString, rndNums)));
            int tmpMax = rndNums.Max();
            if (tmpMax == rndNums[0])
                randomString.String1Color = new SolidColorBrush(Colors.Red);
            if (tmpMax == rndNums[1])
                randomString.String2Color = new SolidColorBrush(Colors.Red);
            if (tmpMax == rndNums[2])
                randomString.String3Color = new SolidColorBrush(Colors.Red);
        }

        private void RandomGenerateAsync(RandomStringsModel randomString, int[] rndNums)
        {
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                rndNums[i] = rnd.Next(0, 255);
            }
            randomString.RandomString1 = rndNums[0].ToString();
            randomString.RandomString2 = rndNums[1].ToString();
            randomString.RandomString3 = rndNums[2].ToString();
            History<int> addHistory = new History<int>();
            addHistory.Add(rndNums);
        }
    }
}
