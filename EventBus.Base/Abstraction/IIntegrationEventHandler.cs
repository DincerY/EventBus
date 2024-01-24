using EventBus.Base.Events;

namespace EventBus.Base.Abstraction;

public interface IIntegrationEventHandler<TIntegrationEvent> : IntegrationEventHandler where TIntegrationEvent : IntegrationEvent
{
    
}

public interface IntegrationEventHandler
{

}