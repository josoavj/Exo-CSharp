using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
    class Roi : Personne
    {
        public override void SePresenter()
        {
            Console.WriteLine("Je suis le Roi");
        }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas me soigner");
        }
        public override void Attaquer()
        {
            Console.WriteLine("Je n'attaque pas mes subordonnés");
        }
        public override void Soigner()
        {
            Console.WriteLine("Je ne peux pas soigner ces gens");
        }
    }
}
