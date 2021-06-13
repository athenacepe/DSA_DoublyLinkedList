using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_DLL2
{
    public class DLLNode
    {
        public int num;
        public DLLNode prev;
        public DLLNode next;

        public DLLNode(int num)
        {
            next = null;
            prev = null;
            this.num = num;
        }
    }
}
