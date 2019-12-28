using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static List<Service> services;

        static Dictionary<Visitor, List<Service>> Initialize()
        {
            Service volosnya = new Service("Стрижка", 200);
            Service rozha = new Service("Макияж", 300);
            services = new List<Service>();
            services.Add(volosnya);
            services.Add(rozha);
            Dictionary<Visitor, List<Service>> journal = new Dictionary<Visitor, List<Service>>();
            Visitor crief = new Visitor("Директор", 32, 0);
            Visitor master = new Visitor("Парикмахер", 22, 1);
            Visitor visitorToCut = new Visitor("Посетитель", 20, 238);
            Visitor visitorToMake = new Visitor("Посетитель", 20, 249);
            journal.Add(crief, new List<Service>());
            journal.Add(master, new List<Service>());
            journal.Add(visitorToCut, new List<Service>() { volosnya, rozha });
            journal.Add(visitorToMake, new List<Service>() { rozha });
            //journal[crief].Add(gym);
            return journal;
        }
        struct Visitor
        {
            string name;
            int age;
            int number;
            public Visitor(string name, int age, int number)
            {
                this.name = name;
                this.age = age;
                this.number = number;

            }
            public void Show(string beggining = "")
            {
                Console.WriteLine(beggining + this.name + ", " + this.age + ", " + this.number);
            }
        }
        public string name { get; set; }
        public int age { get; set; }
        public int number { get; set; }

        struct Service
        {
            string name;
            int price;
            public Service(string name, int price)
            {
                this.name = name;
                this.price = price;
            }
            public void Show(string beggining = "")
            {
                Console.WriteLine(beggining + this.name + ", " + this.price);
            }
        }


        static void Menu(ref Dictionary<Visitor, List<Service>> journal1)
        {
            Console.WriteLine("Выберете нужный пункт меню:");
            Console.WriteLine("1. Список посетителей");
            Console.WriteLine("2. Добавить посетитея");
            Console.WriteLine("3. Удалить посетителя");
            Console.WriteLine("4. Список услуг");
            Console.WriteLine("5. Добавить услугу");
            Console.WriteLine("6. Добавить услугу посетителю");
            Console.WriteLine("7. Удалить услугу");
            Console.WriteLine("8. Список посетителей с их услугами");
            Console.WriteLine("9. Удалить услугу у посетителя");
            Console.WriteLine("0. Выход");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (a)
            {
                case 1:
                    ShowVisitors(journal1);
                    break;
                case 2:
                    AddVisitor(ref journal1);
                    break;
                case 3:
                    RemoveVisitor(ref journal1);
                    break;
                case 4:
                    ShowServices(services);
                    break;
                case 5:
                    AddService(journal1);
                    break;
                case 7:
                    RemoveService(services);
                    break;
                case 8:
                    ShowVisitorWithServices(journal1);
                    break;
                case 9:
                    RemoveServiceToVisitor(ref journal1);
                    break;
                case 6:
                    AddServiceToVisitor(journal1);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Введено неверное значение, пожалуйста, введите еще раз");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadLine();
            Console.Clear();
            Menu(ref journal1);
        }

        static void AddServiceToVisitor(Dictionary<Visitor, List<Service>> journal1)
        {
            Console.WriteLine("");
            ShowVisitors(journal1);
            Console.WriteLine("Выберите номер посетителя");
            int a = Convert.ToInt32(Console.ReadLine());
            Visitor visitorToChoose = new Visitor();
            int count = 1;
            foreach (var visitor in journal1.Keys)
            {
                if (count == a)
                {
                    visitorToChoose = visitor;
                    break;
                }
                count++;
            }
            Console.WriteLine("Введите услугу");
            Console.WriteLine();
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price = Convert.ToInt32(Console.ReadLine());
            Service what = new Service(name, price);
            journal1[visitorToChoose].Add(what);
        }

        static void ShowVisitorWithServices(Dictionary<Visitor, List<Service>> journal)
        {
            int count = 1;
            foreach (Visitor visitor in journal.Keys)
            {
                visitor.Show((count++) + ".");
                int countValue = 1;
                foreach (Service service in journal[visitor])
                {
                        service.Show("\t" + (countValue++) + ".");
                }
            }
            /*foreach (KeyValuePair<Visitor, List<Service>> keyValue in journal)
            {
                Console.WriteLine(keyValue.Key + " _ " + keyValue.Value);
            }*/
        }

        private static void AddService(Dictionary<Visitor, List<Service>> journal)
        {
            Console.WriteLine("Введите услугу");
            Console.WriteLine();
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price = Convert.ToInt32(Console.ReadLine());
            services.Add(new Service(name, price));
        }

        private static void ShowServices(List<Service> Service)
        {
            int i = 1;
            foreach (var service in services)
                service.Show((i++) + ". ");
            Console.WriteLine();
        }

        static void ShowVisitors(Dictionary<Visitor, List<Service>> journal1)
        {
            int i = 1;
            foreach (var visitor in journal1.Keys)
                visitor.Show((i++) + ". ");
            Console.WriteLine();
        }
        static void AddVisitor(ref Dictionary<Visitor, List<Service>> journal1)
        {
            Console.WriteLine("Введите имя посетителя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст посетителя");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер посетителя");
            int number = Convert.ToInt32(Console.ReadLine());
            journal1.Add(new Visitor(name, age, number), new List<Service>());
        }
        static void RemoveVisitor(ref Dictionary<Visitor, List<Service>> journal1)
        {
            Console.WriteLine("");
            ShowVisitors(journal1);
            Console.WriteLine("Выберите посетителя");
            int a = Convert.ToInt32(Console.ReadLine());
            Visitor visitorToRemove = new Visitor();
            int count = 1;
            foreach (var visitor in journal1.Keys)
            {
                if (count == a)
                {
                    visitorToRemove = visitor;
                    break;
                }
                count++;
            }
            journal1.Remove(visitorToRemove);
        }
        static void RemoveService(List<Service> Service)
        {
            Console.WriteLine("");
            ShowServices(services);
            Console.WriteLine("Выберите услугу");
            int a = Convert.ToInt32(Console.ReadLine());
            Service serviceToRemove = new Service();
            int count = 1;
            foreach (var service in services)
            {
                if (count == a)
                {
                    serviceToRemove = service;
                    break;
                }
                count++;
            }
            services.Remove(serviceToRemove);
        }
        static void RemoveServiceToVisitor(ref Dictionary<Visitor, List<Service>> journal1)
        {
            Console.WriteLine("");
            ShowVisitorWithServices(journal1);
            Console.WriteLine("");
            Console.WriteLine("Выберите посетителя");
            int a = Convert.ToInt32(Console.ReadLine());
            Visitor visitorTo = new Visitor();
            int count = 1;
            foreach (var visitor in journal1.Keys)
            {
                if (count == a)
                {
                    visitorTo = visitor;
                    break;
                }
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine("Выберите услугу");
            a = Convert.ToInt32(Console.ReadLine());
            Service serviceToRemove = new Service();
            count = 1;
            foreach (var service in journal1[visitorTo])
            {
                if (count == a)
                {
                    serviceToRemove = service;
                    break;
                }
                count++;
            }
            //string name = Console.ReadLine();
            //int price = Convert.ToInt32(Console.ReadLine());
            //Service what = new Service(name, price);
            //journal1.Remove();
            journal1[visitorTo].Remove(serviceToRemove);
        }
        static void Main(string[] args)
        {
            Dictionary<Visitor, List<Service>> journal1 = Initialize();
            Menu(ref journal1);
            Console.ReadLine();
        }
    }
}
