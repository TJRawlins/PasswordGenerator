using PasswordGenerator;
using System.Collections.Generic;

var start = true;
while (start)
{
    Console.Write("Select password length between 8 and 20: ");
    var length = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (length > 0 && length < 21)
    {
        while(true)
        {
            Console.Write("----------------- " +
                        "\nWHAT TO INCLUDE " +
                        "\n----------------- " +
                        "\n1: Uppercase + Lowercase" +
                        "\n2: Include Numbers" +
                        "\n3: Inlcude Special Characters" +
                        "\n4: Include Everything" +
                        "\nMake a selection: ");
            var selection = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (selection > 0 && selection < 5)
            {
                var password = GetRandomPassword.GetRandom(length, selection).ToString();
                Console.WriteLine();
                Console.WriteLine($"Password: {password}");
                start = false;
                break;
            }else
            {
                continue;
            }
        }
    }else
    {
        continue;
    }

}