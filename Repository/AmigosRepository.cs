using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class AmigosRepository
    {
        private AmigosContext Context;

        public AmigosRepository(AmigosContext context)
        {
            this.Context = context;
        }
    }
}
