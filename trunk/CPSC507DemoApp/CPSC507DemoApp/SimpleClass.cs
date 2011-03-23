using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp
{
    public class SimpleClass {
        private ValInterface param;

        public SimpleClass(ValInterface param) {
            this.param = param;
        }

        public int getVal() {
            return this.param.getVal();
        }
    }
}
