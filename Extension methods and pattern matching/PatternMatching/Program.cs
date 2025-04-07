using System;
using ClassLibrary3;

public class Program
{
    static void Main()
    {
        Parent p;

        p = new Child() { x = 1, y = 2 };

        Console.WriteLine(p.x);

        if (p is Child)
        {
            Child c = (Child) p; // typecasting the parent to the child class
            Console.WriteLine(c.x);
            Console.WriteLine(c.y);

            
        }

        /* The new way of doing the same thing with Pattern matching */
        if(p is Child cc)
        {
            Console.WriteLine(cc.x);
            Console.WriteLine(cc.y);
        }

        Console.ReadKey();
    }
}