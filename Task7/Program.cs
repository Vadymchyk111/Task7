using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfCrystall = 5;
            int playerMoney;
            int playerCrystalls=0;
            int countOfCrystallsToBuy;

            Console.WriteLine("Введите количество денег");
            playerMoney = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество кристалов для покупки");
            countOfCrystallsToBuy = Int32.Parse(Console.ReadLine());
            if(playerMoney < priceOfCrystall * countOfCrystallsToBuy)
            {
                Console.WriteLine("У вас недостаточно денег");
                return;
            }
            else
            {
                playerMoney -= priceOfCrystall * countOfCrystallsToBuy;
                playerCrystalls += countOfCrystallsToBuy;
            }
            Console.WriteLine("У вас осталось " + playerMoney + " монет и "+ playerCrystalls + " кристаллов");
        }
    }
}
