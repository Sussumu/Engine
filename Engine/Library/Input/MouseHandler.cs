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
        public delegate void MouseClickHandler(GUIElement button, MouseState mouseState);
        public event MouseClickHandler Click;
        public event MouseClickHandler Hover;

        public void Update(List<GUIElement> GUIElements)
        {
            mouseState = Mouse.GetState();

            // Click
            if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released &&
                oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                foreach (GUIElement element in GUIElements)
                {
                    if (element.Contains(new Vector2(mouseState.X, mouseState.Y)))
                    {
                        OnClick(element, mouseState);
                    }
                }
            }
            // Hover
            else if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                foreach (GUIElement element in GUIElements)
                {
                    if (element.Contains(new Vector2(mouseState.X, mouseState.Y)))
                    {
                        OnHover(element, mouseState);
                    }
                }
            }

            oldMouseState = mouseState;
        }

        // Raise the event to mouse click
        protected virtual void OnClick(GUIElement element, MouseState mouseState)
        {
            Click(element, mouseState);
        }

        // Raise the event to mouse hover
        protected virtual void OnHover(GUIElement element, MouseState mouseState)
        {
            Hover(element, mouseState);
        }
    }
}
