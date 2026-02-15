
Console.Write("Nhap mot so thap phan: ");
int a = int.Parse(Console.ReadLine());
string ketqua = "";
do
{
    if (a % 2 == 1)
    {
        ketqua += "1";
    }
    else if (a%2 == 0)
    {
        ketqua += "0";
    }
    a = a / 2;
} while (a != 0);

char[] daochuoi = ketqua.ToCharArray();
for (int i= daochuoi.Length -1; i>=0; i--)
{
    Console.Write(daochuoi[i]);
}
