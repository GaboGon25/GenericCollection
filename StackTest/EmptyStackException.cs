using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class EmptyStackException : Exception
    {
        public EmptyStackException(): base("Stack is empty")
        {
        }

        public EmptyStackException(string? message) : base(message)
        {
        }

        public EmptyStackException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}