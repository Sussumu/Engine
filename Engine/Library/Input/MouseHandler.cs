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
        
        public void Update(List<Button> GUIElements)
        {
            mouseState = Mouse.GetState();

            if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed &&
                oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                foreach (Button button in GUIElements)
                {
                    if (button.Contains(new Vector2(mouseState.X, mouseState.Y)))
                    {
                        OnClick(button, mouseState);
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
    }
}
