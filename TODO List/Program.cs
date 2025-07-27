using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace TODO_List
{
    public class Program
    {
        public static List<string> TODOList = new List<string>();
        public static void Main(string[] args)
        {
            var exitSelected = false;

            //SelectTODOMenu();
            do
            {
                var menuOption = SelectTODOMenu();

                switch (menuOption)
                {
                    case "s":
                        SeeAllTODOs();
                        break;
                    case "a":
                        AddTODO();
                        break;
                    case "r":
                        RemoveTODO();
                        break;
                    case "e":
                        exitSelected = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            while (exitSelected != true);
    }

        //TODO List Selecting Menu
        public static string SelectTODOMenu()
        {
            Console.WriteLine(string.Join(Environment.NewLine,
            @"
            Hello!
            What do you want to do?
            [S]ee all TODOs
            [A]dd a TODO
            [R]emove a TODO
            [E]xit
            "
                .Split('\n')
                .Select(line => line.TrimStart()))
            );
            var result = Console.ReadLine().ToLower();

            return result;
        }

        //See All TODOs
        public static void SeeAllTODOs()
        {
            //var allTODOs = new List<string>();
            int count = 0;

            if (TODOList.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }

            foreach (var todo in TODOList)
            {
                Console.WriteLine($"{++count}. {todo}.");
            }
        }

        //Add a TODO
        public static void AddTODO()
        {
            bool isValidInput = false;

            do
            {
                Console.Write("Enter the TODO description:");
                var userInput = Console.ReadLine();

                if (TODOList.Contains(userInput))
                {
                    Console.WriteLine("The description must be unique.");
                }
                else if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("The description cannot be empty.");
                }
                else
                {
                    TODOList.Add(userInput);
                    isValidInput = true;
                    Console.WriteLine($"TODO successfully added: {userInput}");
                }
            }
            while (isValidInput != true);
        }

        //Remove a TODO
        public static void RemoveTODO()
        {
            var validInput = false;

            do
            {
                Console.WriteLine("Select the index of the TODO you want to remove:");
                SeeAllTODOs();
                if (TODOList.Count == 0)
                {
                    break;
                }

                var userInput = Console.ReadLine();

                var indexofSelectedTODO = int.TryParse(userInput, out int indexSelected);

                if (indexofSelectedTODO == false || 
                    indexSelected > TODOList.Count() ||
                    indexSelected < 0)
                {
                    Console.WriteLine("The given index is not valid.");
                }
                else if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Selected index cannot be empty.");
                }
                else
                {
                    TODOList.RemoveAt(indexSelected - 1);
                    validInput = true;
                    Console.WriteLine($"TODO removed: {TODOList[indexSelected - 1]}");
                }
            }
            while (validInput != true);
        }
    }
}
