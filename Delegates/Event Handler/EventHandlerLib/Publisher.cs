using System.Data;

namespace EventHandlerLib
{
    public class CustomEventArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public class Publisher
    {
        public event EventHandler<CustomEventArgs> thisEvent;


        public void RaiseEvent(object sender,int a, int b )
        {
            if (thisEvent != null)
            {
                CustomEventArgs custom = new CustomEventArgs() { a = a, b = b };
                this.thisEvent(sender,custom);
            }
        }
    }
}
