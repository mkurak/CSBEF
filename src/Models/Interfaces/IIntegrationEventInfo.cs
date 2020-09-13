using System.Threading.Tasks;

namespace CSBEF.Models.Interfaces
{
    public delegate Task<IReturnModel<bool>> IntegrationEventDelegate(IntegrationEventArgs args);

    public interface IIntegrationEventInfo
    {
        event IntegrationEventDelegate EventObject;

        string EventName { get; set; }

        Task<IReturnModel<bool>> EventHandler(IntegrationEventArgs args);
    }
}