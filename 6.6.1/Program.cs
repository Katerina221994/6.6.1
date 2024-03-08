using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6._1
{
    internal class Program
    {

        static string CreateString(string message)
        {
            Console.WriteLine(message);
            String file = "#" + Console.ReadLine();
            return file;


        }
        static string CreateEmploee()
        {
            string id = CreateString("Введите id сотрудника: ");
            string fullName = CreateString("Введите полное имя сотрудника: ");
            string age = CreateString("Введите возраст сотрудника: ");
            string height = CreateString("Введите рост сотрудника: ");
            string dateBirth = CreateString("Введите дату рождения сотрудника: ");
            string birthPlace = CreateString("Введите место рождения сотрудника: "); 
            

            string emploee =  id + "#" + DateTime.Now + fullName + age + height + dateBirth + birthPlace;
            return emploee;

        }
        static void ReadFille(){
            string line = "";
            string file = "EmployeesList.txt";
            if (File.Exists(file)) {
                using (StreamReader sR = new StreamReader("EmployeesList.txt"))
                {
                    while ((line = sR.ReadLine()) != null)
                    {
                        Console.WriteLine(line.Replace("#", " "));
                    }

                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
                
            }
        }
        static void WriteFille() {
            using (StreamWriter sw = new StreamWriter("EmployeesList.txt", append: true))
            {
                    sw.WriteLine(CreateEmploee());
                    Console.WriteLine("Запись сохранена");
               
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Веведите 1, для вывода данных на экран, введите 2, чтобы дополнить данные");
            string concol = Console.ReadLine();

            if(concol == "1")
            {
                ReadFille();
               
            }else if(concol == "2")
            {
                WriteFille();

            }
            Console.ReadLine();
        }
    }
}
