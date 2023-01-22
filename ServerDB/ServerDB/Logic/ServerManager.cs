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
            return this;
        }

        public ServerManager UpdateServer(ServerManager serverModel)
        {
            return this;
        }

        public ServerManager ChangeName(int id, string newName)
        {
            return this;
        }

        public ServerManager GetServer(int id)
        {
            return null;
        }

        public List<ServerModel> GetServers()
        {
            return null;
        }
    }
}
