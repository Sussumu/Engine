using System.Collections.Generic;
using Engine.Library.GameObjects;
using Microsoft.Xna.Framework;
using Engine.Library.GUI.Core;
using Engine;

namespace Engine.Library.Scenes
{
    /// <summary>
    /// Use this to initialize other scenes or if your game doesn't have any scene yet
    /// </summary>
    class StartupScene : Scene
    {
        public override SceneState ActualState { get; set; }
        public override List<GameObject> GameObjects { get; set; }

        Button button;

        public override void Load()
        {
            button = new Button(20, 20, 150, 80, 0, Color.Firebrick, 1);
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
            button.Draw();
        }
    }
}
