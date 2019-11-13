using System;
using BusinessLogic.Interfaces.Storage;
using BusinessLogic.Models;

namespace BusinessLogic
{
    public class MessageService : IStorer<Message>
    {
        private readonly IStorage storage;

        public MessageService(IStorage storage)
        {
            this.storage = storage;
        }

        public StorageRequestStatus Delete(Message item)
        {
            return storage.Delete(item);
        }

        public Message Get(Guid id, out StorageRequestStatus status)
        {            
            Message result;

            result = (Message)storage.Get(typeof(Message), id, out status);

            return result;
        }

        public StorageRequestStatus Save(Message item)
        {
            throw new NotImplementedException();
        }
    }
}
