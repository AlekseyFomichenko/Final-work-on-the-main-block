void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != "") Console.WriteLine(array[i]);
    }
}

string[] GetNewArray(string[] ar)
{
    if (ar == null || ar.Length == 0) return null;
    else
    {
        string[] newArray = new string[ar.Length];
        int current = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i] == null) continue;
            if (ar[i].Length <= 3)
            {
                newArray[current] = ar[i];
                current++;
            }
        }
        return newArray;
    }
}
string[] array1 = { "jih", "", "dg", "  ", "sqb", "qresds" };