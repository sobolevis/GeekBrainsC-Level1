namespace Converter
{
    abstract class Converter
    {
        public abstract void Convert(string inputFile, string outputFile);
        public abstract void OpenFile(string inputFile);
        public abstract void ConvertFile(string outputFile);
    }
}
