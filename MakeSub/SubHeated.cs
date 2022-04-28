using System;
using System.Collections.Generic;
using System.Text;

namespace SubWay.MakeSub
{
    class SubHeated : SubWrapper
    {
        public SubHeated(ISub sub) : base(sub) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", heated";
        }

        public override float GetPrice()
        {
            return base.GetPrice() + 0.5f;
        }
    }
}
