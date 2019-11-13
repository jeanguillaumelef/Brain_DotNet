using BusinessLogic.Interfaces.Storage;
using System;

namespace BusinessLogic.Models
{
    public class Alert : IStorable
    {
        public DateTime DateTime { get; set; }
        public Guid Id { get; }
        public Message Message { get; set; }

        /// <summary>
        /// Create an alert
        /// </summary>
        public Alert(DateTime dateTime)
        {
            Id = Guid.NewGuid();
            DateTime = dateTime;
        }

        /// <summary>
        /// Create an alert with a new message
        /// </summary>
        public Alert(DateTime dateTime, string text)
        {
            Id = Guid.NewGuid();
            DateTime = dateTime;
            Message = new Message(text);
        }

        /// <summary>
        /// Create an existing alert
        /// </summary>
        public Alert(Guid id, DateTime dateTime, Message message)
        {
            Id = id;
            DateTime = dateTime;
            Message = message;
        }
    }
}
