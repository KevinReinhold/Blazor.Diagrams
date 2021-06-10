using SharedDemo.Performance.Models;

namespace SharedDemo.Performance.Services
{
    public static class DataflowValidator
    {
        public static bool CanAttachTo(IFunctionBlockConnector sourceConnector, IFunctionBlockConnector destinationConncetor)
        {
            if (sourceConnector.IsInput == destinationConncetor.IsInput)
                return false;

            if (sourceConnector.GetType().GetGenericArguments()[0] != destinationConncetor.GetType().GetGenericArguments()[0])
                return false;

            return true;
        }
    }
}
