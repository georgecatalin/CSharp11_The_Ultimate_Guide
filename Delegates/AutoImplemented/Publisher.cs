namespace AutoImplemented
{

    public delegate void MyDelegateType(int a, int b);

    public class Publisher
    {
        public event MyDelegateType thisEvent;

        public void RaiseEvent(int a, int b)
        {
            if (thisEvent != null)
            {
                thisEvent(a, b);
            }
        }
    }
}
