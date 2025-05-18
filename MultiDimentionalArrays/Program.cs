namespace MultiDimentionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] letters = new char[2, 3];
            
            letters[0, 0] = 'a';
            letters[0, 1] = 'b';
            letters[0, 2] = 'c';
            letters[1, 0] = 'd';
            letters[1, 1] = 'e';
            letters[1, 2] = 'f';

            var letters2 = new char[,] 
            { 
                { 'a', 'b', 'c' }, 
                { 'd', 'e', 'f' } 
            };

            //Printing Each Array in the Console
            var height = letters2.GetLength(0);
            var width = letters2.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(letters[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
