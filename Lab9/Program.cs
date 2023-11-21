using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueElements uniqueElements = new UniqueElements();
            string inputString = "avo go fe ff loplo like htyh shshss aaa";
            uniqueElements.AddInput(inputString);
            Console.WriteLine("\nInit uniqueElements:\n");
            Console.WriteLine(uniqueElements);
            Console.WriteLine("-------------------------------------");
            //анонимный метод
            HashSetManager.Sort(uniqueElements.UniqueElementsHashSet, delegate (string left, string right) {
                return string.Compare(left, right) > 0;
            });
            Console.WriteLine("\nuniqueElements after sort in ascending order :\n");
            Console.WriteLine(uniqueElements);
            Console.WriteLine("-------------------------------------");

            //лямда-выражение
            HashSetManager.Sort(uniqueElements.UniqueElementsHashSet, (string left, string right) => string.Compare(left, right) < 0);
            Console.WriteLine("\nuniqueElements after sort in descending order :\n");
            Console.WriteLine(uniqueElements);
            Console.WriteLine("-------------------------------------");

            //анонимный метод
            HashSet<string> filteredUniqueElements1 = HashSetManager.Filter(uniqueElements.UniqueElementsHashSet, "V",
                delegate (string left, string searchValue)
                {
                    return left.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                });
            Console.WriteLine("\nFilter in uniqueElements , searchValue =V\n");
            foreach (var element in filteredUniqueElements1)
            {
                Console.WriteLine(element + "\n");
            }
            Console.WriteLine("-------------------------------------");

            //лямда-выражение
            HashSet<string> filteredUniqueElements2 = HashSetManager.Filter(uniqueElements.UniqueElementsHashSet, "O",
                (string left, string searchValue) => left.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
            ;
            Console.WriteLine("\nFilter in uniqueElements , searchValue =O\n");
            foreach (var element in filteredUniqueElements2)
            {
                Console.WriteLine(element + "\n");
            }
        }
    }
}
