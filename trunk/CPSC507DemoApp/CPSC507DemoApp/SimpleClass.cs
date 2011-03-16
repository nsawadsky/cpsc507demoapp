using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public interface ValInterface
    {
        int Val { get; }
    }

    public class ParamClass : ValInterface
    {
        private int val = 0;

        public ParamClass(int val) 
        {
            this.val = val;
        }

        public int Val 
        {
            get 
            {
                return this.val;
            }
        }
    }

    public class SimpleClass
    {
        private ValInterface param;

        public SimpleClass(ValInterface param)
        {
            this.param = param;
        }

        public int Val
        {
            get
            {
                return this.param.Val;
            }
        }
    }
}
