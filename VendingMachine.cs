using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class VendingMachine
    {
        private int Battery { get; set; } = 10;
        public string[] Items { get; set; }
        public string CurrentItem { get; set; }

        public bool IsEntered { get; set; }
        public void LoadItems(string[] items)
        {
            Items = items;
        }

        public void ChooseItem(string item)
        {
            CurrentItem = item;
        }

        public void AddCoin(bool isEntered)
        {
            IsEntered = isEntered;          
            if (IsEntered == false)
            {                
                Console.WriteLine("\nEnter a coin!");
            }
            else Console.WriteLine("Client has entered a coin!");
        }       
        public void Action()
        {
            Battery -= 2;
            if (Battery >= 2)
            {
                if (IsEntered)
                {
                    Console.WriteLine("Client has entered a coin!");
                    if (Items.Contains(CurrentItem))
                    {
                        Console.WriteLine($"Vending machine is about to drop {CurrentItem}");
                    }
                    else Console.WriteLine($"Vending machine doesn't contain {CurrentItem}");
                }
                else Console.WriteLine("Enter a coin!");
            }
            else Console.WriteLine("\nBattery too low!");
        }
    }
}
