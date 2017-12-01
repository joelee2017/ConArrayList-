using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //匯入Collections 命名空間

namespace ConArrayList集合陣列練習
{
    class Program
    {
        //
        // 摘要:
        //     公開能逐一查看非泛型集合內容一次的列舉程式。若要瀏覽此類型的.NET Framework 原始程式碼，請參閱 Reference Source。
        public static void  Printout(IEnumerable tarylst)//方法
        {
            int n = 1;
            foreach (object obj in tarylst)
            {
                Console.WriteLine($"第 {n} 個元素資料內容：{obj}");
                n++;
            }
        }


        static void Main(string[] args)
        {
            ArrayList arylst = new ArrayList();
            arylst.Add("alice");
            arylst.Add("bob");
            arylst.Add(168);
            arylst.Add(true);
            // ArrayList arylst = new ArrayList { "alice", "bob", 168,true }; //一行式寫法

            arylst.AddRange(new string[] { "david", "eric" });
            arylst.Insert(2, "jack");// 插到第3個元素處，原索引往後
            arylst.Add("ford");//插到陣列串列最後
            Console.WriteLine($"\n目前 arylist 可存放元素總容量：{arylst.Capacity}");


            int n = 1;
            foreach(object s in arylst)
            {
                Console.WriteLine($"第 {n} 元素資料內容：{s}");
                n++;
            }


            arylst.Remove("fored");// 移除"ford
            arylst.RemoveAt(2);//移除第3個元素，原索引往前
            arylst.RemoveRange(2, 3);//移除第3元素起，共3個元素
            Console.WriteLine($"\n 目前 arylist 可存放元素總容量 {arylst.Capacity}");
            Console.WriteLine($"\n 目前 arylist 內所有元素共計 {arylst.Count}");

            Printout(arylst);
            Console.WriteLine($"\n目前 arylist 可存放元素總容量：{arylst.Capacity}");
            Console.WriteLine($"已移除 arylist 內所有元素共計： {arylst.Count}");

            Console.Read();

        }
    }
}
