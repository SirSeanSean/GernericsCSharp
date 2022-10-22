using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GernericsConsole
{
    internal class Bus
    {
        public int RouteNumber { get; set; }
        public string StartRoute { get; set; }
        public string EndRoute { get; set; }

        public Bus(int routeNumber)
        {
            this.RouteNumber = routeNumber;
            this.StartRoute = "MKE";
            this.EndRoute = "RDU";
        }
        public Bus(int routeNumber, string startRoute, string endRoute)
        {
            this.RouteNumber = routeNumber;
            this.StartRoute = startRoute;
            this.EndRoute = endRoute;
        }
        public override string ToString() => $"{RouteNumber}: {StartRoute} -> {EndRoute}";
    }
}
