using System;
namespace DbPreparation
{
    public interface IPropertyEnumerator
    {
        bool Any(Func<object, bool> action);
    }
}