using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public interface IDay
    {
        public string input { get; }
        public string example { get; }
        public string Run(bool UseInput = true);
        public string Run2(bool UseInput = true);
    }
}
