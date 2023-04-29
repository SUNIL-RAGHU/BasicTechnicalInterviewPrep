using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ss = new();

            ss.push(10);
            ss.push(20);
            ss.push(30);
            int a = ss.peek();
            Console.WriteLine("The peek Value of stack is {0}", a);

            Console.WriteLine("The pop Value of Stack is {0}", ss.pop());

            Console.WriteLine("The count Value of Stack is {0}", ss.count());

            StackUsingQueue<int> suq = new();

            suq.push(10);
            suq.push(20);
            suq.push(30);
            int ass = suq.peek();
            Console.WriteLine("The peek Value of stackusingQueue is {0}", ass);

            Console.WriteLine("The pop Value of stackusingQueue is {0}", suq.pop());

            Console.WriteLine("The count Value of stackusingQueue is {0}", suq.count());

            queue<int> qs = new();
            qs.Enqueue(10);
            qs.Enqueue(20);
            qs.Enqueue(30);

            int qss = qs.Peek();

            Console.WriteLine("The peek Value of Queue is {0}", qss);

            Console.WriteLine("The pop Value of Queue is {0}", qs.Dequeue());

            Console.WriteLine("The count Value of Queue is {0}", qs.Count());

            QueueusingStack<int> qus = new();
            qus.Enqueue(10);
            qus.Enqueue(20);
            qus.Enqueue(30);

            int quss = qs.Peek();

            Console.WriteLine("The peek Value of Queue is {0}", quss);

            Console.WriteLine("The pop Value of Queue is {0}", qus.Dequeue());

            Console.WriteLine("The count Value of Queue is {0}", qus.Count());

            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.Insert(3, 7);
            list.RemoveFirst();

            list.RemoveLast();
            list.RemoveAt(2);

            bool containsValue = list.Contains(4);

            int valueAtIndex = list[1];

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            bool cycle=list.Cycle();

            if (cycle)
            {
              Console.WriteLine("LinkedList cycle");
            }
            else
            {
              Console.WriteLine("LinkedList cycle is Not present");
            }
            list.Clear();
           Console.WriteLine("Node count: " + list.Count);
        }
    }

    class Stack<T>
    {

        private List<T> ls;

        public Stack()
        {
            ls = new List<T>();
        }

        public void push(T item)
        {
            ls.Add(item);
        }

        public T pop()
        {

            if (ls.Count < 0)
            {
                throw new InvalidOperationException("Your stack Is Empty");
            }
            T temp = ls[ls.Count - 1];

            ls.Remove(ls[ls.Count - 1]);

            return temp;
        }

        public int count()
        {
            return ls.Count;
        }

        public T peek()
        {
            if (ls.Count < 0)
            {
                throw new InvalidOperationException("Your Stack is Empty");
            }
            return ls[ls.Count - 1];
        }

    }

    class StackUsingQueue<T>
    {
        private Queue<T> q1;
        private Queue<T> q2;

        public StackUsingQueue()
        {
            q1 = new();
            q2 = new();
        }

        public void push(T item)
        {
            q2.Enqueue(item);

            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            Queue<T> temp = q1;
            q1 = q2;
            q2 = temp;

        }

        public T peek()
        {
            if (q1.Count < 0)
            {

                throw new InvalidOperationException("Stack is Empty");
            }
            return q1.Peek();
        }

        public int count()
        {
            return q1.Count;
        }

        public T pop()
        {
            if (q1.Count < 0)
            {

                throw new InvalidOperationException("Stack is Empty");
            }
            return q1.Dequeue();

        }

    

    }

    class QueueusingStack<T>
    {
        private Stack<T> s1;
        private Stack<T> s2;

      public QueueusingStack()
        {
            s1 = new();
            s2 = new();
        }

      public  void Enqueue(T item)
        {
            s1.push(item);
        }

       public int Count()
        {
           return s1.count();
        }

       public T Dequeue()
        {

            while (s1.count() > 1)
            {
                s2.push(s1.pop());
            }

            T item = s2.pop();

            while (s2.count() > 0)
            {
                s1.push(s2.pop());
            }

            return item;

        }


      public  T Peek()
        {

            while (s1.count() > 1)
            {
                s2.push(s1.pop());
            }

            T item = s2.peek();

            while (s2.count() > 0)
            {
                s1.push(s2.pop());
            }

            return item;

        }



    }


    class queue<T>
    {
        List<T> qs = new();

        public queue()
        {
            qs = new();
        }

        public void Enqueue(T item)
        {

            qs.Add(item);
        }

        public int Count()
        {
            return qs.Count;
        }

        public T Dequeue()
        {
            if (qs.Count < 0)
            {

                throw new InvalidOperationException("Queue is Empty");
            }
            T temp = qs[0];
            qs.Remove(qs[0]);

            return temp;
        }

        public T Peek()
        {

            if (qs.Count < 0)
            {

                throw new InvalidOperationException("queue is Empty");
            }
            T temp = qs[0];
      
            return temp;
        }


    }


    public class LinkedList<T>
    {
        private class Node<T>
        {


            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                this.Value = value;
                Next = null;
            }
        }

        private Node<T> head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }
      

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = head;
            head = newNode;
            count++;

        }

        public void AddLast(T value)
        {

            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
               
            }
            count++;
        }


        public bool Cycle()
        {
            Node<T> fast = head;
            Node<T> slow = head;
            while (slow.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
        public void Reverse()
        {
            Node<T> temp = head;
            Node<T> prev = null;
            Node<T> next = head.Next;

            while (temp!= null)
            {
                prev.Next = temp;
                temp = prev;
                prev = next;

                while (temp!= null) {

                    next = next.Next;
                }

            }

            head = prev;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (index == 0)
            {
                AddFirst(value);
            }

            if (index == count)
            {
                AddLast(value);
            }

            else {
                Node<T> newNode = new Node<T>(value);

                Node<T> temp = head;
                for(int i = 0; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                newNode.Next = temp.Next;
                temp.Next = newNode;

                count++;

            }
        }

        public bool RemoveFirst()
        {

            if (head == null)
            {
                return false;
            }

            head = head.Next;
            count--;
            return true;
        }

        public bool RemoveLast()
        {
           

            if (head == null)
            {
                return false;
            }

            if (head.Next == null)
            {
                head = null;
            }

            else
            {
                Node<T> temp = head;
                while (temp.Next.Next != null) {

                    temp = temp.Next;

                }
                temp.Next = null;
               
            }
            count--;
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (index == 0)
            {
                return RemoveFirst();
            }
            else if (index == count - 1)
            {
                return RemoveLast();
            }
            else
            {

                Node<T> temp = head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                temp.Next = temp.Next.Next;
                count--;
                return true;
               
            }
        }

        public bool Contains(T value)
        {
          

            Node<T> temp = head;

            while (temp.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(value, temp.Value){
                    return true;
                }
                temp = temp.Next;

            }

            return false;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                Node<T> temp = head;

                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                return temp.Value;
            }
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

       
    }
}
