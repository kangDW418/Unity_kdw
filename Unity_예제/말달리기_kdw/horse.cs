using System;
using System.Collections.Generic;
using System.Text;

namespace 말달리기_kdw
{
    class horse
    {

        public string name;
        public int distance;


        public int run(int before, int after)
        {
            int run = before;
            if (run < 200 && before != 0)
            {
                run = before + after;
            }
            return run;
        }

    }
}

