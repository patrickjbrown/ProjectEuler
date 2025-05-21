using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public abstract class Problem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract string GetSolution();
    }
}
