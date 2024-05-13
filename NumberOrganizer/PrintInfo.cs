namespace NumberOrganizer;

public class PrintInfo
{
    private String start = "Welcome, we will arrange a total of 10 numbers, please enter the values:";

    private String options = "1. Bubble \n" +
                             "2. Shell \n" +
                             "3. Selection \n" +
                             "4. Insert";

    public List<int> getInfoStart()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        List<int> numbers = new List<int>();
        Console.WriteLine(this.start);
        for (int i = 0; i < 10; i++)
        {
            try // Uso de excepciones
            {
                    Console.WriteLine($"\nEnter the number {i + 1}: ");
                    int number = int.Parse(Console.ReadLine());
                    numbers.Add(number);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: You must enter a valid integer");
                Console.ForegroundColor = ConsoleColor.Green;
                i--;
            }
        }

        return numbers;
    }

    public int getSelectedMethod()
    {   
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n Select an organization method:");
        Console.WriteLine(options);
        int number = 0;
        Boolean validNumber = false;

        do
        {
            try
            {
                Console.WriteLine("Please enter the number of the selected option:  ");
                String input = Console.ReadLine();
                number = int.Parse(input);

                if (number >= 1 && number <= 4)
                {
                    validNumber = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: You entered an out-of-range number or an invalid format");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        } while (!validNumber);

        return number;
    }
}