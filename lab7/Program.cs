using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };

            var squares = nums.Where(n => n > 4).Select(n => n * n);

            Console.WriteLine("Binh phuong cua so lon ho 4:");
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }
            //-------------------------------------------
            string str = "chao mung den voi binh nguyen vo tan";

            var charCounts = str.Replace(" ", "")
                                .GroupBy(c => c)
                                .Select(g => new { Character = g.Key, Count = g.Count() });

            Console.WriteLine("so lan xuat hien cua tung chu:");
            foreach (var charCount in charCounts)
            {
                Console.WriteLine($"Chu '{charCount.Character}': {charCount.Count} lan");
            }
            //----------------------------------------------

            string str2 = "CHAO mung DEN Voi binh nguyen vo tan";

            var uppercaseWords = str2.Split(' ')
                                    .Where(word => word.All(char.IsUpper));

            Console.WriteLine("nhung chuoi duwocj viet ha toanf bo");
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }


        }
    }
}
