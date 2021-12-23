using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace firstProject
{
    public class Store
    {
        private List<Tovar> tovar;

        public Store()
        {
            tovar = new List<Tovar>();
        }

        public void AddTovar(Tovar tovar)
        {
            this.tovar.Add(tovar);
        }

        public Tovar this[int nameFindProduct]
        {
            // tovar[nameFindProduct].indexOf
            get => tovar[nameFindProduct];
        }
    }
}