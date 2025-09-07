namespace VirtualMethods_StringProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>
            {
                "apple",
                "banana",
                "cherry",
                "date"
            };

            var exercise = new Exercise();
            var result = exercise.ProcessAll(words);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }

    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    //your code goes here

    public abstract class StringsProcessor
    {
        public abstract List<string> Process(List<string> words);
    }

    public class StringsTrimmingProcessor
        : StringsProcessor
    {
        public override List<string> Process(List<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                var halfNumberOfCharacters = word.Length / 2;
                var trimmedWord = word.Substring(0, halfNumberOfCharacters);
                result.Add(trimmedWord);
            }
            return result;
        }
    }
    public class StringsUppercaseProcessor
    : StringsProcessor
    {
        public override List<string> Process(List<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                result.Add(word.ToUpper());
            }
            return result;
        }
    }
}
