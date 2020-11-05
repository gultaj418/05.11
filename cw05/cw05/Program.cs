using System;

namespace cw05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            //person.name = "Patric";
            //person.surname = "Bob";

            //Person[] persons = new Person[5];

            //Person person1 = new Person
            //{
            //    name = "Jeff",
            //    surname = "Bezos"
            //};

            //Person person2 = new Person
            //{
            //    name = "Steve",
            //    surname = "Jobs"
            //};

            //Person person3 = new Person
            //{
            //    name="Bill",
            //    surname= "Gates"
            //};
            //Person person4 = new Person
            //{
            //    name = "Graham",
            //    surname = "Bell"
            //};
            //Person person5 = new Person
            //{
            //    name = "Albert",
            //    surname="Einstein"
            //};

            //persons[0] = person1;
            //persons[1] = person2;
            //persons[2] = person3;
            //persons[3] = person4;
            //persons[4] = person5;

            //for (int i = 0; i <persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i].name);
            //}


            //Console.WriteLine("***************************");

            //Person[] reverseName = Reverse(persons);


            //for (int i = 0; i < persons.Length; i++)
            //{

            //    Console.WriteLine(reverseName[i].name);
            //}



            Console.WriteLine("Eded daxil edin(array olcusu):");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[size];

            //names[0] ="gultac";


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Ad daxil edin:");
                string name = Console.ReadLine();
                names[i] = name;

            }

            addNewName:

            Console.WriteLine("yeni bir ad daxil etmek isteyirsiz?(y/n)");
            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Console.WriteLine("Ad daxil edin:");
                string newName = Console.ReadLine();
                Array.Resize(ref names, names.Length+1);
                names[names.Length-1] = newName;
                goto addNewName;
            }
            else if (choice != "n")
            {
                goto addNewName;
            }




            Console.WriteLine("Adlar:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);


            }




        }
        
        //public static Person[] Reverse(Person[] persons)
        //{
        //    //string[] obbject = new string[persons.Length];

        //    Person[] reversedPeople = new Person[persons.Length];

        //    for (int i = 0; i < persons.Length; i++)
        //    {
        //        reversedPeople[persons.Length - (i + 1)] = persons[i];
        //    }
        //    return reversedPeople;
        //}
    }
}
