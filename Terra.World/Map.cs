using System.Collections.Generic;
using Terra.World.Data;

namespace Terra.World
{
    /// <summary>
    /// Stellt eine Spielkarte da.
    /// </summary>
    class Map
    {
        /// <summary>
        /// Der Name der Welt.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Die Felder der Spielkarte.
        /// </summary>
        private List<Field> _fields;
    }
}
