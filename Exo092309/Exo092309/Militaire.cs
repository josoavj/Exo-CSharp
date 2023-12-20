using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
    class Militaire : Personne
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je cours comme un fou");
        }
        public override void Attaquer()
        {
            Console.WriteLine("J'attaque avec un fusil");
        }
        public override void SePresenter()
        {
            Console.WriteLine("Je suis un militaire");
        }
        public override void Soigner()
        {
            Console.WriteLine("Je ne peux pas soigner mais je peux juste pratiquer les premiers soins");
        }
    }
}
