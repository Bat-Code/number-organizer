using System.Diagnostics;

namespace NumberOrganizer;

public class CreateFile : PrintInfo
{
    private static String actualAdress = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    
    // Buscar todos los archivos que comiencen con "Result" en el directorio actual
    private static String[] files = Directory.GetFiles(actualAdress, "Result*.txt");

    // Encontrar el número más alto de archivo
    private static int maxNumber = files.Select(Path.GetFileNameWithoutExtension)
        .Select(nombre => int.TryParse(nombre.Replace("Result", ""), out int numero) ? numero : -1)
        .DefaultIfEmpty(-1)
        .Max();


    private static String nameFile = $"Result {maxNumber + 1}.txt";
    private String fileAdress = Path.Combine(actualAdress, nameFile);

    public void createNewFile(int selection, List<int> oldList, List<int> newList)
    {
        using (StreamWriter writer = File.CreateText(fileAdress))
        {
            writer.WriteLine(ico + "\n");
            String methodSelected = methodSelectedWord(selection);
            writer.WriteLine($"\n You selected the " + methodSelected +" Method then the numbers you inserted were:");
            writer.WriteLine("(" + string.Join(",", oldList) + ")");
            writer.WriteLine("\n Now the organized list is: ");
            writer.WriteLine("(" + string.Join(",", newList) + ")");
        }
    }
}