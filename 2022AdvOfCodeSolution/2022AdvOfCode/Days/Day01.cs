using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022AdvOfCode.Days
{
    public class Day01 : AdventDay
    {
        public List<List<int>> Inventories { get; set; }

        public Day01(string inputFile) : base(inputFile)
        {
            GetInventories();
        }

        public int GetAnswerPart1()
        {           
            int maxCalories = Inventories.Max(x => x.Sum());
            return maxCalories;
        }

        public int GetAnswerPart2()
        {
            int sumOfTopThree = Inventories.
                OrderByDescending(x => x.Sum()).
                Take(3).
                Sum(x => x.Sum());

            return sumOfTopThree;
        }

        public void GetInventories()
        {
            Inventories = new List<List<int>>();
            List<int> inventory = new List<int>();

            foreach (var number in FileContent)
            {
                if (int.TryParse(number, out int calories))
                {
                    inventory.Add(calories);
                }
                else
                {
                    Inventories.Add(new List<int>(inventory));
                    inventory.Clear();
                }
            }

            Inventories.Add(new List<int>(inventory));
        }
    }

}
