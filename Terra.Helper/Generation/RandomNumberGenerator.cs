using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Helper.Generation
{
    public class RandomNumberGenerator
    {
        /// <summary>
        /// Generiert eine zufällige Nummer.
        /// </summary>
        /// <param name="fromNumber">Die Nummer, ab wann generiert werden soll.</param>
        /// <param name="toNumber">Die Nummer bis wann generiert werden soll.</param>
        /// <returns>Die erstellte Nummer.</returns>
        public int GenerateNumber(int fromNumber, int toNumber)
        {
            int result = 0;
            Random random = new Random();

           result = random.Next(fromNumber, toNumber);
            return result;
        }
    }
}
