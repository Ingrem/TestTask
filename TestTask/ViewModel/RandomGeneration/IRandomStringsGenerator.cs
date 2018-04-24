using TestTask.Model;

namespace TestTask.ViewModel.RandomGeneration
{
    public interface IRandomStringsGenerator
    {
        void RandomGenerate(RandomStringsModel randomString);
    }
}