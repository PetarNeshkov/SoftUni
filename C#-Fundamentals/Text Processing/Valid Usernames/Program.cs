using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var user in usernames)
            {
                if (user.Length >= 3 && user.Length < 16)
                {
                    bool check = true;
                    for (int k = 0; k < user.Length; k++)
                    {
                        if (!(char.IsLetterOrDigit(user[k]) || user[k] == '_'
                            || user[k] == '-'))
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        Console.WriteLine(user);
                    }
                }

            }
        }
    }
}
