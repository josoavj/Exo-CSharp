using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
    class Sorcier : Personne
    {
        public override void SePresenter()
        {
            Console.WriteLine("Je suis un sorcier");
        }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne marche pas, je vole");
        }
        public override void Attaquer()
        {
            Console.WriteLine("Je peux te jeter un sort");
        }
        public override void Soigner()
        {
            Console.WriteLine("Je peux te soigner en échange de ton âme");
        }
    }
}
