using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

// special: [33 - 47], [58 - 64], [91 - 96], [123 - 126]
// numbers: 48 - 57
// upper: 65 - 90
// lower: 97 - 122

namespace PasswordGenerator
{
    internal class GetRandomPassword
    {
        public static string GetRandom(int length, int selection)
        {
            var random = new Random();
  
            string pw = "";

            for (int i = 0; i < length; i++)
            {
                int[] upperLower = { random.Next(65, 90), random.Next(97, 122) };
                int[] upperLowerNums = { random.Next(65, 90), random.Next(97, 122), random.Next(48, 57) };
                int[] upperLowerSpecs = { random.Next(65, 90), random.Next(97, 122), random.Next(33, 47), random.Next(58, 64), random.Next(91, 96), random.Next(123, 126) };
                int[] all = { random.Next(65, 90), random.Next(97, 122), random.Next(33, 47), random.Next(58, 64), random.Next(91, 96), random.Next(123, 126), random.Next(48, 57) };

                int[] choice;
                choice = selection switch
                {
                    1 => choice = upperLower,
                    2 => choice = upperLowerNums,
                    3 => choice = upperLowerSpecs,
                    4 => choice = all,
                    _ => throw new NotImplementedException()
                };

                pw += (char)choice[random.Next(0, choice.Length)];
            }

            return pw;
        }
    }
}
