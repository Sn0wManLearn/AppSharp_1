using System;

namespace FamilyTree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            FamilyMembers GrandFatherOne = new FamilyMembers()
            {
                FullName = "Иванов Иван Иванович",
                Age = 50,
                Gender = Gender.male
            };

            FamilyMembers GrandFatherSecond = new FamilyMembers()
            {
                FullName = "Иванов Петр Петрович ",
                Age = 51,
                Gender = Gender.male
            };

            FamilyMembers GrandMother = new FamilyMembers()
            {
                FullName = "Петрова Мария Дмитриевна ",
                Age = 60,
                Gender = Gender.female
            };

            FamilyMembers GrandMotherSecond = new FamilyMembers()
            {
                FullName = "Смирнова Екатрина Ивановна ",
                Age = 48,
                Gender = Gender.female
            };

            FamilyMembers Mother = new FamilyMembers()
            {
                FullName = "Петрова Вера Ивановна ",
                Age = 30,
                Gender = Gender.female,
                Father = GrandFatherSecond,
                Mother = GrandMotherSecond
            };

            FamilyMembers Father = new FamilyMembers()
            {
                FullName = "Петрова Кирилл Иванович ",
                Age = 35,
                Gender = Gender.male,
                Father = GrandFatherOne,
                Mother = GrandMother
            };

            FamilyMembers Son = new FamilyMembers()
            {
                FullName = "Петров Аркадий Кириллович ",
                Age = 16,
                Gender = Gender.male,
                //Mother = Mother,
                Father = Father
            };

            var GrandMothers = Son.GetGrandMotherName();

            Console.WriteLine(GrandMothers[0]?.FullName);
            Console.WriteLine(GrandMothers[1]?.FullName);

        }

    }

}
