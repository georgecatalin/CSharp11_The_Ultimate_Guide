namespace TupleClassLib
{
    public class Details
    {
        public Tuple<string,int> GetDetails()
        {
            Tuple<string,int> result = new Tuple<string,int>("George Calin", 1978);

            return result;
        }
    }
}
