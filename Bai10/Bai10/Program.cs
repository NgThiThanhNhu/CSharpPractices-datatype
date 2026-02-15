Console.Write("Nhap so a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Nhap so b: ");
int b = int.Parse(Console.ReadLine());

bool ketqua = ((a % 2 == 0)&&(b % 2 == 0)) ? true : false;
Console.WriteLine((ketqua) ? "Ca hai deu la so chan" : "Hai so khong deu la so le");
