using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public enum Gender { male, female }
    public class FamilyMembers
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get; set; }
        public FamilyMembers? Mother { get; set; }
        public FamilyMembers? Father { get; set; }
        public FamilyMembers? Spouse { get; set; } //супруг

        public FamilyMembers[] GetGrandMotherName()
        {
            return new FamilyMembers[] { Mother?.Mother, Father?.Mother };
        }

        public FamilyMembers[] GetGrandFatherName()
        {
            return new FamilyMembers[] { Mother?.Father, Father?.Father };
        }

        public FamilyMembers GetCloseRelatives()
        {
            return Spouse;
        }

        public void ShowGrandMothers()
        {
            Console.WriteLine("Бабушки:");
            if (Mother.Mother != null)
            {
                Console.WriteLine("\t" + Mother.Mother.FullName);
            }
            else 
            {
                Console.WriteLine("\t" + "Бабушка со стороны матери не указана");
            }
            if (Father.Mother != null)
            {
                Console.WriteLine("\t" + Father.Mother.FullName);
            }
            else 
            {
                Console.WriteLine("\t" + "Бабушка со стороны отца не указана");
            }
        }
        public void ShowGrandFathers()
        {
            Console.WriteLine("Дедушки:");
            if (Mother.Father != null)
            {
                Console.WriteLine("\t" + Mother.Father.FullName);
            }
            else 
            {
                Console.WriteLine("\t" + "Дедушка со стороны матери не указан");
            }
            if (Father.Father != null)
            {
                Console.WriteLine("\t" + Father.Father.FullName);
            }
            else 
            {
                Console.WriteLine("\t" + "Дедушка со стороны отца не указан");
            }
        }

        public void ShowRelatives()
        {
            if (Spouse != null)
            {
                if (Spouse.Gender == Gender.male) Console.Write("Муж: ");
                else Console.Write("Жена: ");

                Console.WriteLine(Spouse.FullName);
            }
            else
            {
                Console.WriteLine("Супруг отсутствует");
            }
        }
    }
}