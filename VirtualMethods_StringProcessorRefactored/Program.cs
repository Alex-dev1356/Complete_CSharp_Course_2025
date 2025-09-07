using System.Diagnostics.Tracing;

namespace VirtualMethods_StringProcessorRefactored
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
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

        public class StringsProcessor
        {
            //public List<string> Result = new List<string>();
            public List<string> Process(List<string> words)
            {
                var result = new List<string>();

                foreach (var word in words)
                {
                    result.Add(ProcessSingle(word));
                }

                return result;
            }

            public virtual string ProcessSingle(string words) => words;
        }

        public class StringsTrimmingProcessor
            : StringsProcessor
        {
            public override string ProcessSingle(string word) =>
                word.Substring(0, word.Length /2);
        }

        public class StringsUppercaseProcessor
            : StringsProcessor
        {
            public override string ProcessSingle(string word) =>
                word.ToUpper();
        }

    }
}
