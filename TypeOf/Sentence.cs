using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TypeOf
{
    internal class Sentence
    {
        public Sentence() { }

        public int id {  get; set; }
        public string difficulty { get; set; }
        public string text { get; set; }
        public int length { get; set; }

        public Sentence(int id, string difficulty, string text, int length)
        {
            this.id = id;
            this.difficulty = difficulty;
            this.text = text;
            this.length = length;
        }
    }
}
