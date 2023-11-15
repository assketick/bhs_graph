using System.Globalization;

class Programm
{
    static void Main(string[] args)
    {
        StartBlock startBlock = new StartBlock();
        Adder adder = new Adder();
        Printer printer = new Printer();
        ConstBlock const1 = new ConstBlock(0), const2 = new ConstBlock(0);
        int firstNumber = 0, secondNumber = 0;

        startBlock.GraphOutput.Link = adder.GraphInput;
        adder.InputSlots[0].Link = const1.OutputSlots[0];
        adder.InputSlots[1].Link = const2.OutputSlots[0];
        adder.GraphOutput.Link = printer.GraphInput;
        printer.GraphInput.Link = adder.GraphOutput;

        while (true)
        {
            Console.Write("Введите два целых числа. Ctrl + C для выхода\n");
            while (true)
            {
                try
                {
                    Console.Write("Первое число: ");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Проверьте, что вы ввели число и оно является целым");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Второе число: ");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nПроверьте, что вы ввели число и оно является целым");
                }
            }
            const1.Number = firstNumber;
            const2.Number = secondNumber;
            startBlock.Run();
        }
    }
}

