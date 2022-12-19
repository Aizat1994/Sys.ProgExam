using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class Rega
    {
        private static async void AddNewKey()
        {
            Console.WriteLine("Введите имя нового ключа: ");
            string newKeyName = Console.ReadLine();
            if (string.IsNullOrEmpty(newKeyName)) { return; }
            RegistryKey currentUser = Registry.CurrentUser;
            RegistryKey newKey = currentUser.CreateSubKey(newKeyName);
            newKey.Close();
            currentUser.Close();
        }
        private static async void AddNewKeyToKey()
        {
            Console.WriteLine("Введите имя ключа в котором нужно создать новый ключ:");
            string firstKey = Console.ReadLine();
            if (string.IsNullOrEmpty(firstKey)) { return; }
            RegistryKey currentUser = Registry.CurrentUser;
            RegistryKey key = currentUser.OpenSubKey(firstKey, true);
            if (key == null) { return; }
            Console.WriteLine("Введите имя нового ключа: ");
            string newKey = Console.ReadLine();
            if (string.IsNullOrEmpty(newKey)) { return; }

            RegistryKey nKey = key.CreateSubKey(newKey);
            nKey.Close();
            key.Close();
            currentUser.Close();

        }
       
        private static async void RemoveKey()
        {
            Console.WriteLine("Введите имя ключа для удаления: ");
            RegistryKey currentUser = Registry.CurrentUser;
            string deleteName = Console.ReadLine();
            if (string.IsNullOrEmpty(deleteName)) { return; }
            currentUser.DeleteSubKeyTree(deleteName);
            currentUser.Close();
        }

        public static async void Menu()
        {
            Console.WriteLine("1. добавить вложанный ключ в Current User");
            Console.WriteLine("2. добавить вложанный ключ в вложанный ключ");
            Console.WriteLine("3. удалить вложанный ключ");
            Console.WriteLine("или нажмите любую клавишу, чтобы выйти");
            string userKey = Console.ReadLine();
            if (string.IsNullOrEmpty(userKey)) { return; }
            switch (userKey)
            {
                case "1":
                    AddNewKey();
                    break;
                case "2":
                    AddNewKeyToKey();
                    break;
                case "3":
                    RemoveKey();
                    break;
                default:
                    Console.WriteLine("выход");
                    break;
            }
        }
    }
}
