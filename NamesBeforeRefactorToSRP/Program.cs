namespace NamesBeforeRefactorToSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new NameBeforeSRP();
            var path = names.BuildFilePath();

            if (File.Exists(path))
            {
                Console.WriteLine("Names file already exists. Loading names.");
                names.ReadFromTextFile();
            }
            else
            {
                Console.WriteLine("Names file does not yet exist.");

                //let's imagine they are given by the user
                names.AddName("John");
                names.AddName("not a valid name");
                names.AddName("Claire");
                names.AddName("123 definitely not a valid name");

                Console.WriteLine("Saving names to the file.");
                names.WriteToTextFile();
            }
            Console.WriteLine(names.Format());

            Console.ReadLine();
        }
    }
}
