namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            System.Console.WriteLine(string.Join(" ", strings));
            int[] integers = ArrayCreator.Create(10, 33);
            System.Console.WriteLine(string.Join(" ", integers));
            System.Console.Read();
        }
    }
}
