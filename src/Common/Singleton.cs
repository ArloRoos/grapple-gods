using System;

namespace grapple_gods;

public abstract class Singleton<T>
    where T : Singleton<T>
{
    private static readonly Lazy<T> Lazy =
        new(() => (Activator.CreateInstance(typeof(T), true) as T)!);

    public static T Instance => Lazy.Value;
}
