using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            window();
            List<Profession> Pr = new List<Profession>();
            Firma RG=new Firma();
            Our_Profession(ref Pr);
            Our_Staff(ref RG, Pr);
            Fond();
            Searce(ref Pr, ref RG);
        }

        static void Searce(ref List<Profession> Pr, ref Firma RG)
        {
            int nCount = 0;
            Menu1( nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;

            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter )
                {

                    bFlag = true;
                    if (nCount == 2)
                    {
                        bFlag = false;
                        break;
                    }
                    if (nCount == 0)
                    {
                        First(ref Pr, ref RG);
                    }
                    else Second(Pr, RG);
                }

                if (ConsoleKey.DownArrow == keyDown.Key || ConsoleKey.RightArrow == keyDown.Key)
                {
                    nCount++;
                    if (nCount > 2) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key || ConsoleKey.LeftArrow == keyDown.Key)
                {
                    nCount--;
                    if (nCount < 0) nCount = 2;
                }

                Menu1(nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static void Searce1(ref List<Profession> Pr, ref Firma RG)
        {
            int nCount = 0;
            Menu2(ref Pr, ref RG, nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;

            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == 3)
                    {
                        bFlag = false;
                        break;
                    }
                    if (nCount == 0)
                    {
                        ADD1(Pr, ref RG);
                    }
                    if (nCount == 1)
                    {
                        Edit(Pr, ref RG);
                    }
                    if (nCount == 2) Delete1(Pr, ref RG);
                }

                if (ConsoleKey.DownArrow == keyDown.Key || ConsoleKey.RightArrow == keyDown.Key)
                {
                    nCount++;
                    if (nCount > 3) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key || ConsoleKey.LeftArrow == keyDown.Key)
                {
                    nCount--;
                    if (nCount < 0) nCount = 3;
                }

                Menu2(ref Pr, ref RG,nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static void Searce2(List<Profession> Pr, ref Firma RG)
        {
            int nCount = 0;
            Menu2_1(Pr, ref RG, nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;
            int n = Pr.Count;
            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == n)
                    {
                        bFlag = false;
                        break;
                    }
                    else
                    {
                        add(Pr, ref RG, nCount);
                        bFlag = false;
                        break;
                    }
                }

                if (ConsoleKey.DownArrow == keyDown.Key )
                {
                    nCount++;
                    if (nCount > n) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key )
                {
                    nCount--;
                    if (nCount < 0) nCount = n;
                }

                Menu2_1(Pr, ref RG, nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static void Searce3(List<Profession> Pr, ref Firma RG)     //редактируем
        {
            int nCount = 0;
            Menu2_2(Pr, ref RG, nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;
            int n = RG.Count;
            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == n)
                    {
                        bFlag = false;
                        break;
                    }

                    else edit(Pr, ref RG, nCount);
                }

                if (ConsoleKey.DownArrow == keyDown.Key)
                {
                    nCount++;
                    if (nCount > n) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key)
                {
                    nCount--;
                    if (nCount < 0) nCount = n;
                }

                Menu2_2(Pr, ref RG, nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static void Searce3_1(List<Profession> Pr, ref Firma RG)     //удаляем
        {
            int nCount = 0;
            Menu2_2(Pr, ref RG, nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;
            int n = RG.Count;
            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == n)
                    {
                        bFlag = false;
                        break;
                    }
                    else
                    {
                        del(Pr, ref RG, nCount);
                        bFlag = false;
                        break;
                    }
                }

                if (ConsoleKey.DownArrow == keyDown.Key)
                {
                    nCount++;
                    if (nCount > n) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key)
                {
                    nCount--;
                    if (nCount < 0) nCount = n;
                }

                Menu2_2(Pr, ref RG, nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static void Menu1_2(List<Profession> Pr, int nCount)
        {
            var obj1 = new bool[1];
            string bak = "НАЗАД";

            for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }

            Console.WriteLine("\n\t\t\t   Перечень профессий.");
            Console.WriteLine("\n\t\t\t   ------------------");
            for (int j = 0; j < Pr.Count; j++)
            {
                Console.Write("\n\t\t\t     ");
                Console.Write(Pr.ElementAt(j).Prof);
            }
            Console.Write("\n\n\n\t\t\t     ");
            Mark(obj1[0]);
            Console.Write(bak);
            Fond();
        }

        static void Menu2_1(List<Profession> Pr, ref Firma RG, int nCount)
        {
            var obj1 = new bool[Pr.Count+1];
            string bak = "НАЗАД";

            var obj = new object[Pr.Count];
            for (int j = 0; j < Pr.Count; j++)
            {
                obj[j] = Pr.ElementAt(j).Prof;
            }

            for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }

            Console.WriteLine("\n\t\t\t   Выбирете профессию.");
            Console.WriteLine("\n\t\t\t   ------------------");
            int n = Pr.Count;
            for (int j = 0; j < Pr.Count; j++)
            {
                PrintObj(obj1[j], obj[j]);
            }
            Console.Write("\n\n\n\t\t\t     ");
            Mark(obj1[n]);
            Console.Write(bak);
            Fond();
        }

        static void Menu2_2(List<Profession> Pr, ref Firma RG, int nCount)       // меню редактируем
        {
            var obj1 = new bool[RG.Count + 1];
            string bak = "НАЗАД";

            var obj = new Employee[RG.Count];
             for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }


            int s = 0;
            for (int j = 0; j < Pr.Count; j++)
            {
                foreach (var a in RG)
                {
                    if (a.RetProf() == Pr.ElementAt(j).Prof)
                    {
                        obj[s]=a;
                        s++;
                    }
                }
            }


            Console.WriteLine("\n\t\t   Выбирете сотрудника для корректировки");
            Console.WriteLine("\n\t\t\t   -----------------");
            int n = RG.Count;
            s = 0;
            for (int j = 0; j < Pr.Count; j++)
            {
                Console.Write("\n\n\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Pr.ElementAt(j).Prof);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                
                foreach (var a in RG)
                {
                    
                    if (a.RetProf() == Pr.ElementAt(j).Prof)
                    {
                        PrintObj1(obj1[s], obj[s]);
                        s++;
                    }
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("\n\t\t\t   ------------------");
            Console.Write("\t\t\t         ");
            Mark(obj1[n]);
            Console.Write(bak);
            Fond();
        }

        static void First(ref List<Profession> Pr, ref Firma RG)
        {
            Searce1(ref Pr, ref RG);
        }

        static void Second(List<Profession> Pr, Firma RG)
        {
            Searce1_2(Pr, RG);
        }

        static void Menu1(int nCount )
        {
            var obj1 = new bool[3];
            string[] objPr = new string[] 
            { "Познакомьтесь наши сотрудники", 
               "Вакантные профессии выбирайте", 
               "Выход",
             };

            for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }
            Console.WriteLine("\n\t\t\t\tФИРМА \"POГА and Кo\"");
            Console.WriteLine("\n\t\t\t\t-------------------");
            Console.Write("\n\n\n\t\t\t  ");
            Mark(obj1[0]);
            Console.WriteLine(objPr[0]);
            Fond();
            Console.Write("\n\n\t\t\t  ");
            Mark(obj1[1]);
            Console.WriteLine(objPr[1]);
            Fond();
            Console.Write("\n\n\n\n\n\n\t\t\t\t     ");
            Mark(obj1[2]);
            Console.WriteLine(objPr[2]);
            Fond();
            Console.WriteLine("\n");
        }

        static void Menu2(ref List<Profession> Pr, ref Firma RG, int nCount)
        {
            var obj1 = new bool[4];
            string[] objPr = new string[] 
            { "Добавить", 
               "Редактировать",
               "Удалить",
               "Назад",
             };

            for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }
            Console.WriteLine("\n\t\t\t   Перечень сотрудников.");
            Console.WriteLine("\n\t\t\t   -------------------");
            int n = Pr.Count;
            for (int j=0; j < Pr.Count; j++)
            {
                Console.Write("\n\n\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Pr.ElementAt(j).Prof);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach(var a in RG)
                {
                    if(a.RetProf()==Pr.ElementAt(j).Prof)
                    {
                        Print(a);
                    }
                }
            }
            Console.Write("\n\n\n\t\t     ");
            Mark(obj1[0]);
            Console.Write(objPr[0]);
            Fond();
            Console.Write("    ");
            Mark(obj1[1]);
            Console.Write(objPr[1]);
            Fond();
            Console.Write("    ");
            Mark(obj1[2]);
            Console.WriteLine(objPr[2]);
            Fond();
            Console.WriteLine("\n");
            Console.Write("\n\t\t\t\t     ");
            Mark(obj1[3]);
            Console.Write(objPr[3]);
            Fond();
        }

        static void Menu3(int nCount)
        {
            var obj1 = new bool[3];
            string[] objPr = new string[] 
            { "Познакомьтесь наши сотрудники", 
               "Вакантные профессии выбирайте", 
               "Выход",
             };

            for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }
            Console.WriteLine("\n\t\t\t\tФИРМА \"POГА and Кo\"");
            Console.WriteLine("\n\t\t\t\t-------------------");
            Console.Write("\n\n\n\t\t\t  ");
            Mark(obj1[0]);
            Console.WriteLine(objPr[0]);
            Fond();
            Console.Write("\n\n\t\t\t  ");
            Mark(obj1[1]);
            Console.WriteLine(objPr[1]);
            Fond();
            Console.Write("\n\n\n\n\n\n\t\t\t\t     ");
            Mark(obj1[2]);
            Console.WriteLine(objPr[2]);
            Fond();
            Console.WriteLine("\n");
        }

        static void Mark(bool obj1)
        {
            if (obj1 == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        static void Fond()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void Our_Profession(ref List<Profession> Pr)
        {
            Pr.Add(new Profession() { Prof = "Пильщик Рогов", id = 100 });
            Pr.Add(new Profession() { Prof = "Рогонос", id = 200 });
            Pr.Add(new Profession() { Prof = "Рогочист", id = 300 });
            Pr.Add(new Profession() { Prof = "Мойшик Копыт", id = 150 });
            Pr.Add(new Profession() { Prof = "Копытолов", id = 250 });
            Pr.Add(new Profession() { Prof = "Копытонос", id = 350 });
            Pr.Add(new Profession() { Prof = "КопытоРогоВоз", id = 400 });
            Pr.Add(new Profession() { Prof = "Упоковщик", id = 500 });
            Pr.Add(new Profession() { Prof = "Бухгалтер", id = 900 });
            Pr.Add(new Profession() { Prof = "Директор", id = 1000 });
        }

        static void Our_Staff(ref Firma RG, List<Profession> Pr)
        {
            RG.Add(new Employee("Иван",  19, true, 1000, Pr.ElementAt(0)));
            RG.Add(new Employee("Игнат", 50, true, 2000, Pr.ElementAt(1)));
            RG.Add(new Employee("Федот", 25, true, 3000, Pr.ElementAt(2)));
            RG.Add(new Employee("Светлодар", 35, true, 1500, Pr.ElementAt(3)));
            RG.Add(new Employee("Муром", 35, true, 2500, Pr.ElementAt(4)));
            RG.Add(new Employee("Федот", 50, true, 2500, Pr.ElementAt(5)));
            RG.Add(new Employee("Николас", 51, true, 4000, Pr.ElementAt(6)));
            RG.Add(new Employee("Зинаида", 30, false, 5000, Pr.ElementAt(7)));
            RG.Add(new Employee("Наталья Барисовна", 58, false, 9000, Pr.ElementAt(8)));
            RG.Add(new Employee("Владимир Владимирович", 62, true, 10, Pr.ElementAt(9)));
        }

        static void ADD1(List<Profession> Pr, ref Firma RG)
        {
            Searce2(Pr, ref RG);
        }

        static void Delete1(List<Profession> Pr, ref Firma RG)
        {
            Searce3_1(Pr, ref RG);
        }

        static void Print (Employee a)
        {
            Console.Write("\n  Имя: {0},\tВозраст: {1} лет,  Пол: {2},   Зарплата: {3}$.   ", a.GetName(), a.GetAge(), a.GetGender(), a.GetSalary());
        }

        static void Edit(List<Profession> Pr, ref Firma RG)
        {
            Searce3(Pr, ref RG);
        }

        static void PrintObj(bool obj1, object obj)
        {
            Console.Write("\n\t\t\t     ");
            Mark(obj1);
            Console.Write(obj);
            Fond();
        }

        static void PrintObj1(bool obj1, Employee obj)
        {
            Console.Write("       ");
            Mark(obj1);
            Print(obj);
            Fond();
        }

        static void add(List<Profession> Pr, ref Firma RG, int n)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            int c =0, age = 0, salary = 0,k=0;
            string name;
            bool gender;
            Console.Write("\t Введите колличество '"+Pr.ElementAt(n).Prof+ "' для добавления-> ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c > 0)
            {
                while (c > 0)
                {
                    Console.Write("\n\n\t Введите имя -> ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("\t Введите пол (муж - 1 или жен - 0) -> ");
                    try
                    {
                        k = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("\t Введите пол (муж - 1 или жен - 0) -> ");
                        k = Convert.ToInt32(Console.ReadLine());
                    }
                        
                    if (k == 0) gender = false;
                    else gender = true;
                    Console.Write("\t Введите возраст (лет)-> ");
                    try
                    {
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("\t Введите возраст (лет)-> ");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("\t Введите размер зарплаты ($)-> ");
                    try
                    {
                        salary = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("\t Введите размер зарплаты ($.)-> ");
                        salary = Convert.ToInt32(Console.ReadLine());
                    }
                    Employee a = new Employee(name, age, gender, salary, Pr.ElementAt(n));
                    RG = RG + a;
                    Console.Clear();
                    c--;
                }
            }
            Profession[] P=new Profession [Pr.Count];
            for (int i = 0; i < Pr.Count; i++)
            {
                P[i] = Pr.ElementAt(i);
            }
        }

        static void edit(List<Profession> Pr, ref Firma RG, int n)
        {
            int count = 0, age = 0, salary = 0, k = 0, v=0;
            string name;
            bool gender;
            Console.WriteLine("\n\t\t\t   Сотрудник.");
            Console.WriteLine("\n\t\t\t   ----------\n\n");
            v = NumberEmp(Pr, RG, n);
            Print(RG.ElementAt(v));
            Console.WriteLine(RG.ElementAt(v).GetProf());
            Console.Write("\n\n\t Введите  новое имя -> ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("\t Введите пол (муж - 1 или жен - 0) -> ");
            k = Convert.ToInt32(Console.ReadLine());
            if (k == 0) gender = false;
            else gender = true;
            Console.Write("\t Введите возраст (лет)-> ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t Введите размер зарплаты (грн.)-> ");
            salary = Convert.ToInt32(Console.ReadLine());


            RG.RemoveAt(v);
            Employee a = new Employee(name, age, gender, salary, Pr.ElementAt(count));
            RG = RG + a;
            Console.Clear();
            Searce4(Pr, ref RG);
            //RG.RemoveAt(n);
            //Employee a = new Employee(name, age, gender, salary, Pr.ElementAt(count));
            //RG = RG + a;
        }

        static void del(List<Profession> Pr, ref Firma RG, int n)
        {
            int v = 0;
            Console.WriteLine("\n\t\t\t   Сотрудник.");
            Console.WriteLine("\n\t\t\t   ----------\n\n");
            v = NumberEmp(Pr, RG, n);
            Print(RG.ElementAt(v));
            Console.WriteLine(RG.ElementAt(v).GetProf());
            RG = RG - v;
            Console.Clear();
            //Searce4(Pr, ref RG);
        }

        static void Searce4(List<Profession> Pr, ref Firma RG)
        {
            int nCount = 0;
            Menu2_1(Pr, ref RG, nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;
            int n = Pr.Count;
            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == n)
                    {
                        bFlag = false;
                        break;
                    }
                    else
                    {
                        RG.ElementAt(RG.Count - 1).SetProf(Pr.ElementAt(nCount));
                        bFlag = false;
                        break;
                    }
                }

                if (ConsoleKey.DownArrow == keyDown.Key)
                {
                    nCount++;
                    if (nCount > n) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key)
                {
                    nCount--;
                    if (nCount < 0) nCount = n;
                }

                Menu2_1(Pr, ref RG, nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static void Searce1_2(List<Profession> Pr, Firma RG)
        {
            int nCount = 0;
            Menu1_2(Pr, nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;
            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == 0)
                    {
                        bFlag = false;
                        break;
                    }
                }

                if (ConsoleKey.DownArrow == keyDown.Key)
                {
                    nCount++;
                    if (nCount > 0) nCount = 0;
                }

                else if (ConsoleKey.UpArrow == keyDown.Key)
                {
                    nCount--;
                    if (nCount < 0) nCount = 0;
                }

                Menu1_2(Pr, nCount);
                keyDown = Console.ReadKey();
            } while (bFlag);
        }

        static int NumberEmp(List<Profession> Pr, Firma RG, int n)
        {
            int s = 0, v = 0;
            for (int j = 0; j < Pr.Count; j++)
            {
                for (int d = 0; d < RG.Count; d++)
                {
                    if (RG.ElementAt(d).RetProf() == Pr.ElementAt(j).Prof)
                    {
                        if (s == n)
                        {
                            v = RG.IndexOf(RG.ElementAt(d), 0);
                            d = RG.Count;
                            j = Pr.Count;
                            break;
                        }
                        else
                            s++;
                    }
                }
            }
            return v;
        }

        static void window()
        {
            //int left=20, top=Console.WindowTop-10;
            Console.SetWindowPosition(Console.WindowLeft, 0);
            int origWidth, origHeight;
            origWidth = (int)(Console.WindowWidth*1.1);
            origHeight = (int)(Console.WindowHeight * 2.5);
            Console.SetWindowSize(origWidth, origHeight);
            
        }
    }
}   
