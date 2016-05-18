using Microsoft.Xna.Framework;

namespace Engine.Library.Components
{
    /// <summary>
    /// Handles the position, rotation and transformations of your object
    /// </summary>
    class TransformComponent : Component
    {
        #region Variables

        private Vector2 position;
        private float rotation;

        #endregion

        #region Getters

        public Vector2 GetPosition() { return position; }
        public float GetRotation() { return rotation; }

        #endregion

        #region Constructors

        public TransformComponent(Vector2 position)
        {
            this.position = position;
            rotation = 0.0f;
        }

        public TransformComponent(Vector2 position, float rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }

        #endregion

        #region Auxiliary Methods

        public void Translate(float x, float y)
        {
            position.X += x;
            position.Y += y;
        }

        public void TranslateAbsolute(float x, float y)
        {
            position.X = x;
            position.Y = y;
        }

        public void Rotate(float angle)
        {
            rotation += angle;
        }

        #endregion
    }
}
