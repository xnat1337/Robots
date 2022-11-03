using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class CleaningRobot
    {
        private int Battery { get; set; } = 10;
        public string Plan { get; set; }

        public string Mixture { get; set; }
        public void Action()
        {
            Battery -= 2;
            Console.WriteLine($"I robot start cleaning {Plan} room!");
            Console.WriteLine("Water container is mixed with " + Mixture);
            if (Battery <= 2)
            {
                SelfRecharge();
            }
                          
        }

        public void SetCleaningPlan(string plan)
        {
            Plan = plan;  
        }

        public void SetWaterCleaning(string mixture)
        {
            Mixture = mixture;
        }

        private void SelfRecharge()
        {
            Battery = 10;
            Console.WriteLine("\nReturning back to the docking station for self-recharge");
        }               
    }
}
