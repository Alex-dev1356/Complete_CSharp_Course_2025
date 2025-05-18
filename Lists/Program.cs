namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            var words = new List<string>();
            //For list we use count instead of Length
            Console.WriteLine("Count of element is " + words.Count);

            //Adding elements
            words.Add("One");
            words.Add("Two");
            words.Add("Three");
            words.Add("Four");
            words.Add("Five");
            words.Add("Six");
            words.Add("Seven");
            words.Add("Eight");
            words.Add("Nine");
            words.Add("Ten");
            Console.WriteLine("Count of element is " + words.Count);

            //Initializing list with values
            var words1 = new List<string> 
            { 
                "One", 
                "Two", 
                "Three", 
                "Four", 
                "Five", 
                "Six", 
                "Seven", 
                "Eight", 
                "Nine", 
                "Ten" 
            };
            Console.WriteLine("Count of element is " + words1.Count);

            //Printing elements in the console
            foreach (var word in words1)
            {
                Console.WriteLine(word);
            }

            //Setting a value to a specific index
            words1[0] = "Zero";
            Console.WriteLine("Count of element is " + words1.Count);

            //Removing an element
            words1.Remove("Zero");
            Console.WriteLine("Count of element is " + words1.Count);

            //Using the RemoveAt method - To remove an element at a specified index in the list.
            words1.RemoveAt(0);
            Console.WriteLine("Count of element is " + words1.Count);

            //Using the AddRange method - To add a range of elements to the end of the list.
            words1.AddRange(new[] { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen" });
            Console.WriteLine("Count of element is " + words1.Count);
            
            //Using the IndexOf method - To get the index of a specific element in the list.
            var index = words1.IndexOf("Eleven");
            Console.WriteLine("Index of Eleven is " + index);   

            //Using the Contains method - To check if a specific element is in the list.
            var contains = words1.Contains("Eleven");
            Console.WriteLine("Contains Eleven is " + contains);

            //Using the Clear method - To remove all elements from the list.
            words1.Clear();
            Console.WriteLine("Count of element is " + words1.Count);
        }
    }
}
