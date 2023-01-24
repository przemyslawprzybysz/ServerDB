using ServerDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerDB.Logic
{
	public class ServerManager
	{
        public ServerManager AddServer(ServerModel serverModel)
        {
            using (var context = new ServerContext())
            {
                context.Add(serverModel);
                context.SaveChanges();
            }
                return this;
        }

        public ServerManager RemoveServer(int id)
        {
            using (var context = new ServerContext())
            {
                var serverToDelete = context.Servers.Single(x => x.Id == id);
                context.Remove(serverToDelete);
                context.SaveChanges();
            }
            return this;
        }

        public ServerManager UpdateServer(ServerModel serverModel)
        {
            using (var context = new ServerContext())
            {
                context.Update(serverModel);
                context.SaveChanges();
            }
            return this;
        }

        public ServerModel GetServer(int id)
        {
            ServerModel serverById;
            using (var context = new ServerContext())
            {
                serverById = context.Servers.Single(x => x.Id == id);
            }
            return serverById;
        }

        public List<ServerModel> GetServers()
        {
            List<ServerModel> serverList;
            using (var context = new ServerContext())
            {
                serverList = context.Servers.ToList();
            }
            return serverList;
        }
    }
}
