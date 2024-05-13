// Estudiante: Juan David Ramos
// Codigo: 1014857569
// Grupo: 230

using NumberOrganizer;

class Program
{
    static void Main(string[] args)
    {
        CreateFile create = new CreateFile();
        PrintInfo menu = new PrintInfo();
        Methods methods = new Methods();
        List<int> numbers = menu.getInfoStart();
        //List<int> numbers = new List<int> { 5, 3, 9, 1, 10, 7, 2, 4, 6, 8 };
        
        Console.Clear();

        int selection = menu.getSelectedMethod();
        
        Console.Clear();
        
        // Manejamos el flujo del codigo dependiendo el metodo seleccionado
        List<int> resultado;
        switch (selection)
        {
            case 1: // Bubble Method
                menu.printInitSelection(selection,numbers,methods.bubbleMethod(numbers));
                Console.WriteLine("A new file was created in: /bin/Debug/net7.0/");
                create.createNewFile(selection,numbers,methods.bubbleMethod(numbers));
                break;
            case 2: // Shell Method
                menu.printInitSelection(selection,numbers,methods.shellMethod(numbers));
                Console.WriteLine("A new file was created in: /bin/Debug/net7.0/");
                create.createNewFile(selection,numbers,methods.shellMethod(numbers));
                break;
            case 3: // Selection Method
                menu.printInitSelection(selection,numbers,methods.selectionMethod(numbers));
                Console.WriteLine("A new file was created in: /bin/Debug/net7.0/");
                create.createNewFile(selection,numbers,methods.selectionMethod(numbers));
                break;
            case 4: // Insert Method
                menu.printInitSelection(selection,numbers,methods.insertMethod(numbers));
                Console.WriteLine("A new file was created in: /bin/Debug/net7.0/");
                create.createNewFile(selection,numbers,methods.insertMethod(numbers));
                break;
        }

    }
}