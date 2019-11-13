using System;
using BusinessLogic;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Storage;

namespace NoSqlDatabase
{
    public class DynamoDbService : IStorage
    {
        public StorageRequestStatus Delete(IStorable item)
        {
            throw new NotImplementedException();
        }

        public IStorable Get(Type type, Guid id, out StorageRequestStatus status)
        {
            throw new NotImplementedException();
        }

        public StorageRequestStatus Save(IStorable item)
        {
            throw new NotImplementedException();
        }
    }
}
