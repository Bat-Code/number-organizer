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
    
    public List<int> shellMethod(List<int> numberList)
    {
        List<int> list = new List<int>(numberList);
        int n = list.Count;
        int gap = n / 2;

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = list[i];
                int j = i;

                while (j >= gap && list[j - gap] > temp)
                {
                    list[j] = list[j - gap];
                    j -= gap;
                }
                list[j] = temp;
            }
            gap /= 2;
        }
        return list;
    }

    public List<int> selectionMethod(List<int> numberList)
    {
        List<int> list = new List<int>(numberList);
        int min, temporal;

        for (int i = 0; i < list.Count; i++)
        {
            min = i;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j] < list[min])
                {
                    min = j;
                }
            }

            temporal = list[i];
            list[i] = list[min];
            list[min] = temporal;
        }

        return list;
    }

    public List<int> insertMethod(List<int> numberList)
    {
        List<int> list = new List<int>(numberList);
        int position, temporal;
        
        for (int i = 0; i < list.Count; i++)
        {
            position = i;
            temporal = list[i];

            while (position > 0 && list[position - 1] > temporal)
            {
                list[position] = list[position - 1];
                position--;
            }

            list[position] = temporal;
        }

        return list;

    }
}