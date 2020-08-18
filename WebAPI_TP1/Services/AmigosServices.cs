using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace WebAPI_TP1.Services
{
    public class AmigosServices
    {
        private AmigosContext Context;

        public AmigosServices(AmigosContext context)
        {
            Context = context;
        }

        public List<Amigo> GetAll()
        {
            return Context.Amigos.ToList();
        }

        public Amigo GetAmigoById(int id)
        {
            return Context.Amigos.FirstOrDefault(x => x.id == id);
        }
    }
}
