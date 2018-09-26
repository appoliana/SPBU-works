using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [Serializable]
    public class NotImplementedException : ApplicationException
    {
        public NotImplementedException() { }
        public NotImplementedException(string message) : base(message) { }
        public NotImplementedException(string message, Exception inner) : base(message, inner) { }
        protected NotImplementedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
