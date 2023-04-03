using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp81
{
    public  class Sort
    {
        public int Comparison = 0;
        public int NumberOfPermutations = 0;
        public int TimeSort = 0;
        public int Volume = 0;
        public string Time = "";
        public IStrategy Strategy;
        public string NameSortingMethod;

        public Sort(int Comparison, int NumberOfPermutations, string Time, IStrategy Strategy, int TimeSort, int Volume)
        {
            this.Comparison = Comparison;
            this.NumberOfPermutations = NumberOfPermutations;
            this.Time = Time;
            this.Strategy = Strategy;
            if (Strategy.GetType() == (new BubbleSort()).GetType())
            {
                this.NameSortingMethod = "Метод вставок";
            }
            else
            {
                this.NameSortingMethod = "Метод Шелла";
            }
            this.TimeSort = TimeSort;
            this.Volume = Volume;
        }
    }
}

