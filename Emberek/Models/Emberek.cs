using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek.Models
{
    public class Emberek
    {
        public Emberek() { }
        public Emberek(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public override string? ToString()
        {
            return $"{Name} - {Age} éves"; 
        }
    }
}
