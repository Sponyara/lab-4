using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<string>();
            var list2 = new List<string>();
            List<string>.Date date1 = new List<string>.Date();  //date
            list1.Add("1Первый");
            list1.Add("1Второй");
            list1.Add("1Третий");
            list2.Add("2Первый");
            list2.Add("2Второй");
            list2.Add("2Третий");
            //list2.Add("1Первый");
            //list2.Add("1Второй");
            //list2.Add("1Третий");
            var list3 = new List<string>();
            //list1 = list1 + list2; /////Объединение
            bool check = list1 == list2; ////Проверка на равенство
            Console.WriteLine("Первый список:");
            Print(list1);
            Console.WriteLine(" \nВторой список:");
            Print(list2);
            Console.WriteLine(check);
            Console.WriteLine(date1.date);
            Console.WriteLine("Всего элементов");
            Console.WriteLine(StatisticOperation.Counter(list1)); //подсчёт элементов /////////////приколы со статической функцией
            var list3int = new List<int>();
            list3int.Add(1);
            list3int.Add(2);
            list3int.Add(3);
            list3int.Add(22);
            list3int.Add(4);
            list3int.Add(5);
            Console.WriteLine(" \nТретий список(int):");
            StatisticOperation.Delete(list3int, 22);
            Print(list3int);
            Console.WriteLine(" \nСумма элементов в 3ем списке:");
            Console.WriteLine(StatisticOperation.SumAll(list3int));  ///вывод суммы всех элементов из списка
            Console.WriteLine(" \nРазница между максимальным и минимальным элементами в 3ем списке:");
            Console.WriteLine(StatisticOperation.MaxElem(list3int)); /// Разница между максимальным и минимальным элементами в 3ем списке   ///////////////////приколы прямо до сюда
            string str = "12345249ffgdfg";
            Console.WriteLine("\n" + StatisticOperation.Last_num_in_string(str));
            Console.ReadLine();
        }
        static void Print(List<string> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + "->");
                node = node.Next;
            }
            Console.WriteLine();
        }
        static void Print(List<int> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + "->");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
