Console.Write("Nhap ban kinh R: ");
double R = double.Parse(Console.ReadLine());
double Pi = 3.14;
Console.WriteLine($"Dien tich hinh cau: {(4 * Pi * (R * R)):F3}");
Console.WriteLine($"The tich hinh cau: {(4 / 3 * Pi * (R * R * R)):F3}");
