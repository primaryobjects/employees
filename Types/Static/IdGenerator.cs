using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Types.Static
{
    public static class IdGenerator
    {
        private static int _id = 1000;

        public static int GenerateId()
        {
            return _id++;
        }
    }
}