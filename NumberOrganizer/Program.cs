// Estudiante: Juan David Ramos
// Codigo: 1014857569
// Grupo: 230

using NumberOrganizer;

class Program
{
    static void Main(string[] args)
    {
        PrintInfo menu = new PrintInfo();
        Methods methods = new Methods();
        List<int> numbers = menu.getInfoStart();
        //List<int> numbers = new List<int> { 5, 3, 9, 1, 10, 7, 2, 4, 6, 8 };

        int selection = menu.getSelectedMethod();
        
        // Manejamos el flujo del codigo dependiendo el metodo seleccionado
        switch (selection)
        {
            case 1: //Bubble Method
                List<int> resultado = methods.bubbleMethod(numbers);
                for (int i = 0; i < resultado.Count; i++)
                {
                    Console.WriteLine(resultado[i]);                    
                }
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }

    }
}