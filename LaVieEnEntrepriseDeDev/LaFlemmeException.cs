using System.Runtime.Serialization;

namespace LaVieEnEntrepriseDeDev
{
    internal class LaFlemmeException : Exception
    {
        public LaFlemmeException()
        {
        }

        public LaFlemmeException(string? message) : base(message)
        {
        }

        public LaFlemmeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LaFlemmeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public Code? CodeCourant
        {
            get => this.Data["CodeCourant"] as Code;
            set => this.Data["CodeCourant"] = value;
        }
    }
}
