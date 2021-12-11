using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuecsh
{
    public class Class1
    {
        public class Queue
        {
            LinkedList<int> queue;
            public Queue()
            {
                queue = new LinkedList<int>();
            }
            public void Enqueue(int val)
            {
                queue.AddLast(val);
            }
            public int Dequeue()
            {
                if (queue.Count == 0)return 0;
                int tmp = queue.First.Value;
                queue.RemoveFirst();
                return tmp;
            }
            public int Peek()
            {
                if (queue.Count<=0)return 0;
                int tmp = queue.First.Value;
                return tmp;
            }
            public int GetCount()
            {
                return queue.Count;
            }

        }

    }
}
    

