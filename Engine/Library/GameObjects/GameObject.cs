using Engine.Library.Components;
using System.Collections.Generic;

namespace Engine.Library.GameObjects
{
    class GameObject
    {
        public string Name { get; set; }
        public List<Component> Components {get;set;}
    }
}
