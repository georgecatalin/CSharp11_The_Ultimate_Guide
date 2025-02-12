namespace ContravarianceExample
{
    public class LivingThings
    {
        public int NumberOfLegs { get; set; }

    }

    public class Bird : LivingThings
    {

    }

    public class Mammal : LivingThings
    {

    }


    interface Imover<in T>
    {
        void Move(T x);
    }


    public class Mover<T> : Imover<T>
    {
        public void Move(T x)
        {
            if (x is Bird)
            {
                Console.WriteLine("The Bird is moving with " + (x as Bird).NumberOfLegs);
            }
            else
            {
                Console.WriteLine("The Mammal is moving with " + (x as Mammal).NumberOfLegs);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Bird object1 = new Bird() { NumberOfLegs =2 };
            Mammal object2 = new Mammal() { NumberOfLegs = 4};

            Imover<Bird> object3 = new Mover<LivingThings>(); //this is contravariance child is expected, instead is provided parent
            object3.Move(object1);

            Imover<Mammal> object4 = new Mover<LivingThings>();
            object4.Move(object2);

            Console.ReadKey();
        }
    }
}
