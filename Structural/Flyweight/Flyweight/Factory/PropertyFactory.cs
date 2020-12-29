using Flyweight.Entity;
using Flyweight.Entity.Concrete;
using System.Collections.Generic;

namespace Flyweight.Factory
{
    public class PropertyFactory
    {
        private Dictionary<char, Property> properties;

        public PropertyFactory()
        {
            this.properties = new Dictionary<char, Property>();
        }

        public Property GetProperty(char key)
        {
            Property property = null;

            if (properties.ContainsKey(key))
            {
                property = properties[key];
            }
            else
            {
                switch (key)
                {
                    case 'I':
                        {
                            property = new ImmovableProperty(); 
                            break;
                        }
                    case 'M': 
                        { 
                            property = new MovableProperty(); 
                            break; 
                        }
                }

                properties.Add(key, property);
            }

            return property;
        }
    }
}
