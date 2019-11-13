using System;

namespace BusinessLogic.Interfaces.Storage
{
    public interface IStorer<T> where T : IStorable
    {
        T Get(Guid id, out StorageRequestStatus status);
        StorageRequestStatus Save(T item);
        StorageRequestStatus Delete(T item);
    }
}
