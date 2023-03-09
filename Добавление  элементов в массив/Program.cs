namespace Добавление__элементов_в_массив
{
    // написать методы для добавления элемента в начало массива, в конец массива
    // и по указаному индексу
    internal class Program
    {
            static void addEndberArray(ref int[] newArray)
            {

            Random RND = new Random();
            newArray[^1] = RND.Next(99, 199);
            }
            static void addOneNumberArray(ref int[] newArray)
            {

            Random RND = new Random();
            newArray[0] = RND.Next(11, 31);
            }
            static void addRndNumberArray (ref int[] newArray, int number)
            {

            Random RND= new Random ();
            newArray[number] = RND.Next(2000, 3000);
            }
        static void Main(string[] args)
        {
            Console.Write("Какой индекс исправим?  ");
            int rndNumberArray = int.Parse(Console.ReadLine());
            int[] myArray = { 1, 2, 3, 4, 5 };
            addRndNumberArray(ref myArray, rndNumberArray);
            addOneNumberArray(ref myArray);
            addEndberArray(ref myArray);
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}