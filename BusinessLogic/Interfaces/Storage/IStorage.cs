using System;

namespace BusinessLogic.Interfaces.Storage
{
    public interface IStorage
    {
        StorageRequestStatus Save(IStorable item);
        IStorable Get(Type type, Guid id, out StorageRequestStatus status);        
        StorageRequestStatus Delete(IStorable item);
    }
}
