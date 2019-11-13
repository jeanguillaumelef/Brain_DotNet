using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Storage;
using System;

namespace BusinessLogic.Models
{
    public class Message : IStorable
    {
        public string Text { get; set; }
        public Guid Id { get; }

        /// <summary>
        /// Create a new nessage
        /// </summary>        
        public Message(string text)
        {
            Text = text;
            Id = Guid.NewGuid();
        }

        //Create an existing message
        public Message(Guid id)
        {            
            Id = id;
        }
    }
}
