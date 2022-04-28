using System;
using System.Collections.Generic;
using System.Text;

namespace SubWay.MakeSub
{
    class SubAddCheese : SubWrapper
    {
        public SubAddCheese(ISub sub) : base(sub) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with Cheese";
        }

        public override float GetPrice()
        {
            return base.GetPrice() + 2f;
        }
    }
}
