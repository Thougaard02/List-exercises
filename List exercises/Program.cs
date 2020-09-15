using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_exercises
{
    class Program
    {
        static List<Person> nameList;
        static void Main(string[] args)
        {
            nameList = new List<Person>();
            Console.WriteLine("Chose a name");
            string UserInputName = Console.ReadLine();

            Console.WriteLine("How many names!");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Remove a number!");
            string SortUserInput = Console.ReadLine();

            CountNames(UserInputName, userInput);
            SortNumber(SortUserInput);

            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i].Name);
            }
            Console.ReadKey();
        }

        public static void CountNames(string name, int lenght)
        {
            for (int i = 0; i <= lenght; i++)
            {
                nameList.Add(new Person(name, i));                
            }
        }

        public static void SortNumber(string number)
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].Name.Contains(number))
                {
                    nameList.RemoveAt(i);
                }
            }
        }
        
    }

}
