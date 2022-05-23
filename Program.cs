using FindMaximum_Generics.FindMax;

int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\nList of choices");
    Console.WriteLine("1 - Find maximum using non-generic method");
    Console.WriteLine("2 - Find maximum using generic method");
    Console.WriteLine("3 - Find maximum using generic class");
    Console.WriteLine("4 - Find maximum For more than three parameters");
    Console.WriteLine("5 - Find maximum and print maximum using generic method");

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
            Console.WriteLine("String Maximum Number using generic : " + Generic.Maximum("Apple", "Peach", "Banana"));
            break;
        case 3:
            Console.WriteLine("\nInteger Maximum Number using generic class : " + GenericClass<int>.Maximum(11, 4, 10));
            Console.WriteLine("Float Maximum Number using generic class : " + GenericClass<double>.Maximum(1.3, 13.6, 21.7));
            Console.WriteLine("string Maximum Number using generic class : " + GenericClass<string>.Maximum("apple", "Apple", "BANANA"));
            break;
        case 4:
            int[] integer = { 5, 12, 36, 2, 10 };
            MoreParameters<int> moreint = new MoreParameters<int>(integer);
            Console.WriteLine("\nInteger Maximum Number : " + moreint.MaxMethod());
            float[] floats = { 55.2f, 12.6f, 36.1f, 2.5f, 10.8f };
            MoreParameters<float> morefloat = new MoreParameters<float>(floats);
            Console.WriteLine("Float Maximum Number : " + morefloat.MaxMethod());
            string[] strings  = {"one","two","three","four","five"};
            MoreParameters<string> morestring = new MoreParameters<string>(strings);
            Console.WriteLine("Integer Maximum Number : " + morestring.MaxMethod());
            break;
        case 5:
            int[] intValues = { 73, 12, 36, 2, 10 };
            MoreParameters<int> printint = new MoreParameters<int>(intValues);
            printint.PrintMaximum();
            float[] floatValues = { 55.2f, 12.6f, 36.1f, 92.5f, 10.8f };
            MoreParameters<float> printfloat = new MoreParameters<float>(floatValues);
            printfloat.PrintMaximum();
            string[] stringValues = { "Dante","ray","john","geralt", "sekiro" };
            MoreParameters<string> printstring = new MoreParameters<string>(stringValues);
            printstring.PrintMaximum();
            break;
        default:
            flag = 1;
            Console.WriteLine("\nInvalid choice");
            break;
    }
}