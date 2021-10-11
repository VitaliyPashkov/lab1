using System;
using System.Collections;

namespace Table {
    public class OOP {
        public enum Type
        {
            K, O
        }
        public class Item
        {
            public String ItemName;
            public Type ItemType;
            public double price;
            public int amount;

            public Item(string ItemName, Type ItemType, double price, int amount)
            {
                this.ItemName = ItemName;
                this.ItemType = ItemType;
                this.price = price;
                this.amount = amount;
            }

            public void Print()
            {
                Console.WriteLine($"|{this.ItemName,-24}|{this.ItemType,-12}|{this.price,-20}|{this.amount,-15}|");
                //Console.WriteLine('|'+this.ItemName + "\t|" + this.ItemType + "\t|" + this.price + "\t|" + this.amount+'|');
            }
        }

        private static void Main()
        {
            ArrayList list = new ();
            
            /* Item a = new ("Папка", Type.K, 4.75, 400);
             Item b = new("Калькулятор", Type.O, 411, 10);

             a.Print();
             b.Print();*/
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Наименование товара:");
                string name = Console.ReadLine();

                Type ItemType;
                while (true)
                {
                    Console.WriteLine("Тип товара(K, O):");
                    string tmp = Console.ReadLine();
                    if (tmp == "K" || tmp == "К") // обработка русской и английской К
                    {
                        ItemType = Type.K;
                        break;
                    }
                    else if (tmp == "O" || tmp =="О") // обработка русской и английской О
                    { 
                        ItemType = Type.O;
                        break;
                    }
                    else Console.WriteLine("Некорректный ввод значения. Введите еще раз.");

                }

                Console.WriteLine("Цена за 1 шт (грн)");
                double price = Math.Round(double.Parse(Console.ReadLine()), 2);

                Console.WriteLine("Количество:");
                int amount = Int32.Parse(Console.ReadLine());
                Item value = new(name, ItemType, price, amount);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить еще элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }
                
            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Прайс-лист",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Наименование товара",-25}|{"Тип товара",-12}|{"Цена за 1 шт (грн)",-20}|{"Количество",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: К – канцтовары, О - оргтехника",-75}|");
            Console.WriteLine(new String('-', 76));
        }

    }
}
