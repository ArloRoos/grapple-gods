using System;

namespace grapple_gods;

public interface IUpdateable
{
    /// <summary>
    /// Updates this object in the current game frame.
    /// </summary>
    void Update();
}