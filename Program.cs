using System;
using System.IO;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 3
            //Доработайте программу из задания 1, используя ваш метод из задания 2.

            //При запуске программа должна:
            // 1. Показать, сколько весит папка до очистки. Использовать метод из задания 2. 
            // 2. Выполнить очистку.
            // 3. Показать сколько файлов удалено и сколько места освобождено.
            // 4. Показать, сколько папка весит после очистки.

            string link = @"C:\test\";
            Folder folder = new Folder(link);
            folder.FolderClean30min(folder.path);
        }
    }
}


    