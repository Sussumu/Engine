using Engine.Library.GUI.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Engine.Library.Input
{
    class MouseHandler
    {
        MouseState mouseState, oldMouseState;

        // Event to mouse clicks
        public delegate void MouseClickHandler(Button button, MouseState mouseState);
        public event MouseClickHandler Click;
        public event MouseClickHandler Hover;

        public void Update(List<Button> GUIElements)
        {
            mouseState = Mouse.GetState();

            // Click
            if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released &&
                oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                foreach (Button button in GUIElements)
                {
                    if (button.Contains(new Vector2(mouseState.X, mouseState.Y)))
                    {
                        OnClick(button, mouseState);
                    }
                }
            }
            // Hover
            else if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                foreach (Button button in GUIElements)
                {
                    if (button.Contains(new Vector2(mouseState.X, mouseState.Y)))
                    {
                        OnHover(button, mouseState);
                    }
                }
            }

            oldMouseState = mouseState;
        }

        // Raise the event to mouse click
        protected virtual void OnClick(Button button, MouseState mouseState)
        {
            Click(button, mouseState);
        }

        // Raise the event to mouse hover
        protected virtual void OnHover(Button button, MouseState mouseState)
        {
            Hover(button, mouseState);
        }
    }
}
