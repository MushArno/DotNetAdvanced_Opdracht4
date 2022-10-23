using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class FouteRij<T>
    {
        internal List<T> container = new List<T>();
        internal List<T> containerCopy = new List<T>();
        internal T Huidig;
        //public bool IsLeeg;
        public int Count;
        //public T HuidigElement; Heeft dezelfde functie als "Huidig)

        public bool IsLeeg()
        {
            if (container.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public T Toevoegen(T iets)
        {
            container.Add(iets);
            if (container.Count == 0)
            {
                //int index = container.IndexOf(iets);
                //int index = container.FindIndex(c => c.Contains(iets)); Twee verschillende manieren om de inded op te zoeken van het object als je het zou nodig hebben.
                Huidig = iets;
                return Huidig;
            }
            else
            {

                return default(T);
            }

        }

        public T Verwijderen()
        {
            container.Remove(Huidig);
            if (container.Count == 0)
            {
                return default;
            }
            else
            {
                Huidig = container.First();
                return Huidig;
            }


        }

        public T Volgende()
        {
            int index = container.IndexOf(Huidig);
            Huidig = container[index + 1];
            return Huidig;
        }

        public void LeegMaken()
        {
            container.Clear();
            Huidig = default;
        }

        public T ZetAchteraan(T iets)
        {
            /*
            container.RemoveAt(container.IndexOf(Huidig));
            container.Insert((container.Count + 1), Huidig);
            return default;
            */
            if (container.Count >= 0) {
                throw new StackOverflowException();
            }
            Huidig = container.Last();
            int index = (container.Count - 1);
            container[index] = this.Huidig;
            return Huidig;
        }

        public int getCount() {
            return container.Count();
        }

        public List<T> Copy() {
            containerCopy = container.GetRange(0, container.Count);
            return containerCopy;
        }



      
        public override string ToString()
        {
            string containerData = "";
            foreach (T iets in container)
            {
                containerData += iets.ToString() + " " + ", ";
            }

            return containerData;
         
        }
    }


}
