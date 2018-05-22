using System;

namespace QueueWithPriority
{
    [Serializable]
    class RemoveFromEmptyQueueException : ApplicationException
    {
        public RemoveFromEmptyQueueException() { }
        public RemoveFromEmptyQueueException(string message) : base(message) { }
        public RemoveFromEmptyQueueException(string message, Exception inner) : base(message, inner) { }
        protected RemoveFromEmptyQueueException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
