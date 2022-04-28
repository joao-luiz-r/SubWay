using System;
using System.Collections.Generic;
using System.Text;

namespace SubWay.MakeSub
{
    class SubShort : SubWrapper
    {
        public SubShort(ISub sub) : base(sub) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", half size";
        }

        public override float GetPrice()
        {
            return base.GetPrice() / 2f;
        }
    }
}
