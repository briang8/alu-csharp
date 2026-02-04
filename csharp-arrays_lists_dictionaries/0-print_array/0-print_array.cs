using system;
class array
{
    public static int?[] CreatePrint(int size)
    {
        if (size < 0)
        {
            console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            console.WriteLine();
            return new int[0];
        }
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            if (i < size - 1)
                console.Write(i + "");
            else
                console.Write(i);
        }
        return array;
    }
}
