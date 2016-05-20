using Engine.Library.Components;
using Engine.Library.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine.Library.GUI.Core
{
    class Button : Rectangle
    {
        float layerDepth;
        PrimitiveDrawing primitiveDrawing;
        SpriteComponent backgroundImage;
        Vector2[] vertices;

        /// <summary>
        /// Creates a monocolored button
        /// </summary>
        public Button(int x, int y, int width, int height, float rotation, Color color, float layerDepth)
        {
            transform = new TransformComponent(new Vector2(x, y), rotation);
            this.width = width;
            this.width = width;
            this.color = color;

            primitiveDrawing = new PrimitiveDrawing(Game.Instance.GraphicsDevice);
            backgroundImage = null;
            vertices = new Vector2[3];
            vertices[0] = new Vector2(x, y);
            vertices[1] = new Vector2(x, y + height);
            vertices[2] = new Vector2(x + width, y + height);
            vertices[3] = new Vector2(x + width, y);

            this.layerDepth = layerDepth;
        }

        /// <summary>
        /// Creates a button with background image
        /// </summary>
        /// <param name="imageName">The name you used on Monogame Content Manager</param>
        public Button(int x, int y, int width, int height, float rotation, string imageName, float layerDepth)
        {
            transform = new TransformComponent(new Vector2(x, y), rotation);
            this.width = width;
            this.width = width;
            color = Color.White;

            primitiveDrawing = null;
            backgroundImage = new SpriteComponent(imageName);

            this.layerDepth = layerDepth;
        }

        public void Draw()
        {
            // If the button is monocolored
            if (backgroundImage == null)
            {
                primitiveDrawing.Begin(PrimitiveType.TriangleList);
                primitiveDrawing.AddVertices(vertices, color);
                primitiveDrawing.End();
            }
            // If the button has an image
            else
            {
                backgroundImage.Draw(transform.GetPosition(), color, transform.GetRotation(),
                    transform.GetPivot(), transform.GetScale(), SpriteEffects.None, layerDepth);
            }
        }
    }
}
