using System.Collections;

namespace SortedListEx
{
    class Program
    {

        public static void Printout(SortedList sl)
        {
            foreach (DictionaryEntry de in sl)
            {
                Console.Write("   Key = {0}\tValue = {1} \n", de.Key, de.Value);
            }
        }

        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            string name;
            int score;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("請輸入第{0}位同學姓名：", i + 1);
                name = Console.ReadLine();
                if (sortedList.ContainsKey(name))
                {
                    Console.WriteLine("{0}已存在，不能重複加入 ...", name);
                    Console.WriteLine("目前資料：");
                    Printout(sortedList);
                    i--;
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("請輸入成績：");
                    score = int.Parse(Console.ReadLine());
                    sortedList.Add(name, score);
                    Console.WriteLine("第{0}位資料已加入 ...", i + 1);
                    Console.WriteLine("目前資料：");
                    Printout(sortedList);
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}