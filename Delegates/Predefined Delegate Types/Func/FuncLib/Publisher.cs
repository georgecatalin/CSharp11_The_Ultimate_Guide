namespace FuncLib
{
    public class Publisher
    {
        public event Func<int, int, int> thisEvent; //there is no need to define the Delegate type beforehand, one can use the special type of delegate which is func
        /* we use func only when returning values */

        public int RaiseEvent(int a, int b)
        {
            if (thisEvent != null)
            {
                int c = a + b;
                return c;
            }
            else
            {
                return 0;
            }
        }

    }
}
