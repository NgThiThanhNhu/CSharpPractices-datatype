

char[] arr = new char[3];
for (int i=0; i<3; i++)
{
    Console.WriteLine($"Nhap phan tu thu {i}");
    arr[i] = char.Parse( Console.ReadLine() );
}

Console.WriteLine("Chieu nguoc lai la");
for (int i=2; i>=0; i--)
{
    Console.WriteLine(arr[i]);
}

