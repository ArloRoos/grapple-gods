using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace grapple_gods;

public static class GameEnvironment
{
    public static SpriteBatch Batch { get; private set; }
    public static float Dt { get; private set; }

    public static void Initialize(SpriteBatch spriteBatch)
    {
        Batch = spriteBatch;
        Dt = 0;
    }

    public static void Update(GameTime gameTime)
    {
        Dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
    }
}