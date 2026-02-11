//Console.Write("Username: ");
//string userName = Console.ReadLine();
//Console.Write("Password: ");
//string password = Console.ReadLine();

//string[] name = { "admin" };
//string[] pass = { "ThanhNhuxinhdep" };

//if (userName == name[0] && password == pass[0])
//{
//    Console.Write("Dang nhap thanh cong");
//}
//else if(userName != name[0])
//{
//    Console.Write("Sai ten đang nhap");
//}else if(password != pass[0])
//{
//    Console.Write("Sai mat khau");
//}
//else
//{
//    Console.Write("Đang nhap khong thanh cong");
//}

Console.Write("username: ");
string username = Console.ReadLine();
Console.Write("password: ");
string password = Console.ReadLine();

Dictionary<string, string> users = new Dictionary<string, string>()
{
    {"admin", "0372914" },
    {"nhu", "chinhuxinhdep" },
    {"user1", "abc123" }
};

if (users.TryGetValue(username, out string correctPassword))
{
    if (password == correctPassword)
    {
        Console.WriteLine("Dang nhap thanh cong");
    }
    else
    {
        Console.WriteLine("Sai mat khau");
    }
}
else
{
    Console.WriteLine("Username khong ton tai");
}



