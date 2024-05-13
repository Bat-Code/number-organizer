namespace NumberOrganizer;

public class PrintInfo
{
    protected String ico = "                      (        *( %                                   \n                      (((/,     ((((.                                 \n                     @#((/(((((((/**                                  \n                    %(((@%((((@(((((((.                               \n                    *@@(((((((        *//.                            \n             @&%  @ &((((((         ,/*///////////////////*(          \n          #&&***,,@&((((,           ,/*//%%%&%%/&%&%&%&%&/*#          \n          ./****. (((               ,/*///////////////////*#          \n          ./****##(/,               ,/*//%%###(/%##/%/#///*#          \n          .*****  //(     ##%%%%%%% ,/*///////////////////*#          \n          .*****   **/((***,,.***** ,/*//&&((/////////////*#          \n          .*** (#((      ,**(((( (( ,/*//////////****/////*#          \n          .** @(%@&(((((((((((((((( ,/*////////*  ///&(///*#          \n          .. ((((((((*((((@@@@@@@@@ ,/*////////*  ///&(///*#          \n           &@((&(((( **(( @@ ( ,  @ ,/*////////*  ///&(///*#          \n          ./**((((** **//(//(#@@((( ,/*////////*  *//&(///*(          \n          .(((**((**( (((,,,    .......... ..../* .///##              \n       .  .  ..   ....  .      .                                      \n";
    private String start = "Welcome, we will arrange a total of 10 numbers, please enter the values:";
    private String options = "1. Bubble \n" +
                             "2. Shell \n" +
                             "3. Selection \n" +
                             "4. Insert";

    private void printIco()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(ico);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public List<int> getInfoStart()
    {
        printIco();
        List<int> numbers = new List<int>();
        Console.WriteLine(start);
        for (int i = 0; i < 10; i++)
        {
            try // Uso de excepciones
            {
                    Console.WriteLine($"Enter the number {i + 1}: ");
                    int number = int.Parse(Console.ReadLine());
                    numbers.Add(number);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: You must enter a valid integer");
                Console.ForegroundColor = ConsoleColor.White;
                i--;
            }
        }
        Console.Clear();
        return numbers;
    }

    private void printList(List<int> list)
    {
        Console.WriteLine("(" + string.Join(",", list) + ")");
    }
    
    public int getSelectedMethod()
    {   
        Console.WriteLine(12);
        printIco();
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
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (!validNumber);

        return number;
    }

    protected String methodSelectedWord(int selection)
    {
        String methodSelected = null;
        if (selection == 1) {
            methodSelected = "Bubble";
        } else if (selection == 2) {
            methodSelected = "Shell";
        } else if (selection == 3) {
            methodSelected = "Selection";
        } else if (selection == 4) {
            methodSelected = "Insert";
        }

        return methodSelected;
    }

    public void printInitSelection(int selection, List<int> oldList, List<int> newList)
    {
        Console.Clear();
        printIco();
        String methodSelected = methodSelectedWord(selection);
        
        Console.WriteLine($"\n You selected the " + methodSelected +" Method then the numbers you inserted were:");
        printList(oldList);
        Console.WriteLine("\n Now the organized list is: ");
        printList(newList);
    }
}