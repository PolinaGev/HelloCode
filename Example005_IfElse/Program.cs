Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "polina")
{
    Console.WriteLine("Ура, это же Polina!");    
}

else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}