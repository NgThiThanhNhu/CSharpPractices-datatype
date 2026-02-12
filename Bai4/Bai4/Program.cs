string username, password;
Dictionary<string, string> users = new Dictionary<string, string>()
{
    {"ThanhNhu", "chinhudep" },
    {"user1", "123abc" }
};

int n = 0;
do
{
    Console.Write("username: ");
    username = Console.ReadLine();
    Console.Write("password: ");
    password = Console.ReadLine();
    if (users.TryGetValue(username, out string correctPassword))
    {
        if (password == correctPassword)
        {
            Console.WriteLine("Dang nhap thanh cong");
            break;
        }
        else
        {
            Console.WriteLine("Sai mat khau");
            if (n==2)
            {
                Console.WriteLine("Nhap sai thong tin qua 3 lan");
            }
        }
    }
    else
    {
        Console.WriteLine("Sai ten nguoi dung");
        if (n==2)
        {
            Console.WriteLine("Nhap sai thong tin qua 3 lan");
        }
    }
    n++;
} while (n<3);