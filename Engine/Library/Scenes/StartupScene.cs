using System.Collections.Generic;
using Engine.Library.GameObjects;
using Microsoft.Xna.Framework;
using Engine.Library.GUI.Core;
using Engine.Library.Input;
using Microsoft.Xna.Framework.Input;
using Engine.Library.Components;

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
        public List<GUIElement> GUIElements { get; set; }
        Button button;
        Button button2;
        Button button3;
        Label label;

        public override void Load()
        {
            Game.Instance.IsMouseVisible = true;
            mouseHandler = new MouseHandler();
            GUIElements = new List<GUIElement>();

            button = new Button(200, 200, 200, 80, 0, "texture", 0);
            button2 = new Button(200, 300, 200, 80, 0, Color.Crimson, 0);
            button3 = new Button(200, 350, 180, 120, 0, "texture", 0);
            GUIElements.Add(button);
            GUIElements.Add(button2);
            GUIElements.Add(button3);

            TransformComponent transform = new TransformComponent(new Vector2(100, 100));
            label = new Label("teste teste teste", "defaultFont", Color.Crimson, transform);
            GUIElements.Add(label);

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
            foreach (GUIElement element in GUIElements)
            {
                element.Draw();
            }
            Game.Instance.spriteBatch.End();

            //button2.Draw();
        }

        private void HandleClick(GUIElement listener, MouseState mouseState)
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

        private void HandleHover(GUIElement listener, MouseState mouseState)
        {
            if (listener.Equals(label))
            {
                listener.transform.Scale(1.1f);
            }
        }
    }
}
