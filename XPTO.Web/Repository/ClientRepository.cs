using System.Collections.Generic;
using System.Linq;
using XPTO.Web.Models;
using XPTO.Web.Repository.Context;

namespace XPTO.Web.Repository
{
    public class ClientRepository
    {
        private readonly XPTOContext context;

        public ClientRepository()
        {
            context = new XPTOContext();
        }

        public IList<Client> List()
        {
            return context.Client.ToList();
        }

        public Client Find(int id)
        {
            return context.Client.Find(id);
        }

        public void Create(Client client)
        {
            context.Client.Add(client);
            context.SaveChanges();
        }

        public void Edit(Client client)
        {
            context.Client.Update(client);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var client = new Client()
            {
                Id = id
            };

            context.Client.Remove(client);
            context.SaveChanges();
        }
    }
}