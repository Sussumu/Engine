
namespace Engine.Library.Input
{
    public class MouseHandler
    {
        public delegate void MouseClickHandler(MouseEventArgs args);
        public event MouseClickHandler MouseClick;

        protected void OnMouseClick()
        {

        }
    }
}
