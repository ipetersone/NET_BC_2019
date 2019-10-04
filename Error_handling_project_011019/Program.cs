using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling_project_011019
{
    class Program
    {
        static void Main(string[] args)
        {
            // +try catch 1 - generic, 2 - specifisks

            //definējam vienu user list:
            UserList list = new UserList();

            //1.Cikliski vaicā pievienot lietotājus
            while (true)
            {

                //1.1. Ievada vārdu - izveidot atsevišķu funkciju GetString

                string name = GetText();

                //1.2. Ievada datumu (DateTime.TryParse) - izveidot atsevišķu funkciju GetDate

                DateTime birthDate = GetDate;

                //1.3. Ievada dzimumu (Enum.TryParse) - izveidot atsevišķu funkciju GetGender

                UserProfile.Genders gender = GetGender; // TIPS.MAINĪGAIS = funkciju izsaucam

                //2. Izsauc lietotāja pievienošanu ar vērtībām augstāk
                list.Add();
                //3. Ja neizdevās pievienot, attēlo kļūdas paziņojumu
                // un sāk 1. soli no jauna

                // - lieks - var age = Math.Round(UserProfile.- DateTime.Now);

            }

            Console.Read();

        }

        public static DateTime GetDate ()
            // vispārīgās kopīgās pārbaudes
        {
            Console.Write ("Lūdzu ievadiet dzimšanas datumu: ");
            string input = Console.ReadLine(); // vienmēr viss ievadītais skaitās string
            if (DateTime.TryParse(input, out DateTime date)) // out - sintakse - izejošais parametrs
            {
                return date;
            }
            else
            {
                Console.WriteLine ("Invalid date!");
                return GetDate();
            }
        }

        public static string GetText ()
        {
            Console.Write("Lūdzu ievadiet pilno vārdu: ");
            string name = Console.ReadLine();
            name = name.Trim();

            if (!String.IsNullOrEmpty(name))
            {
                return name;
            }
            
            else
            
            {
                Console.WriteLine("Empty text!");
                return GetText();
            }
        }

        public static UserProfile.Genders GetGender()
            // parasti enumeratori vienā atsevišķā klasē, bet ja vienas klases ietvaros - tad var likt arī klases ietvaros
        {
            Console.Write("Lūdzu ievadiet savu dzimumu: ");

            string value = Console.ReadLine(); // vienmēr viss ievadītais skaitās string
            if (Enum.TryParse(value, true, out UserProfile.Genders gender)) // out - sintakse - izejošais parametrs
                // true - ignore case (lielie, mazie burti - apstrādā un nolasa jebkuru gadījumu, 
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value!");
                return GetGender();
            }
        }
    }
}
