using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
    class Prêtre :Personne
    {
        public override void SePresenter()
        {
            Console.WriteLine("Je suis un prêtre");
        }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je me déplace constamment");
        }
        public override void Attaquer()
        {
            Console.WriteLine("Je ne peux pas t'attaquer mais je peux t'exorciser");
        }
        public override void Soigner()
        {
            Console.WriteLine("Je peux vous soigner mon enfant");
        }
    }
}
