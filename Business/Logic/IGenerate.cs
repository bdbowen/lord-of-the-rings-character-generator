using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    interface IGenerate<T>
    {
        T Generate(Random rand, int numberOfPhysical, int numberOfMental, int numberOfMagical);
        string GenerateName(string gender, Random rand);
    }
}
