namespace NumberOrganizer;

public class Methods
{
    public List<int> bubbleMethod(List<int> numberList)
    {
        List<int> list = new List<int>(numberList);
        int temp;

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                if (list[j] > list[j + 1])
                {
                    temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        return list;
    }
    
}