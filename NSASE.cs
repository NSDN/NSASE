using System;
using dotNSASM;

namespace NSASE
{
    class NSASE : NSASM
    {
        public NSASE(string[][] code) : base(2048, 1024, 64, code)
        {
        }

        protected override void LoadFunList()
        {
            base.LoadFunList();

        }
    }
}
