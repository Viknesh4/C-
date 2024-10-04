using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Dict()
        {
            Dictionary<int, String> dic = new Dictionary<int, String>();
            dic.Add(1, "Harshitha");
            dic.Add(22, "Pinky");
            dic.Add(3, "Anuja");
            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (KeyValuePair<int, String> i in dic)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

        }

        static void Sortedlist()
        {
            SortedList<int, string> sortlist = new SortedList<int, string>();
            sortlist.Add(1, "Harshitha");
            sortlist.Add(22, "Pinky");
            sortlist.Add(3, "Anuja");
            sortlist.Add(5, "Anuja");
            sortlist.Add(4, null);
            foreach (KeyValuePair<int, string> i in sortlist)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }

        static void ListOper()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(1);
            //list.Add(null); 
            for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }
        }
        static void StackOper()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(42);
            stack.Push(43);
            stack.Push(45);
            stack.Push(42);
            //stack.Push(null); 
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        static void QueueOper()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue(null);
            queue.Enqueue("a");
            foreach (var item in queue) { Console.WriteLine(item); }
        }
        static void HashSetOper()
        {
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("a");
            set1.Add("b");
            set1.Add("c");
            set1.Add("d");
            HashSet<string> set2 = new HashSet<string>();
            set2.Add("a");
            set2.Add("e");
            set2.Add("f");
            set2.Add("d");
            set1.UnionWith(set2);
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }
            set1.IntersectWith(set2);
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }
            set1.ExceptWith(set2);
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }
        }
        static void LinkedListOper()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddFirst(4);
            list.AddAfter(list.Find(2), 5);
            list.AddBefore(list.Find(3), 6);
            foreach (int i in list) { Console.WriteLine(i); }
            Console.WriteLine();
            list.RemoveFirst();
            list.RemoveLast();
            foreach (int i in list) { Console.WriteLine(i); }
            Console.WriteLine("First Elemenet: " + list.First.Value);
            Console.WriteLine("Last Elemenet: " + list.Last.Value);
            int middle = list.ElementAt(list.Count() / 2);
            Console.WriteLine("Middle Element: " + middle);
        }
        static void StackFunc1()
        {
           
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Popped: " + stack.Pop());

            Console.WriteLine("Top element: " + stack.Peek());

            Console.WriteLine("Is stack empty: " + (stack.Count == 0));

        }
        static void StackFunc2()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);

            Stack<int> tempStack = new Stack<int>();
            while (stack.Count > 0)
            {
                int temp = stack.Pop();
                while (tempStack.Count > 0 && tempStack.Peek() < temp)
                {
                    stack.Push(tempStack.Pop());
                }

                tempStack.Push(temp);
            }
            Console.WriteLine("Stack sorted in descending order:");
            foreach (int item in tempStack)
            {
                Console.WriteLine(item);
            }
        }

        static void StackFunc3()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(40);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            int minElement = int.MaxValue;
            foreach (int item in stack)
            {
                if (item < minElement)
                {
                    minElement = item;
                }
            }

            Console.WriteLine("Minimum element: " + minElement);
        }

        static void StackFunc4()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(50);
            stack.Push(60);
            stack.Push(70);
            Console.WriteLine("Number of elements: " + stack.Count);
        }

        static void StackFunc5() 
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };
            set1.IntersectWith(set2);
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void ListOperations()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);

            Console.WriteLine("Original List:");
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            list.Remove(20);

            Console.WriteLine("\nList after removing value 20:");
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            list.RemoveAt(2);

            Console.WriteLine("\nList after removing item at index 2:");
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nFinal List:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void main(string[] args)
        {
            //HashSetOper();
            //LinkedListOper();
            //QueueOper();
            //StackOper();
            //Sortedlist();
            //Dict();
            //ListOper();
            //StackFunc1();
            //StackFunc2();
            //StackFunc3();
            //StackFunc4();
            //StackFunc5();
            ListOperations();
        }
    }
}
