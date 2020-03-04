using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    class Alligator
    {
        public bool IsAquatic { get; set; }
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }
        internal void Grunt ()
        {           
            if (IsAquatic)
            {
                Console.WriteLine("bubble bubble");
            }
            else
            {
                Console.WriteLine("Grrrrr!");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You ran {steps} steps.");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("You achieved your step goal!");
            }
        }
    }
}
