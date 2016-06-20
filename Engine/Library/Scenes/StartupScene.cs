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

        public List<GUIElement> GUIElements;
        Image bishop;
        Image knight;
        Image board;
        Label label;

        public override void Load()
        {
            Game.Instance.IsMouseVisible = true;
            mouseHandler = new MouseHandler();
            GUIElements = new List<GUIElement>();

            bishop = new Image(200, 200, 50, 50, 0, "Bishop", 1) { isDraggable = true };
            knight = new Image(200, 350, 50, 50, 0, "Knight", 1) { isDraggable = true };
            board = new Image(0, 0, 600, 600, 0, "ChessBoard", 0);
            GUIElements.Add(board);
            GUIElements.Add(bishop);
            GUIElements.Add(knight);
            
            TransformComponent transform = new TransformComponent(new Vector2(10, 10));
            label = new Label("Teste (:", "defaultFont", Color.Crimson, transform);
            GUIElements.Add(label);

            mouseHandler.Click += new MouseHandler.MouseClickHandler(HandleClick);
            mouseHandler.Hover += new MouseHandler.MouseClickHandler(HandleHover);
            mouseHandler.Drag += new MouseHandler.MouseDragHandler(HandleDrag);
        }

        public override void Unload(Scene newScene)
        {
            Game.Instance.ActualScene = newScene;
        }

        public override void ClearScreen()
        {
            Game.Instance.GraphicsDevice.Clear(Color.White);
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
        }

        private void HandleClick(GUIElement listener, MouseState mouseState)
        {
        }

        private void HandleDrag(GUIElement listener, int xRel, int yRel)
        {
            if (listener.Equals(bishop))
            {
                listener.transform.Translate(xRel, yRel);
            }
            if (listener.Equals(knight))
            {
                listener.transform.Translate(xRel, yRel);
            }
        }

        private void HandleHover(GUIElement listener, MouseState mouseState)
        {
        }
    }
}
