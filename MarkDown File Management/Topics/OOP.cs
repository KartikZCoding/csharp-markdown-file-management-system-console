using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicRunner.Topics
{
    static class OOP
    {
        private struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }
        }
        public static void Topic01_Structures()
        {
            TopicHelper.PrintingHeading("Structures");

            /*string name = "Kartik";
            int age = 21;
            int birthMonth = 8;

            Person person;
            person.name = "Kartik";
            person.age = 21;
            person.birthMonth = 8;

            Console.WriteLine($"{name} : {age} : {birthMonth}");
            Console.WriteLine($"{person.name} : {person.age} : {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            int newBirthMonth = 0;
            ReturnPerson(ref newName, ref newAge, ref newBirthMonth);
            Console.WriteLine($"{newName} : {newAge} : {newBirthMonth}");*/

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} : {person.age} : {person.birthMonth} : {person.number}");

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static Person ReturnPerson()
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month : ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            /*Person person;
            person.name = name;
            person.age = age;
            person.birthMonth = birthMonth;
            person.number = number;

            return person;*/

            return new Person(name, age, birthMonth, number);
        }

        /* private static void ReturnPerson(ref string name, ref int age, ref int birthMonth)
        {
            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month : ");
            birthMonth = Convert.ToInt32(Console.ReadLine());
        }*/



        /* struct Person // you just create a only one construture with default values & struct cannot have parameter less constructure
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        } */

        private class Person1 // here you can create a multiple constructure with or without default values
        {
            public string name;
            public int age;

            public Person1()
            {
            }
            public Person1(string name)
            {
                this.name = name;
                this.age = 0;
            }
            public Person1(int age)
            {
                this.name = "";
                this.age = age;
            }
            public Person1(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        public static void Topic02_Classes()
        {
            TopicHelper.PrintingHeading("Classes");

            Person1 person = new Person1("Kartik", 21);
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }


        private class Person2
        {
            public string name;
            public int age;


            public Person2(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name : {name}\nAge : {age}";
            }
        }

        public static void Topic03_Methods()
        {
            TopicHelper.PrintingHeading("Methods");

            Person2 person = new Person2("Kartik", 21);
            //Console.WriteLine($"Name : {person.name}\nAge : {person.age}");
            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        /* private static string ReturnDetails(Person person)
        {
            return $"Name : {person.name}\nAge : {person.age}";
        } */

        /* private static string ReturnDetails(string name, int age)
        {
            return $"Name : {name}\nAge : {age}";
        } */


        class Person3
        {
            private string name;
            private int age;

            public Person3(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";

            public string GetName() => name;

            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;

            public int GetAge() => age;


            public string ReturnDetails()
            {
                return $"Name : {name}\nAge : {age}";
            }
        }
        public static void Topic04_ClassFields()
        {
            TopicHelper.PrintingHeading("Class fields");

            Person3 person = new Person3("Kartik", 21);
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is {person.GetName()} and Your age is {person.GetAge()}");

            /* person.name = "Hello"; //here we can change the values so thats why we use getter and setter
            person.age = 23;
            Console.WriteLine(person.ReturnDetails()); */

            person.SetName("Kartik Ahir");
            person.SetAge(22);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.GetName()} and Your age is {person.GetAge()}");

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }


        class Person4
        {
            //Auto implemented properties
            //public string Name { get; set; }
            //public int Age { get; set; }

            private string name;
            private int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value >= 0 && value <= 150 ? value : -1;
                }
            }

            public Person4(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            /*
            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";

            public string GetName() => name;

            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;

            public int GetAge() => age;
            */

            public string ReturnDetails()
            {
                return $"Name : {Name}\nAge : {Age}";
            }
        }
        public static void Topic05_ClassProperties()
        {
            TopicHelper.PrintingHeading("Class properties");

            Person4 person = new Person4("Kartik", 21);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Hello";
            person.Age = 1000;
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is : {person.Name}");
            Console.WriteLine($"Your age is : {person.Age}");

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }



        class Person5
        {
            private string name;
            private int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value >= 0 && value <= 150 ? value : -1;
                }
            }


            public Person5(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            //public string ReturnDetails()
            //{
            //    return $"Name : {Name}\nAge : {Age}";
            //}

            public override string ToString()
            {
                return $"Name : {Name}\nAge : {Age}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Person5)
                {
                    Person5 person = obj as Person5;
                    return Name.Equals(person.Name) && Age == person.Age;
                }

                return false;
            }
        }

        public static void Topic06_ToStringFunctionOverride ()
        {
            TopicHelper.PrintingHeading("ToString function override");

            Person5 person = new Person5("Kartik", 21);
            Person5 test = new Person5("Kartik", 21);
            Console.WriteLine(person);
            //Console.WriteLine(person.ToString());
            //Console.WriteLine(person.ReturnDetails());

            if (person.Equals(test))
            {
                Console.WriteLine("Same!");
            }
            else
            {
                Console.WriteLine("Not same!");
            }

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }
    }
}
