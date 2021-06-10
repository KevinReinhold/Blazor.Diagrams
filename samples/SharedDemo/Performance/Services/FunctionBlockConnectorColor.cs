using SharedDemo.Performance.Models;
using SharedDemo.Performance.Models.ConnectorTypes;

namespace SharedDemo.Performance.Services
{
    public static class FunctionBlockConnectorColor
    {
        public static string Get(IFunctionBlockConnector connector)
        {
            if (connector is FunctionBlockConnector<bool>)
                return "rgb(147, 207, 0)";
            else if (connector is FunctionBlockConnector<double>)
                return "rgb(255, 149, 14)";
            else if (connector is FunctionBlockConnector<long>)
                return "rgb(255, 211, 32)";
            else if (connector is FunctionBlockConnector<string>)
                return "rgb(0, 69, 134)";
            else if (connector is FunctionBlockConnector<FbConfig>)
                return "rgb(100, 100, 255)";
            else
                return "hotpink";
        }
    }
}
