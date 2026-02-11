Console.Write("Nhap so ve tam ");
int soN = int.Parse(Console.ReadLine());
Console.Write("Nhap do rong ");
int dorong = int.Parse(Console.ReadLine());
int dodai = dorong;
//for (int i = 0; i<dodai; i++)
//{
//    for (int j = 0; j<i+1; j++)
//    {
//        Console.Write(soN);
//    }
//    Console.WriteLine();
//}
for (int i = 0; i < dodai; i++)
{
    for (int j = i; j < dorong; j++)
    {
        Console.Write(soN);
    }
    Console.WriteLine();
}