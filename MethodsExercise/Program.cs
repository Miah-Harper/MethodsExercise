using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What breed are you?");
            var breed = Console.ReadLine();

            Console.WriteLine("What is your favorite snack?");
            var snack = Console.ReadLine();

            Console.WriteLine("Who is your favorite person?");
            var favoritePerson = Console.ReadLine();


            //name = Mender;
            //breed = Golden Retriever;
            //snack = blueberries;
            //favoritePerson = Mom;


            Console.WriteLine($"Hello! My name is {name} and I am a {breed}. My {favoritePerson} loves to give me {snack} when i'm a good boy!");



        
       }

        Console.WriteLine(Add(6, 7));

       {

        public static int  Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2);
         {

        return num1 * num 2;
    }

    public static int Divide(int num 1, int num2);
    {
     
    return num1 / num2;
}

}
