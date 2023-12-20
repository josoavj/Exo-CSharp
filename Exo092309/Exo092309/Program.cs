using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo092309
{
    class Program
    {        
        static void Main(string[] args)
        {
            /*
             * Remarques:
             * 1 - Les lignes de code mis en commentaires sont des codes fonctionnels.
             * 2 - Ces commentaires sont issus de la première version du code.
             * 3 - L'implémentation et les changements varient en fonction du problème énoncé.
             * 4 - Cette version du code comporte les classes suivants: Personne, Roi, Militaire, Civil, Sorcier.
             * 5 - Les problèmes non résolus dans ce programme sont les deux problèmes énoncés par le prof: 
             *     a - Ajout d'une nouvelle capacité par le sorcier: le déplacement
             *     b - idk, mais c'est opté sur le côté maintenance (Code facilement maintenable)
             */
            /*
             * Civil c = new Civil();
             * Militaire m = new Militaire();
            */
            /*
            Console.WriteLine("Civil: ");
            c.SePresenter();
            c.SeDeplacer();
            */

            /*static void Presenter(Personne p)
            {
                p.SePresenter();
            }
            Presenter(c);
            Presenter(m);
            */
            //misaraka cuz they're different variables

            /* Afaka tsy atao
             * static void Deplace(Ideplacement d)
            {
                d.Deplacer();
            }
            Deplace(c);
            Deplace(m);
            */
            /*
             * Console.WriteLine(" ");
            Console.WriteLine("Militaire: ");
            m.SePresenter();
            m.SeDeplacer();
            */

            Console.WriteLine("******------******");
            Console.WriteLine("******------******");
            Console.WriteLine(" ");

            Console.WriteLine("Affichage dans une liste: ");
            Console.WriteLine(" ");
            List<Personne> list = new List<Personne>();
            list.Add(new Civil());
            list.Add(new Militaire());
            list.Add(new Roi());
            list.Add(new Prêtre());
            list.Add(new Sorcier());    

            foreach(Personne p in list)
            {
                p.SePresenter();
                p.SeDeplacer();
                p.Attaquer();
                p.Soigner();
                Console.WriteLine(" ");
                Console.WriteLine("****------****");
            }
        }
    }
}