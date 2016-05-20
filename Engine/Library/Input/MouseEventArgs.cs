using Microsoft.Xna.Framework.Input;

namespace Engine.Library.Input
{
    /// <summary>
    /// Store information to send across mouse events
    /// </summary>
    public class MouseEventArgs
    {
        public MouseState MouseState { get; private set; }

        public MouseEventArgs(MouseState mouseState)
        {
            MouseState = mouseState;
        }
    }
}
