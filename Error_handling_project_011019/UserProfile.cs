using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling_project_011019
{
    public class UserProfile
    {


        public string FullName { get; set; }


        public DateTime BirthDate { get; set; }

        // 1.variants
        //public const char MALE = 'M';
        //public const char FEMALE = 'F';
        //public char Gender { get; set; }

        //2. variants - enum, labāks - pārskaitījums:
        public enum Genders
        {
            Male,
            Female
        }
        // prop + tab + tab - zemāk esošā konstrukcija
        public Genders Gender { get; set; }

        // tālāk konstruktors, bet var iztikt bez tā, jo ir publiskās funkcijas
        // ar labo click - izvēlēties quick actions, constructor - būs ar parametriem, bet ja ar cntr tab tab , tad būs tukšs

        public UserProfile (string fullName, DateTime birthDate, Genders gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public int Age()
            // iekavās nedefinējam birthDate, jo augšā klasē ir norādīts jau, definējam iekavās tikai jaunos parametrus
        {
            // calculate age using BirthDate
            return 0;
        }

    }
}