using System;

namespace UniqueList
{
    [Serializable]
    public class AddExistingElementException : ApplicationException
    {
        public AddExistingElementException() { }
        public AddExistingElementException(string message) : base(message) { }
        public AddExistingElementException(string message, Exception inner) : base(message, inner) { }
        protected AddExistingElementException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
