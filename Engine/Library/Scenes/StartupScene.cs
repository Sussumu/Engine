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

        Button button = new Button(200, 200, 200, 80, 0, "texture", 0);
        Button button2 = new Button(200, 300, 200, 80, 0, Color.Crimson, 0);

        public override void Load()
        {

        }

        public override void Unload(Scene newScene)
        {
            Game.Instance.ActualScene = newScene;
        }

        public override void ClearScreen()
        {
            Game.Instance.GraphicsDevice.Clear(Color.Wheat);
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(GameTime gameTime)
        {
            Game.Instance.spriteBatch.Begin();
            button.Draw();
            Game.Instance.spriteBatch.End();

            button2.Draw();
        }
    }
}
