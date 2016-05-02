using Microsoft.Xna.Framework;

namespace Engine.Library.Components
{
    /// <summary>
    /// Handles the position and rotation of your object
    /// </summary>
    class TransformComponent : Component
    {
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }

        public TransformComponent(Vector2? position, float? rotation)
        {
            Position = position ?? Vector2.Zero;
            Rotation = rotation ?? 0.0f;
        }
    }
}
