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
                        First(ref Pr);
                    }
                    else Second(ref RG);
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

        static void Searce1(ref List<Profession> Pr)
        {
            int nCount = 0;
            Menu1(nCount);
            var keyDown = Console.ReadKey();
            bool bFlag = true;

            do
            {
                Console.Clear();

                if (keyDown.Key == ConsoleKey.Enter)
                {

                    bFlag = true;
                    if (nCount == 2)
                    {
                        bFlag = false;
                        break;
                    }
                    if (nCount == 0)
                    {
                        ADD1(ref Pr);
                    }
                    else Delete1(ref Pr);
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

        static void First(ref List<Profession> Pr)
        {
            Searce1(ref Pr);
        }

        static void Second(ref Firma RG)
        {

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

        static void Menu2(int nCount)
        {
            var obj1 = new bool[4];
            string[] objPr = new string[] 
            { "Добавить", 
               "Редактировать",
               "Удалить",
               "Выход",
             };

            for (int i = 0; i < obj1.Length; i++)
            {
                if (i == nCount) obj1[nCount] = true;
                else obj1[i] = false;
            }
            Console.WriteLine("\n\t\t\tПеречень сотрудников.");
            Console.WriteLine("\n\t\t\t-------------------");
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

        static void ADD1(ref List<Profession> Pr)
        {

        }

        static void Delete1(ref List<Profession> Pr)
        {

        }
    }
}   
