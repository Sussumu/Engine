using Engine.Library.GameObjects;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Engine.Library.Scenes
{
    /// <summary>
    /// Represents the state of the Scene. Useful to react to win/lose/pause conditions.
    /// </summary>
    public enum SceneState
    {
        PLAYING,
        WON,
        LOSE,
        PAUSED
    }

    public abstract class Scene
    {
        public abstract List<GameObject> GameObjects { get; set; }
        public abstract SceneState ActualState { get; set; }
        
        public abstract void Load();
        public abstract void Unload(Scene newScene);
        public abstract void ClearScreen();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);
    }
}
