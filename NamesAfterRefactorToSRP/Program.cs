using NamesAfterRefactorToSRP.DataAccess;

namespace NamesAfterRefactorToSRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nameValidator = new NameValidator();
            var stringsTextualRepository = new StringsTextualRepository();
            var stringFilePath = new StringFilePath();
            var names = new Names();
            var stringFormatter = new StringFormatter();
            var path = stringFilePath.BuildFilePath();

            if (File.Exists(path))
            {
                Console.WriteLine("Names file already exists. Loading names.");
                stringsTextualRepository.Read(path);
            }
            else
            {
                Console.WriteLine("Names file does not yet exist.");

                //let's imagine they are given by the user
                names.AddNames("John");
                names.AddNames("not a valid name");
                names.AddNames("Claire");
                names.AddNames("123 definitely not a valid name");

                Console.WriteLine("Saving names to the file.");
                stringsTextualRepository.Write(path, names._names);
            }
            Console.WriteLine(stringFormatter.Format(names._names));

            Console.ReadLine();
        }
    }
}
