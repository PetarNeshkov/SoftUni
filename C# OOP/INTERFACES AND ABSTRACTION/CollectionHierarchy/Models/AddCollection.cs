﻿

namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.Data = new List<T>();
        }

        protected List<T> Data { get; set; }

        public virtual int Add(T element)
        {
            this.Data.Add(element);
            return this.Data.Count - 1;
        }
    }


}

