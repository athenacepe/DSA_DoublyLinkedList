using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_DLL2
{
    class DLL
    {
        public int length;
        public DLLNode head;
        public DLLNode tail;

        public DLL()
        {
            head = null;
            tail = null;
        }

        public void addNode(DLLNode newNode)
        {
            if (tail == null)
            {
                tail = newNode;
                head = newNode;
                length++;
                return;
            }
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }

        public int getMid()
        {
            DLLNode slowPointer = head;
            DLLNode fastPointer = head;

            if (head != null)
            {
                while (fastPointer != null && fastPointer.next != null)
                {
                    fastPointer = fastPointer.next.next;
                    slowPointer = slowPointer.next;
                }
                return slowPointer.num;
            }
            return slowPointer.num;
        }

        public void displayPrime()
        {
            DLLNode current = head;
            int counter = 0;
            while (current != null)
            {
                if (CheckPrime(current.num))
                {
                    Console.Write(current.num + " ");
                    counter++;
                    if (counter == 5)
                    {
                        Console.WriteLine(Environment.NewLine);
                        counter = 0;
                    }
                }
                current = current.next;
            }
        }

        public Boolean CheckPrime(int num)
        {
            Boolean prime = true;

            if (!(num <= 1))
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if ((num % i) == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                return prime;
            }
            return false;
        }
    }
}