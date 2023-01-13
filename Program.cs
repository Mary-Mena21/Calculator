// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
do
{
    double num1 = 0;
    double num2 = 0;
    double result = 0;

    while ((num1 <= 0) && (num1 <= 0))
    {
        try
        {
            Console.Write("inter number 1:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("inter number 2:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option:");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Subtract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Divide");


        }
        catch (Exception)
        //catch (Exception e)
        {
            //throw new Exception(e.Message);
            Console.WriteLine();
            Console.WriteLine("Please enter a valid number");

        }

    }




    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("Sum result:{0}+{1}={2}", num1, num2, result);
            //Console.WriteLine($"Sum result: {num1} + {num2} = {result}");
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine("Subtract result:{0}-{1}={2}", num1, num2, result);
            //Console.WriteLine($"Subtract result: {num1} - {num2} = {result}");
            break;
        case "*":
            result = num1 + num2;
            Console.WriteLine("Multiply result:{0}*{1}={2}", num1, num2, result);
            //Console.WriteLine($"Multiply result: {num1} * {num2} = {result}");
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine("Divide result:{0}/{1}={2}", num1, num2, result);
            //Console.WriteLine($"Divide result: {num1} / {num2} = {result}");
            break;
        default:
            Console.WriteLine("Inter valid option!");
            break;
    }


    Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
} while (Console.ReadLine().ToUpper() == "Y"); 

    Console.WriteLine("Goodbye!"); 



Console.ReadKey();

/*---------------StringBuilder-----------------*/
//using System.Text;

//StringBuilder bldr = new StringBuilder();
//var startTime = DateTime.Now;
//for (int i = 0; i< 1_000_000; i++)
//{
//    bldr.Append(i.ToString());
//}
//var stopTime = DateTime.Now;
//Console.WriteLine($"Started:{startTime} Stopped:{stopTime}");

//Console.ReadKey();
