// Нахождение максимального из трех 

int a = -70;
int b = -200;
int c = 45;

int max = a;


{
    if (b>max) max = b;
    if (c>max) max = c; 
    
}

Console.WriteLine(max);

// Второй вариант

int max( int a, int b, int c)
{
    if (a>b)
    if (a>c) return a;
 if (c>b) return c; else return b;
}

Console.WriteLine(max(32,-250,27));