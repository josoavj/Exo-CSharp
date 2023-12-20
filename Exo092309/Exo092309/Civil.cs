using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
     class Civil : Personne
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Je marche , oueee");
        }
        public override void Attaquer() 
        {
            Console.WriteLine("J'attaque à main nue ");
        }
        public override void SePresenter()
        {
            Console.WriteLine("Je suis un civil");
        }
        public override void Soigner()
        {
            Console.WriteLine("Je ne peux pas me soigner");
        }
    }
}
