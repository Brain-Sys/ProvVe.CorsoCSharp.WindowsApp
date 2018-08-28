using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel.CustomExceptions
{
    public class FPTException : Exception
    {
        public FPTException()
        {
        }

        public FPTException(string message) : base(message)
        {
        }

        public FPTException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FPTException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public int A { get; set; }
        public string B { get; set; }
    }
}