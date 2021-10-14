using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber;
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Какое задание желаете проверить? Введите его номер (1-9 или 0, чтобы выйти):");
                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out taskNumber) && taskNumber >= 0 && taskNumber < 10) break;
                    else Console.WriteLine("Ошибка ввода. Введите номер задания (1-9 или 0, чтобы выйти):");
                }

                switch (taskNumber)
                {
                    case 1:
                        double result;
                        Console.WriteLine("Введите дробное число:");
                        if (double.TryParse(Console.ReadLine(), out result))
                        {
                            result = (int) ((result - ((int)result)) * 10);
                            Console.WriteLine(result);
                        }
                        else Console.WriteLine("Ошибка ввода.");
                        break;

                    case 2:
                        Console.WriteLine("Введите количество секунд:");
                        if(Int32.TryParse(Console.ReadLine(), out int secs) && secs >= 0)
                        {
                            int hours, minutes;
                            hours = secs / 3600;
                            minutes = (secs - hours * 3600) / 60;
                            if (secs < 86400) Console.WriteLine("Часов:{0}, минут:{1}", hours, minutes);
                            else Console.WriteLine("Прошло более суток!\nЧасов:{0}, минут:{1}", hours, minutes);
                        }
                        else Console.WriteLine("Ошибка ввода.");
                        break;

                    case 3:
                        int h, m = 0, s = 0;
                        do
                        {
                            Console.WriteLine("Введите кол-во часов:");
                            if (!Int32.TryParse(Console.ReadLine(), out h))
                            {
                                Console.WriteLine("Ошибка ввода. Попробуйте еще раз");
                                continue;
                            }
                            Console.WriteLine("Введите кол-во минут:");
                            if (!Int32.TryParse(Console.ReadLine(), out m))
                            {
                                Console.WriteLine("Ошибка ввода. Попробуйте еще раз");
                                continue;
                            }
                            Console.WriteLine("Введите кол-во секунд:");
                            if (!Int32.TryParse(Console.ReadLine(), out s))
                            {
                                Console.WriteLine("Ошибка ввода. Попробуйте еще раз");
                                continue;
                            }
                        } while (h < 0 || h > 11 || m < 0 || m > 59 || s < 0 || s > 59);
                        if (m % 2 != 0 || s != 0) Console.WriteLine("{0}°" + "{1}\'" + "{2}\'\'", h * 30 + (m - m % 2) / 2, m % 2, s);
                        else Console.WriteLine(h * 30 + (m - m % 2) / 2 + "°");
                        break;

                    case 4:
                        Console.WriteLine("Пусть а - первое число, b - второе.\n" +
                            "Поменять местами их значения можно с помощью следующего способа:\n" +
                            "a += b;\n" +
                            "b = a - b;\n" +
                            "a -= b;");
                        break;

                    case 5:
                        double a, b;

                        Console.WriteLine("Длина первого катета:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Длина второго катета:");
                        b = double.Parse(Console.ReadLine());

                        if (a > 0 && b > 0)
                        {
                            Console.WriteLine("S = " + (a * b) / 2);
                            Console.WriteLine("P = " + (a + b + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
                        }
                        else Console.WriteLine("Введено неверное значение длины катета.");
                        break;

                    case 6:

                        int pr = 1;
                        bool flag = true;
                        Console.WriteLine("Введите четырехзначное число:");
                        string num = Console.ReadLine();
                        if (num.Length != 4) 
                        {   
                            Console.WriteLine("Число не является четырехзначным.");
                            break;
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            if (int.TryParse(num, out _))
                                pr *= int.Parse(num[i].ToString());
                            else
                            {
                                Console.WriteLine("Введенные данные не могут быть перемножены между собой.");
                                flag = false;
                                break;
                            }
                        }
                        if (flag) Console.WriteLine("Произведение цифр числа равно: " + pr);
                        break;

                    case 7:
                        Console.WriteLine("Введите трехначное число:");
                        string tmp = Console.ReadLine();
                        if (tmp.Length == 3 && Int32.TryParse(tmp, out _))
                        {
                            string reserved = "" + tmp[2] + tmp[1] + tmp[0];
                            Console.WriteLine(reserved);
                        }
                        else Console.WriteLine("Ошибка ввода. Проверьте введенные данные.");
                        break;
                        
                    case 8:
                        Console.WriteLine("Введите х:");
                        if (double.TryParse(Console.ReadLine(), out double X))
                        {
                            Console.WriteLine("Упростим уравнение, чтобы выполнялось условие задачи:\n" +
                                "(((3 * X - 5) * X + 2) * X - 1) * X + 7)\n" +
                                "Результат равен: " + ((((3 * X - 5) * X + 2) * X - 1) * X + 7));
                        }
                        else Console.WriteLine("Ошибка ввода.");
                        break;

                    case 9:
                        // метод Крамера
                        double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, x, y, z;
                        Console.WriteLine("Заполните матрицу:");
                        Console.WriteLine("a1 = ");
                        a1 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("a2 = ");
                        a2 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("a3 = ");
                        a3 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("b1 = ");
                        b1 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("b2 = ");
                        b2 = double.Parse(Console.ReadLine());
                       
                        Console.WriteLine("b3 = ");
                        b3 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("c1 = ");
                        c1 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("c2 = ");
                        c2 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("c3 = ");
                        c3 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("d1 = ");
                        d1 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("d2 = ");
                        d2 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("d3 = ");
                        d3 = double.Parse(Console.ReadLine());

                        double delta = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
                        double delta1 = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
                        double delta2 = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
                        double delta3 = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;

                        if (delta != 0)
                        {
                            x = delta1 / delta;
                            y = delta2 / delta;
                            z = delta3 / delta;
                            Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
                        }
                        else Console.WriteLine("Ошибка. Определитель равен нулю.");
                        break;

                    case 0:
                        Console.WriteLine("Выход из приложения...\nНажмите любую клавишу, чтобы закрыть окно.");
                        Flag = false;
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Задание с таким номером не найдено.");
                        break;
                 
                }


            }
        }
    }
}
