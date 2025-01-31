namespace InlineLambda
{
    public delegate int MyDelegateType(int a, int b);

    public class Publisher
    {
        public event MyDelegateType thisEvent;

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
