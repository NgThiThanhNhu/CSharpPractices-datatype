Console.Write("Nhap mot ky tu bat ki: ");
char kt = char.Parse(Console.ReadLine());

if (kt == 'a' || kt == 'o' || kt == 'e' || kt == 'u' || kt == 'i')
{
    Console.WriteLine("ky tu vua nhap la nguyen am");
}else if (kt >= '0' && kt <= '9')
{
    Console.WriteLine("ky tu vua nhap la chu so");
}
else
{
    Console.WriteLine("Ky tu vua nhap khong phai la nguyen am cung khong phai chu so");
}
