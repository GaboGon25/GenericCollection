using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class FullStackException : Exception
    {
        // parameterless constuctor
        public FullStackException() : base("Stack is full")
        {
            // empty constrcutor
        }
        
        // one-parameter constructor
        public FullStackException(string? message) : base(message)
        {
        }

        // two-parameter constructor
        public FullStackException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FullStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}