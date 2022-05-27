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
            int playerCrystall=0;
            int countOfCrystallToBuy;

            Console.WriteLine("Введите количество денег");
            playerMoney = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество кристалов для покупки");
            countOfCrystallToBuy = Int32.Parse(Console.ReadLine());
            if(playerMoney < priceOfCrystall * countOfCrystallToBuy)
            {
                Console.WriteLine("У вас недостаточно денег");
                return;
            }
            else
            {
                playerMoney -= priceOfCrystall * countOfCrystallToBuy;
                playerCrystall += countOfCrystallToBuy;
            }
            Console.WriteLine("У вас осталось " + playerMoney + " монет и "+ playerCrystall+" кристаллов");
           
        }
    }
}
