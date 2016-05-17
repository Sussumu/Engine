using Engine.Library.Components;
using System.Collections.Generic;

namespace Engine.Library.GameObjects
{
    public abstract class GameObject
    {
        public abstract string Name { get; set; }
        List<Component> Components { get; set; }
    }
}
