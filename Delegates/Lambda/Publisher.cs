namespace Lambda
{
    public delegate int  MyDelegateType(int a, int b);

    public class Publisher
    {
        public event MyDelegateType thisEvent;

        public int RaiseEvent(int a, int b)
        {
            if (thisEvent != null)
            {
                int x = thisEvent(a, b);
                    return x;
            }
            else
            {
                return 0;
            }

        }
    }
}
