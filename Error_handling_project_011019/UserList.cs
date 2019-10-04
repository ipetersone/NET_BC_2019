using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling_project_011019
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();
        // private, jo piekļūt vajag tikai klases ietvaros, nevis no citām klasēm, lai tajos nemainīt, drošības dēļ

        public void Add (string fullName, UserProfile.Genders gender, DateTime date)
        {
            //pārbaudes:

            //1. Datums nedrīkst būt nākotnē

            if (date > DateTime.Now)
            {
                throw new InputException("text"); // izsaukts exception konstruktors
            }

            //2. Nedrīkst būt mazāks par 01.01.1800

            if (...)
            {
                throw new InputException("text"); // izsaukts exception konstruktors
            }

            //3. Pilnais vārds nedrīkst pārsniegt 20 simbolus.

            if (...)
            {
                throw new InputException("text"); // izsaukts exception konstruktors
            }

            // lietotāja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            // lietotāja pievienošana sarakstam
            users.Add(user);
        }

    }
}
