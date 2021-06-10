using System.Linq;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Performance.Models.Ports
{
    public class FunctionBlockPort : PortModel
    {
        private readonly FunctionBlockNodeConnector _nodeConnector;

        public FunctionBlockPort(NodeModel parent, PortAlignment portAlignment, FunctionBlockNodeConnector nodeConnector) : base(parent, portAlignment) => _nodeConnector = nodeConnector;

        public override bool CanAttachTo(PortModel port)
        {
            if (!base.CanAttachTo(port))
                return false;

            if (port is not FunctionBlockPort fbPort)
                return false;

            if (Links.Any(l => l.TargetPort?.Id == port.Id || l.SourcePort?.Id == port.Id))
                return false;

            return _nodeConnector.CanAttachTo(fbPort._nodeConnector);
        }
    }
}
