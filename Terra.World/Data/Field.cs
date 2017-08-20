namespace Terra.World.Data
{
    /// <summary>
    /// Stellt ein Feld da.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Auf welcher Höhe ist das Feld.
        /// </summary>
        private int _heightAxisCoordinates;

        /// <summary>
        /// Auf welcher Länge ist das Feld.
        /// </summary>
        private int _lenghtAxisCoordinates;

        /// <summary>
        /// Gibt die Dichte des Feldes an.
        /// </summary>
        private Density _density;

        /// <summary>
        /// Standartkonstruktor.
        /// Erstellt ein Feld anhand von Koordinaten.
        /// </summary>
        /// <param name="heightCor">Die Höhe.</param>
        /// <param name="lengthCor">Die Länge.</param>
        public Field (int heightCor, int lengthCor)
        {
            _heightAxisCoordinates = heightCor;
            _lenghtAxisCoordinates = lengthCor;
            _density = Density.Empty;
        }

        /// <summary>
        /// Standartkonstruktor.
        /// Erstellt ein Feld anhand von Koordinaten.
        /// Erstellt zudem die hineingegebene Dichte.
        /// </summary>
        /// <param name="heightCor">Die Höhe.</param>
        /// <param name="lengthCor">Die Länge.</param>
        public Field(int heightCor, int lengthCor, Density density)
        {
            _heightAxisCoordinates = heightCor;
            _lenghtAxisCoordinates = lengthCor;
            _density = density;
        }

        /// <summary>
        /// Gibt zurück, ob das Feld begehbar ist.
        /// </summary>
        /// <returns>Ist es begehbar?</returns>
        public bool IsWalkable()
        {
            bool result = false;

            switch (_density)
            {
                case Density.Empty:
                    result = true;
                    break;
                case Density.Solid:
                    result = false;
                    break;
            }
            return result;
        }
    }
}
