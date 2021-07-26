using System;

namespace SampleForValueTypeReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            var sergey = new Person() { Name = "Sergey", Age = 30 };

            Accaunt accaunt1 = new Accaunt() { AccauntId = 1, person = sergey };
            Accaunt accaunt2 = accaunt1;

            accaunt2.AccauntId = 2;
            accaunt2.person.Name = "Olga";

            Person andrey = new Person() { Name = "Andrey", Age = 10 };
            Person anatolii =  RenamePerson(andrey);


            int A = 2;
            int B = 1;
            Calc(A,B);
        }

        public static object Calc(object a, object b)
        {
            return (int)a + (int)b;
        }

        public static Person RenamePerson(Person person)
        {
            //person.Name = "Anatolii";
            person = new Person() { Name = "Anatolii" };
            return person;
        }
    }
}
