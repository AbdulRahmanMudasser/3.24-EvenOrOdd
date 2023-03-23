class EvenOrOdd
{
    static void Main(string[] args)
    {
        // declaring variable
        int number;

        // prompting user for inpt and taking input
        Console.Write("Enter A Number:  ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // checking whether the entered number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine("Entered Number Is Even");
        }

        else if (number % 2 != 0)
        {
            Console.WriteLine("Entered Number Is Odd");
        }
    }
}
