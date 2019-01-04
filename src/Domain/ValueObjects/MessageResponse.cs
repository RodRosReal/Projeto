using System.Collections.Generic;

namespace Domain.ValueObjects
{
    public class MessageResponse
    {
        protected List<Message> _messages = new List<Message>();

        public List<Message> ListMessage
        {
            get
            {
                return _messages;
            }
        }

        public void Add(StatusSeverity severity, string description, int timeOut = 3000, bool closeable = false)
        {
            this._messages.Add(new Message()
            {
                Severity = severity,
                Description = description,
                TimeOut = timeOut,
                Closeable = closeable
            });
        }

        public struct Message
        {
            public StatusSeverity Severity;
            public string Description;
            public int TimeOut;
            public bool Closeable;
        }
    }

    public enum StatusSeverity
    {
        None = 0,
        Success = 1,
        Info = 2,
        Warning = 3,
        Error = 4,
        Redirect = 5
    }
}
