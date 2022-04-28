using System;
using System.Collections.Generic;
using System.Text;

namespace SubWay.MakeSub
{
    class SubWrapper : ISub
    {
        private ISub _sub;

        public SubWrapper(ISub sub)
        {
            _sub = sub;
        }

        public virtual string GetDescription()
        {
            return _sub.GetDescription();
        }

        public virtual float GetPrice()
        {
            return _sub.GetPrice();
        }
    }
}
