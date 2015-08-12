#region Copyright
// COPYRIGHT 2015 JUSTIN COX (CONJI)
#endregion

using System;

namespace Stayn.Core.API
{
    public interface IDataManager<T>
    {
        T[] Data { get; set; }
        void Add(T value);
        void Remove(T value);
        void Remove(Predicate<T> value);
        T Find(Predicate<T> value);
        void Persist();
    }
}