using System;
using System.Collections.Generic;

namespace MergingIntoOneCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArray1 = { "Привет", "Stas", "Мир", "C#", "Stas", "Разработчик игр" };
            string[] textArray2 = { "Hello", "Стас", "Мир", "C#", "Программист", "Игры", "C#", "Игры" };
            List<string> textsList = new List<string>();

            for (int i = 0; i < textArray1.Length; i++)
            {
                if (textsList.Contains(textArray1[i]) == false)
                {
                    textsList.Add(textArray1[i]);
                }
            }

            for (int i = 0; i < textArray2.Length; i++)
            {
                if (textsList.Contains(textArray2[i]) == false)
                {
                    textsList.Add(textArray2[i]);
                }
            }

            foreach (string text in textsList)
            {
                Console.WriteLine(text);
            }
        }
    }
}