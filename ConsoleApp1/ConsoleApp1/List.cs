using System;
using System.Net.Http.Headers;

namespace Lab4
{
    public class List<T> where T : IComparable
    {
        public Item<T> head;
        private Item<T> tail;
        private int count;
        public class Owner
        {
            public int ID;
            public string name;
            public string organisation;
            public Owner()
            {
                ID = 0;
                name = null;
                organisation = null;
            }
             Owner ViKtOrSiLiN = new Owner();
        }
        public class Date
        {
            public DateTime date = DateTime.Now;
            public Date()
            {

            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public Item<T> First
        {
            get
            {
                return head;
            }
        }
        public void AddAfter(Item<T> node, T value)
        {
            Item<T> newNode = new Item<T>(value, node.Next);
            node.Next = newNode;

            count++;
        }
        public void Add(T value)
        {
            if (head == null)
            {
                head = tail = new Item<T>(value, null);
                count++;
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.Next;
                count++;
            }
        }
        public Item<T> Find(T value)
        {
            Item<T> ptr = head;
            while (ptr != null)
            {
                if (ptr.Value.CompareTo(value) == 0)
                    return ptr;
                ptr = ptr.Next;
            }
            return null;
        }

        public static List<T> operator  --(List<T> list) //перегрузка удаления
        {
            if (list == null)
            {
                throw new InvalidOperationException("Список пуст");
            }
            var node1 = list.head;
            list.head = null;
            list.head = node1.Next;
            return list;
        }
        public static List<T> operator +(List<T> list1, List<T> list2) //перегрузка сложения 
        {
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null)
            {
                node1 = node1.Next;
                if (node1.Next == null)
                {
                    node1.Next = node2;
                    break;
                }
            }
            return list1;
        }
        public static bool operator ==(List<T> list1, List<T> list2) //перегрузка на равность
        {
            bool check = false;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 1)
                {
                    check = true;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
        public static bool operator !=(List<T> list1, List<T> list2) //Перегрузка на неравность
        {
            bool check = true;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 1)
                {
                    check = false;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
    }
    public static class StatisticOperation ////////////////////////статический класс с 3мя фциями(пока что...)
    {
        public static int Counter(List<string> list)
        {
            int count = 0;
            var node = list.First;
            while (node != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }
        public static int SumAll(List<int> list)
        {
            int summ = 0;
            var node = list.First;
            while (node != null)
            {
                summ = summ + node.Value;
                node = node.Next;
            }
            return summ;
        }
        public static int MaxElem(List<int> list)
        {
            int max = 0;
            var node = list.First;
            int min = node.Value;
            while (node != null)
            {
                if (max < node.Value)
                {
                    max = node.Value;
                }
                if (min > node.Value)
                {
                    min = node.Value;
                }

                node = node.Next;
            }
            max = max - min;
            return max;
        }
      
        public static char Last_num_in_string(this string str1)
        {
            char g = ' ';
            int i = 0;
            while (i + 1 <= str1.Length)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (str1[i].ToString() == j.ToString())
                    {
                        g = str1[i];
                    }
                }
                i++;
            }
            return g;
        }

        public static void Delete(this List<int> list, int value)
        {
            if(list.head != null)
            {

                if (list.head.Value.Equals(value))
                {
                    list.head = list.head.Next;
                    return;
                }

                var current = list.head.Next;
                var previous = list.head;

                while(current != null)
                {
                    if(current.Value.Equals(value))
                    {
                        previous.Next = current.Next;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }

        }
    }
}
