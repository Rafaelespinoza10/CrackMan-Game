using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman_2
{
    public class Result
    {
        private bool dir;
        private bool delta;

        public Result(bool dir ,  bool  delta)
        {
            this.dir = dir;
            this.delta = delta;
        }
        public bool Dir { get => dir; set => dir = value; }
        public bool Delta { get => delta; set => delta = value; }
        
    }
}
