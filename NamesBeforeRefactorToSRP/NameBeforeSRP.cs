using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesBeforeRefactorToSRP
{
    public class NameBeforeSRP
    {
        private readonly List<string> _names = new List<string>();

        public void AddName(string name)
        {
            if (IsValidName(name))
            {
                _names.Add(name);
            }
        }

        private bool IsValidName(string name)
        {
            return
                name.Length >= 2 &&
                name.Length < 25 &&
                char.IsUpper(name[0]) &&
                name.All(char.IsLetter);
        }

        public void ReadFromTextFile()
        {
            var fileContents = File.ReadAllText(BuildFilePath());
            var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
            foreach (var name in namesFromFile)
            {
                AddName(name);
            }
        }

        public void WriteToTextFile() =>
            File.WriteAllText(BuildFilePath(), Format());

        public string BuildFilePath()
        {
            //we could imagine this is much more complicated
            //for example that path is provided by the user and validated
            return "names.txt";
        }

        public string Format() =>
            string.Join(Environment.NewLine, _names);
    }
}
