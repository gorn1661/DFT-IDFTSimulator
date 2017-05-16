using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFT_IDFTSimulator
{
    class transformations
    {
        private int n;
        private int fs;
        private int f;
        private int a;
        private int d;
        private string _sequence;

        public transformations(int n, int fs, int f, int a, int d, string _sequence)
        {
            this.n = n;
            this.fs = fs;
            this.f = f;
            this.a = a;
            this.d = d;
            this._sequence = _sequence;
        }
    }
}
