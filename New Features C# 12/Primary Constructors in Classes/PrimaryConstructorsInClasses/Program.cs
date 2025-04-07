using System.Xml.Linq;

namespace PrimaryConstructorsInClasses
{
    public class NormalPerson
    {
        private string _name;
        private int _age;
        private string _gender;

        //constructor
        public NormalPerson( string name, int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        //method accessing the fields
        public void GetFields()
        {
            Console.WriteLine("{0} - {1} - {2}", _name, _age,_gender);
        }
    }

    public class PrimaryConstructorClass(string name, int age, string gender)
    {
        private string _name;
        private int _age;
        private string _gender;


        //method accessing the fields
        public void GetFields()
        {
            Console.WriteLine("{0} - {1} - {2}", this._name, this._age, this._gender); // the fields can not be accessed
            //Console.WriteLine("{0} - {1} - {2}", name, age, gender); // the fields can only be accessed through the parameters inside their class
        }
    }

    public class PrimaryConstructorPropertyInitClass(string name, int age, string gender)
    {
        public string Name { get; init; } = name;
        public int Age { get; init; } = age;
        public string Gender { get; init; } = gender;


        //method accessing the fields
        public void GetFields()
        {
            Console.WriteLine("{0} - {1} - {2}", Name, Age, Gender); // the properties can be accessed from outside the class , but only initialized once, and can not be reset
        }
    }

    public class PrimaryConstructorPropertyInitClass1(string name, int age, string gender)
    {
       private readonly string _name = name;
       private readonly int _age = age;
       private readonly string _gender = gender;


        //method accessing the fields
        public void GetFields()
        {
            Console.WriteLine("{0} - {1} - {2}", _name, _age, _gender); // 
            //this._age = 37; //readonly field
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //working with a normal class
            NormalPerson normalPerson = new NormalPerson("Mara", 14, "Female");
            normalPerson.GetFields();

            PrimaryConstructorClass primaryConstructorClass = new PrimaryConstructorClass("George", 46, "Male");
            primaryConstructorClass.GetFields();

            PrimaryConstructorPropertyInitClass primaryConstructorPropertyInitClass = new PrimaryConstructorPropertyInitClass("Sorina", 47, "Female");
            primaryConstructorPropertyInitClass.GetFields();    
            Console.WriteLine(primaryConstructorPropertyInitClass.Name); // can be accessed from outside
                                                                        


            PrimaryConstructorPropertyInitClass1 p = new PrimaryConstructorPropertyInitClass1("Zizou", 5, "Male");
            p.GetFields();
        }
    }
}
