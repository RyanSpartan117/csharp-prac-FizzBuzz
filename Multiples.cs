using System;

namespace csharp
{
    class Multiples 
    {
        public Multiples()
        {
        }

        public bool checkMod(int num, int mod)
        {
            if(num % mod == 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}