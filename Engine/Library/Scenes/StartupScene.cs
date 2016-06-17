using System.Collections.Generic;
using Engine.Library.GameObjects;
using Microsoft.Xna.Framework;
using Engine.Library.GUI.Core;
using Engine;
using Engine.Library.Input;
using Microsoft.Xna.Framework.Input;
using System;

namespace Engine.Library.Scenes
{
    /// <summary>
    /// Use this to initialize other scenes or if your game doesn't have any scene yet
    /// </summary>
    class StartupScene : Scene
    {
        public override SceneState ActualState { get; set; }
        public override List<GameObject> GameObjects { get; set; }

        MouseHandler mouseHandler;
        public List<Button> GUIElements { get; set; }
        Button button;
        Button button2;
        Button button3;

        public override void Load()
        {
            Game.Instance.IsMouseVisible = true;
            mouseHandler = new MouseHandler();
            GUIElements = new List<Button>();

            button = new Button(200, 200, 200, 80, 0, "texture", 0);
            button2 = new Button(200, 300, 200, 80, 0, Color.Crimson, 0);
            button3 = new Button(200, 350, 180, 120, 0, "texture", 0);
            GUIElements.Add(button);
            GUIElements.Add(button2);
            GUIElements.Add(button3);

            mouseHandler.Click += new MouseHandler.MouseClickHandler(HandleClick);
            mouseHandler.Hover += new MouseHandler.MouseClickHandler(HandleHover);
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
            mouseHandler.Update(GUIElements);
        }

        public override void Draw(GameTime gameTime)
        {
            Game.Instance.spriteBatch.Begin();
            foreach (var button in GUIElements)
            {
                button.Draw();
            }
            Game.Instance.spriteBatch.End();

            //button2.Draw();
        }

        private void HandleClick(Button listener, MouseState mouseState)
        {
            if (listener.Equals(button))
            {
                listener.Visible = !listener.Visible;
            }
            if (listener.Equals(button3))
            {
                listener.Visible = !listener.Visible;
            }
        }

        private void HandleHover(Button listener, MouseState mouseState)
        {
            if (listener.Equals(button))
            {
                listener.Visible = !listener.Visible;
            }
            if (listener.Equals(button3))
            {
                listener.Visible = !listener.Visible;
            }
        }
    }
}
