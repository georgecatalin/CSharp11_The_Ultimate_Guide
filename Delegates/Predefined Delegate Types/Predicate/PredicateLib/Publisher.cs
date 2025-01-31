namespace PredicateLib
{
    public class Publisher
    {
        public event Predicate<int> theEvent;

        public bool RaiseEvent(int a)
        {
            if (theEvent != null)
            {
                bool c = theEvent(a);
                return c;
            }
            else
            {
                return false;
            }
        }
    }
}
