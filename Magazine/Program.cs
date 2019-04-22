using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Program
    {
        static string login, fullname, password; static int purse;

        static void Main(string[] args)
        {
            Console.WriteLine("Вы?");
            Console.WriteLine("1.Клиент");
            Console.WriteLine("2.Издательство");
            Console.WriteLine("3.Выход");

            PublisingHouse nomad = new PublisingHouse();
            var customer = new Customer();

            int i = 0; int a;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Введите цифру ");
            }
            a = i;
            while (a != 1 && a != 2 && a != 3)
            {
                Console.WriteLine("Введите цифру 1, 2, 3");
                while (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("Введите цифру 1, 2, 3");
                }
                a = i;
            }

            if (a == 1)
            {
                int e = 0;
                int d;
                Console.WriteLine("1.Регистрация");
                Console.WriteLine("2.Вход");
                Console.WriteLine("3.Выход");

                while (!int.TryParse(Console.ReadLine(), out e))
                {
                    Console.WriteLine("Введите цифру ");
                }
                d = e;

                while (d != 1 && d != 2 && d != 3)
                {
                    Console.WriteLine("Введите цифру 1, 2, 3");
                    while (!int.TryParse(Console.ReadLine(), out e))
                    {
                        Console.WriteLine("Введите цифру 1, 2, 3");
                    }
                    d = e;
                }

                if (a == 1)
                {
                     FillUser(customer);
                     customer = new Customer{
                        FullName=fullname,
                        Login =login,
                        Password = password,
                        Purse = purse
                    };
                    using (var context = new DataContext())
                    {
                        context.Customers.Add(customer);
                        context.SaveChanges();
                    }
                  
                        Console.WriteLine("Вы успешно зарегистрированы");
                }
                else if (a == 2)
                {
                    Console.WriteLine("Вы получили Журнал?");
                    Console.WriteLine("1. Да");
                    Console.WriteLine("2. Нет");
                    int z = 0, x;
                    while (!int.TryParse(Console.ReadLine(), out z))
                    {
                        Console.WriteLine("Введите цифру ");
                    }
                    x = z;
                    while (x != 1 && x != 2 && x != 3)
                    {
                        Console.WriteLine("Введите цифру 1, 2, 3");
                        while (!int.TryParse(Console.ReadLine(), out z))
                        {
                            Console.WriteLine("Введите цифру 1, 2, 3");
                        }
                        x = z;
                    }
                    if (x==1)
                    customer.Confirmation = true;
                    if (x == 2)
                        Console.WriteLine("Журнал уже в пути");

                }
                else if (a == 3)
                {
                    Environment.Exit(0);
                };

            }
            else if (a == 2)
            {
                Console.WriteLine("Введите пароль");
                    if (nomad.Password == Console.ReadLine())
                    {
                        Console.WriteLine("Успешный вход в систему");
                        
                        if(customer.Subscription==true)
                        {
                            nomad.Print();
                            nomad.Send();
                        if (customer.Confirmation == true)
                            nomad.Confirm();

                        }
                    }                
            }
            else if (a == 3)
            {
                Environment.Exit(0);
            };

        }

        static void FillUser(Customer customer)
        {
            Console.WriteLine("Введите ваше имя");
            fullname = Console.ReadLine();

            Console.WriteLine("Введите Логин(для входа в систему)");
            login = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            password = Console.ReadLine();            

            Console.WriteLine("Введите баланс кошелька");
            int i = 0;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Некоректная сумма");
            }
            purse = i;
        }
    }
}
