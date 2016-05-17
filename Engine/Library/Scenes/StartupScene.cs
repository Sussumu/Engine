using System.Collections.Generic;
using Engine.Library.GameObjects;
using Microsoft.Xna.Framework;

namespace Engine.Library.Scenes
{
    /// <summary>
    /// Use this to initialize other scenes or if your game doesn't have any scene yet
    /// </summary>
    class StartupScene : Scene
    {
        public override SceneState ActualState { get; set; }
        public override List<GameObject> GameObjects { get; set; }
        
        public override void Load()
        {
            
        }

        public override void Unload(Scene newScene)
        {
            Game.Instance.ActualScene = newScene;
        }

        public override void ClearScreen()
        {
            Game.Instance.GraphicsDevice.Clear(Color.AliceBlue);
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(GameTime gameTime)
        {
            
        }
    }
}
