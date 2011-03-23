using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC507DemoApp {
    public class ParamClass : ValInterface {
        private int val = 0;

        public ParamClass(int val) {
            this.val = val;
        }

        public int getVal() {
            return this.val;
        }
    }

}
