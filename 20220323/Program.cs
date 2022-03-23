using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220323
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] years = new string[60];
            string a = "甲乙丙丁戊己庚辛壬癸";
            string b = "子丑寅卯辰巳午未申酉戌亥";
            int x = 0;
            int y = 0;
            for (int i = 0; i < 60; i++)
            {
                years[i]=a[x].ToString() + b[y].ToString();
                if (++x >= a.Length) x = 0;
                if (++y >= b.Length) y = 0;
            }
            Console.WriteLine("請問你要問的是哪一個西元年:");
            int target = Convert.ToInt32(Console.ReadLine());
            int d = (target - 1984)%60;
            if (d<0)
            {
                
            }
            
            Console.Write("你輸入的{0}是{1}年",target,years[d>=0?d : d+60]);

            Console.ReadLine();
        }
    }
}

