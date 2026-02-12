int a, b;
char kytu;
do
{
    Console.Write("Nhap so thu nhat: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Nhap phep toan + - * /: ");
    kytu = char.Parse(Console.ReadLine());
    Console.Write("Nhap so thu hai: ");
    b = int.Parse(Console.ReadLine());

    if (kytu == '+')
    {
        Console.WriteLine($"Ket qua la: {a + b}");
        break;
    }
    else if (kytu == '-')
    {
        Console.WriteLine($"Ket qua la: {a - b}");
        break;
    }
    else if (kytu == '*')
    {
        Console.WriteLine($"Ket qua la: {a * b}");
        break;
    }
    else if (kytu == '/')
    {
        Console.WriteLine($"Ket qua la: {(float)a / b}");
        break;
    }
    else
    {
        Console.WriteLine("Vui long chi nhap + - * /");
    }
} while (kytu != '+' || kytu != '-' || kytu != '*' || kytu != '/');





