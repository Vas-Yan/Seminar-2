// Задача из ЕГЭ-1
int[] CreateArray(int n)
{
    int[] a = new int[n];
    Random random = new Random();
    for (int i=0; i<a.Length; i++) a[i]=random.Next(0,101);
    return a;
}

void PrintArray(int[] a)
{
    for (int i=0; i<a.Length; i++) Console.WriteLine(a[i]+" ");
}
checked{
int [] arr = CreateArray(30);
PrintArray(arr);
Console.WriteLine();
long p=1;
for (int i=0; i<arr.Length; i++)
if (arr[i]%2==0 && arr[i]%10!=0) 
{
    p=p*arr[i];
}

Console.WriteLine();
Console.Write (p);
}