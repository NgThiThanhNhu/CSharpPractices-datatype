Console.Write("Nhap quang duong: ");
float s = float.Parse(Console.ReadLine());
Console.Write("Nhap thoi gian: ");
float t = float.Parse(Console.ReadLine());

Console.WriteLine($"Van toc la {(s / t):F3} m/s");

Console.WriteLine($"Van toc la {((s / t) * 3.6):F3} km/h");
Console.WriteLine($"Van toc la {((s / t) * 2.237):F3} miles/h");