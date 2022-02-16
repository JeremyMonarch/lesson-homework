using System;
using System.Text;

namespace lesson7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string placeholder = "Hello {0} and {1}";
            string name = "Serhii";
            string hisName = "Alex";
            Console.WriteLine("Hello " + name);
            Console.WriteLine(string.Format("Hello {0}", name));
            Console.WriteLine(string.Format("Hello {0} and {1}", name, hisName));
            Console.WriteLine($"Hello {name} and {hisName}");
            Console.WriteLine(string.Format(placeholder, name, hisName));

            var hello = $"Hello, {name} and {hisName}";
            char symbol = hello[0];

            Console.WriteLine(symbol);
            Console.WriteLine(char.IsLetter(symbol));
            Console.WriteLine(char.IsDigit(symbol));
            Console.WriteLine(char.IsUpper(symbol));

            Console.WriteLine(hello.Contains("q"));
            Console.WriteLine(hello.Contains("hii"));
            Console.WriteLine(hello.EndsWith("lex"));
            Console.WriteLine(hello.StartsWith("lex"));

            var helloPlaceholder = "Hello ";
            var index = helloPlaceholder.IndexOf(' ');

            Console.WriteLine("Hello ".Insert(index + 1, name));
            Console.WriteLine($"Hello {name}".Replace(name, hisName));


            Console.WriteLine(hello.PadLeft(40));
            Console.WriteLine(hello.PadLeft(40).Trim());
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());

            Console.WriteLine(string.Compare("abc", "bdc"));
            Console.WriteLine(string.Equals("abc", "bdc"));
            Console.WriteLine(string.Compare("abc", "bdc"));
            Console.WriteLine("abc" == "bdc");

            Console.WriteLine("Hello " + name);

            var emptyString = string.Empty;
            
            const int N = 1000;
            int i = 0;
            for (i = 0; i < N; i++)
            {
                emptyString += $" {i}";
            }

            var stringBuilder = new StringBuilder();

            for (i = 0; i < N; i++)
            {
                stringBuilder.AppendFormat(" {0}", i);
            }

            Console.WriteLine(emptyString);
            Console.WriteLine(stringBuilder.ToString());


            // будь-яка строка з консолі. аппер ту лоувер і навпаки

           string str = Console.ReadLine();
            string str2 = "";
            for (i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    str2 += char.ToLower(str[i]);
                }

                else if (char.IsLower(str[i]))
                {
                    str2 += char.ToUpper(str[i]);
                }
            }

            Console.WriteLine(str2);

        }
    }
}
