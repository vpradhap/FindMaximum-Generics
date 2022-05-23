using FindMaximum_Generics.FindMax;

int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\nList of choices");
    Console.WriteLine("1 - Find maximum using non-generic method");
    Console.WriteLine("2 - Find maximum using generic method");
    Console.Write("\nYour Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    switch (pick)
    {
        case 1:
            Console.WriteLine("\nInteger Maximum Number : " + FindMax.FindMaxInt(15, 45, 25));
            Console.WriteLine("Float Maximum Number : " + FindMax.FindMaxDouble(15.2, 25.6, 32.1));
            Console.WriteLine("String Maximum Number : " + FindMax.FindMaxString("Apple", "Banana", "apple"));
            break;
        case 2:
            Console.WriteLine("\nInteger Maximum Number using generic : " + Generic.Maximum(4, 16, 23));
            Console.WriteLine("Float Maximum Number using generic : " + Generic.Maximum(11.8, 4.3, 10.1));
            Console.WriteLine("String Maximum Number using generic : " + Generic.Maximum("Appe", "Peach", "Banana"));
            break;
        default:
            flag = 1;
            Console.WriteLine("\nInvalid choice");
            break;
    }
}