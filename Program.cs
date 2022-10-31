namespace ConsoleApp17
{

    internal class Program
    {
        static public ConsoleKeyInfo cho_to;
        static public int position = 3;
        static public int allcost;
        static public string punkti;
        static public int ogran = 1;
        static public int ogran2;
        static void Main(string[] args)
        {
            Kafe();
        }
        static void Kafe()
        {
            Console.Clear();
            Console.WriteLine("Заказ тортов у G.B_OFICIAL. Тортики на ваш выбор!");
            Console.WriteLine("Выберите параметры торта:");
            Console.WriteLine("------------------------");
            Console.WriteLine("   Форма торта.");
            Console.WriteLine("   Размер торта.");
            Console.WriteLine("   Вкус коржей.");
            Console.WriteLine("   Количество коржей.");
            Console.WriteLine("   Глазурь.");
            Console.WriteLine("   Декор.");
            Console.WriteLine("   Упаковка.");
            Console.WriteLine("   Доставка.");
            Console.WriteLine("   Конец заказа.");
            Console.WriteLine(" ");
            Console.WriteLine("Цена: " + allcost);
            Console.WriteLine("Ваш торт: " + punkti);
            
            ogran2 = 11;
            zamena_1();
            zamena_2();
        }
        static void zamena_1()
        {
            position = 3;
            do
            {
                if (cho_to.Key == ConsoleKey.UpArrow)
                {
                    if (position == 3)
                    {
                        position++;
                    }
                    Console.SetCursorPosition(0, position--);
                    Console.Write("->");
                }
                else if (cho_to.Key == ConsoleKey.DownArrow)
                {
                    if (ogran2 == 5 && position == 5 || ogran2 == 11 && position == 11)
                    {
                        position--;
                    }
                    Console.SetCursorPosition(0, position++);
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2));
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                cho_to = Console.ReadKey();
                if (cho_to.Key == ConsoleKey.Escape)
                {
                    ogran = 3;
                    ogran2 = 10;
                    Kafe();
                    cho_to = Console.ReadKey();
                    return;
                }
            }
            while (cho_to.Key != ConsoleKey.Enter);
        }
        static void zamena_2()
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Выберите пункт из меню: ");
            Console.WriteLine("------------------------");
            ogran = 3;
            ogran2 = 6;
            Class1 forma_torta = new Class1();
            forma_torta.podname_1 = "  Круг";
            forma_torta.cost_1 = 500;

            forma_torta.podname_2 = "  Квадрат";
            forma_torta.cost_2 = 500;

            forma_torta.podname_3 = "  Прямоугольник";
            forma_torta.cost_3 = 500;

            forma_torta.podname_4 = "  Сердечко";
            forma_torta.cost_4 = 700;

            Class1 razmer_torta = new Class1();
            razmer_torta.podname_1 = "  Маленький (Диаметр - 16 см, 8 порций.)";
            razmer_torta.cost_1 = 1000;

            razmer_torta.podname_2 = "  Обычный (Диаметр - 18 см, 10 порций.)";
            razmer_torta.cost_2 = 1200;

            razmer_torta.podname_3 = "  Большой (Диаметр - 28 см, 24 порции.)";
            razmer_torta.cost_3 = 2000;

            Class1 vkys_korzhei = new Class1();
            vkys_korzhei.podname_1 = "  Ванильный";
            vkys_korzhei.cost_1 = 100;

            vkys_korzhei.podname_2 = "  Шоколадный";
            vkys_korzhei.cost_2 = 100;

            vkys_korzhei.podname_3 = "  Карамельный";
            vkys_korzhei.cost_3 = 150;

            vkys_korzhei.podname_4 = "  Ягодный";
            vkys_korzhei.cost_4 = 200;

            vkys_korzhei.podname_5 = "  Кокосовый";
            vkys_korzhei.cost_5 = 250;

            Class1 amount_korzhei = new Class1();
            amount_korzhei.podname_1 = "  1 корж";
            amount_korzhei.cost_1 = 200;

            amount_korzhei.podname_2 = "  2 коржа";
            amount_korzhei.cost_2 = 400;

            amount_korzhei.podname_3 = "  3 коржа";
            amount_korzhei.cost_3 = 600;

            amount_korzhei.podname_4 = "  4 коржа";
            amount_korzhei.cost_4 = 800;

            Class1 glazyr = new Class1();
            glazyr.podname_1 = "  Шоколад";
            glazyr.cost_1 = 100;

            glazyr.podname_2 = "  Крем";
            glazyr.cost_2 = 100;

            glazyr.podname_3 = "  Бизе";
            glazyr.cost_3 = 150;

            glazyr.podname_4 = "  Драже";
            glazyr.cost_4 = 150;

            glazyr.podname_5 = "  Ягоды";
            glazyr.cost_5 = 200;

            Class1 decor = new Class1();
            decor.podname_1 = "  Шоколадная";
            decor.cost_1 = 150;

            decor.podname_2 = "  Ягодная";
            decor.cost_2 = 150;

            decor.podname_3 = "  Кремовая";
            decor.cost_3 = 150;

            Class1 ypacovka = new Class1();
            ypacovka.podname_1 = "  В целлофановом пакете";
            ypacovka.cost_1 = 100;

            ypacovka.podname_2 = "  В картонном пакете";
            ypacovka.cost_2 = 150;

            ypacovka.podname_3 = "  В прозрачной обертке";
            ypacovka.cost_3 = 200;

            ypacovka.podname_4 = "  В прозрачной обертке и картонном пакете.";
            ypacovka.cost_4 = 350;

            Class1 dostavka = new Class1();
            dostavka.podname_1 = "  Без доставки";
            dostavka.cost_1 = 0;

            dostavka.podname_2 = "  С доставкой по городу (На дом или туда куда вы закажите.)";
            dostavka.cost_2 = 500;

            dostavka.podname_3 = "  С доставкой в другие города (Курьером или почтой России, на ваш выбор!)";
            dostavka.cost_3 = 5000;
            switch (position)
            {
                case 3:
                    {
                        Console.WriteLine(" " + forma_torta.podname_1 + " - " + forma_torta.cost_1 + "\n" + " " + forma_torta.podname_2 + " - " + forma_torta.cost_2 + "\n" 
                        + " " + forma_torta.podname_3 + " - " + forma_torta.cost_3 + "\n" + " " + forma_torta.podname_4 + " - " +
                        forma_torta.cost_4 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + forma_torta.cost_1;
                                punkti = punkti + forma_torta.podname_1 + ", ";
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + forma_torta.cost_2;
                                punkti = punkti + forma_torta.podname_2 + ", ";
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + forma_torta.cost_3;
                                punkti = punkti + forma_torta.podname_3 + ", ";
                            }
                            else if (position == 6)
                            {
                                allcost = allcost + forma_torta.cost_4;
                                punkti = punkti + forma_torta.podname_4 + ", ";
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 4:
                    {
                        Console.WriteLine(" " + razmer_torta.podname_1 + " - " + razmer_torta.cost_1 + "\n" + " " + razmer_torta.podname_2 + " - " + razmer_torta.cost_2 + "\n" + " " + razmer_torta.podname_3 + " - " + razmer_torta.cost_3 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + razmer_torta.cost_1;
                                punkti = punkti + razmer_torta.podname_1 + ", ";
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + razmer_torta.cost_2;
                                punkti = punkti + razmer_torta.podname_2 + ", ";
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + razmer_torta.cost_3;
                                punkti = punkti + razmer_torta.podname_3 + ", ";
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 5:
                    {
                        Console.WriteLine(" " + vkys_korzhei.podname_1 + " - " + vkys_korzhei.cost_1 + "\n" + " " + vkys_korzhei.podname_2 + " - " + vkys_korzhei.cost_2 + "\n" 
                        + " " + vkys_korzhei.podname_3 + " - " + vkys_korzhei.cost_3 + "\n" + " " + vkys_korzhei.podname_4 + " - " + vkys_korzhei.cost_4 + "\n" +
                        " " + vkys_korzhei.podname_5 + " - " + vkys_korzhei.cost_5 + "\n");
                        
                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + vkys_korzhei.cost_1;
                                punkti = punkti + vkys_korzhei.podname_1 + ", ";
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + vkys_korzhei.cost_2;
                                punkti = punkti + vkys_korzhei.podname_2 + ", ";
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + vkys_korzhei.cost_3;
                                punkti = punkti + vkys_korzhei.podname_3 + ", ";
                            }
                            else if (position == 6)
                            {
                                allcost = allcost + vkys_korzhei.cost_4;
                                punkti = punkti + vkys_korzhei.podname_4 + ", ";
                            }
                            else if (position == 7)
                            {
                                allcost = allcost + vkys_korzhei.cost_5;
                                punkti = punkti + vkys_korzhei.podname_5 + ", ";
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 6:
                    {
                        Console.WriteLine(" " + amount_korzhei.podname_1 + " - " + amount_korzhei.cost_1 + "\n" + " " + amount_korzhei.podname_2 + " - " + amount_korzhei.cost_2 + "\n" 
                            + " " + amount_korzhei.podname_3 + " - " + amount_korzhei.cost_3 + "\n" + " " + amount_korzhei.podname_4 + " - " + amount_korzhei.cost_4 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + amount_korzhei.cost_1;
                                punkti = punkti + amount_korzhei.podname_1 + ", ";
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + amount_korzhei.cost_2;
                                punkti = punkti + amount_korzhei.podname_2 + ", ";
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + amount_korzhei.cost_3;
                                punkti = punkti + amount_korzhei.podname_3 + ", ";
                            }
                            else if (position == 6)
                            {
                                allcost = allcost + amount_korzhei.cost_4;
                                punkti = punkti + amount_korzhei.podname_4 + ", ";
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 7:
                    {
                        Console.WriteLine(" " + glazyr.podname_1 + " - " + glazyr.cost_1 + "\n" + " " + glazyr.podname_2 + " - " + glazyr.cost_2 + "\n" 
                        + " " + glazyr.podname_3 + " - " + glazyr.cost_3 + "\n" + " " + glazyr.podname_4 + " - " + glazyr.cost_4 + "\n"
                        + " " + glazyr.podname_5 + " - " + glazyr.cost_5 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + glazyr.cost_1;
                                punkti = punkti + glazyr.podname_1 + ", ";
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + glazyr.cost_2;
                                punkti = punkti + glazyr.podname_2 + ", ";
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + glazyr.cost_3;
                                punkti = punkti + glazyr.podname_3 + ", ";
                            }
                            else if (position == 6)
                            {
                                allcost = allcost + glazyr.cost_4;
                                punkti = punkti + glazyr.podname_4 + ", ";
                            }
                            else if (position == 7)
                            {
                                allcost = allcost + glazyr.cost_5;
                                punkti = punkti + glazyr.podname_5 + ", ";
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 8:
                    {
                        Console.WriteLine(" " + decor.podname_1 + " - " + decor.cost_1 + "\n" + " " + decor.podname_2 + " - " + decor.cost_2 + "\n" + " " + decor.podname_3 + " - " + decor.cost_3 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + decor.cost_1;
                                punkti = punkti + decor.podname_1;
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + decor.cost_2;
                                punkti = punkti + decor.podname_2;
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + decor.cost_3;
                                punkti = punkti + decor.podname_3;
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 9:
                    {
                        Console.WriteLine(" " + ypacovka.podname_1 + " - " + ypacovka.cost_1 + "\n" + " " + ypacovka.podname_2 + " - " + ypacovka.cost_2 + "\n" 
                        + " " + ypacovka.podname_3 + " - " + ypacovka.cost_3 + "\n" + " " + ypacovka.podname_4 + " - " + ypacovka.cost_4 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + ypacovka.cost_1;
                                punkti = punkti + ypacovka.podname_1;
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + ypacovka.cost_2;
                                punkti = punkti + ypacovka.podname_2;
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + ypacovka.cost_3;
                                punkti = punkti + ypacovka.podname_3;
                            }
                            else if (position == 6)
                            {
                                allcost = allcost + ypacovka.cost_4;
                                punkti = punkti + ypacovka.podname_4;
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 10:
                    {
                        Console.WriteLine(" " + dostavka.podname_1 + " - " + dostavka.cost_1 + "\n" + " " + dostavka.podname_2 + " - " + dostavka.cost_2 + "\n" + " " + dostavka.podname_3 + " - " + dostavka.cost_3 + "\n");

                        zamena_1();
                        if (cho_to.Key == ConsoleKey.Enter)
                        {
                            if (position == 3)
                            {
                                allcost = allcost + dostavka.cost_1;
                                punkti = punkti + dostavka.podname_1;
                            }
                            else if (position == 4)
                            {
                                allcost = allcost + dostavka.cost_2;
                                punkti = punkti + dostavka.podname_2;
                            }
                            else if (position == 5)
                            {
                                allcost = allcost + dostavka.cost_3;
                                punkti = punkti + dostavka.podname_3;
                            }
                            Kafe();
                            return;
                        }
                        return;
                    }
                case 11:
                    {
                        string data = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один нажмите Escape");
                        File.AppendAllText("C:\\Users\\Глеб\\Desktop\\что-то.txt", "Текущая дата: " + data + "\n" + "\n" + "Стоимость: " + allcost + "Выбранные параметры торта: " + punkti + "\n");
                        cho_to = Console.ReadKey();
                        if (cho_to.Key == ConsoleKey.Escape)
                        {
                            allcost = 0;
                            punkti = " ";
                            ogran = 1;
                            ogran2 = 11;
                            Kafe();
                            return;
                        }
                        return;
                    }
            }
        }
    }
}