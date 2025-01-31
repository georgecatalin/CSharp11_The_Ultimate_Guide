namespace ActionLib
{
    // we use the special type of Delegate called Action when we need not to return anything, opposite to Func when we wish to return something from the delegate

    public class Publisher
    {
        public event Action<int, int> thisEvent;

        public void RaiseEvent(int a, int b)
        {
            if (thisEvent != null)
            {
                thisEvent(a, b);
            }
        }
        
    }
}
