using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
    abstract class Personne
    {
        //public string Nom { get; set; }
        abstract public  void SePresenter();
        public abstract void Attaquer();
        public abstract void Soigner();
        public abstract void SeDeplacer();
    }
    /*
     * 1 - On ne peut pas instancier un objet à partir de la classe Personne mais on peut construire des constructeurs.
     * 2 - On peut créer des instances aux classes filles qui héritent la classe Personne
     */
}
