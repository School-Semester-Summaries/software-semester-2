using System;

namespace AnimalInheritanceParty
{
    enum Types
    {
        Fire,
        Water,
        Grass,
    }

    public class Pokemon
    {

        // Constructors
        public Pokemon()
        {

        }

        // Properties
        public Types Type { get; protected set; }
        public string Name { get; protected set; }

    }
}