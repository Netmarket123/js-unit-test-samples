using MGWDev.GraphSDK.UT.Graph.Helper;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGWDev.GraphSDK.UT.Graph.DAL
{
    public class GraphUsersProvider : AbstractEntityProvider<User>
    {
        public GraphUsersProvider(GraphServiceClient serviceClient):base(serviceClient, "https://graph.microsoft.com/v1.0/users")
        {
        }
    }
}
