using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOf
{
    public class Attempt
    { 
        public string Name { get; set; }
        public int Accuracy { get; set; }
        public int Score { get; set; }

        public Attempt(string name, int accuracy, int score)
        {
            Name = name;
            Accuracy = accuracy;
            Score = score;
        }


    }
}
