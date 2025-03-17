namespace BankProject.Exceptions
{
    /// <summary>
    /// An exception class that refers to all errors raised in the Customer Class
    /// </summary>
    public class CustomerException : ApplicationException
    {
        /// <summary>
        /// A constructor to specify the message of the exception
        /// </summary>
        /// <param name="message">exception message</param>
       public CustomerException(string message) : base(message)
        {

        }
        /// <summary>
        /// A constructor to specify the message and inner exception of the custom defined exception class
        /// </summary>
        /// <param name="message">exception message</param>
        /// <param name="innerException">inner exception of the exception</param>
        public CustomerException(string message, Exception innerException) : base(message,innerException)
        {

        }
    }
}
