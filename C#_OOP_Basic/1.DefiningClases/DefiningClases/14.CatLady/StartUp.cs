using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Cat> cats = new HashSet<Cat>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Cat cat = null;
                if (tokens[0]== "StreetExtraordinaire")
                {
                    cat = new StreetExtraordinaire(tokens[1], int.Parse(tokens[2]));
                }
                else if (tokens[0] == "Siamese")
                {
                    cat = new Siames(tokens[1], int.Parse(tokens[2]));
                }
                else if (tokens[0] == "Cymric")
                {
                    cat = new Cymric(tokens[1], decimal.Parse(tokens[2]));
                }

                cats.Add(cat);
                inputLine = Console.ReadLine();
            }

            string cmd = Console.ReadLine();

            var desiredCat = cats.FirstOrDefault(c => c.Name == cmd).ToString().Trim();
            Console.WriteLine(desiredCat);
        }
    }
}
