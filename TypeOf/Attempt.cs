using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOf
{
    public class Attempt
    {
        public int Id { get; set; }
        public float Accuracy { get; set; }
        //public int Score { get; set; }

        public Attempt(int id, float accuracy)
        {
            Id = id;
            Accuracy = accuracy;
            //Score = score;
        }

        public override string ToString()
        {
            return $"{Id}: {Accuracy:F2}%";
        }
    }
}
