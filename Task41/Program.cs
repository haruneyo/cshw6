System.Console.WriteLine("Specify how many numbers to enter:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
FillArray(array);
System.Console.WriteLine($"The amount of numbers bigger than zero in the array is: {BiggerThanZero(array)}");
void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.WriteLine($"Enter the {i + 1} number:");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int BiggerThanZero(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0) count++;
    }
    return count;
}