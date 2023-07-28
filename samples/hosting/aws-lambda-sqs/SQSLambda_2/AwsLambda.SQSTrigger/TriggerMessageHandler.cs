﻿using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

#region TriggerMessageHandler

public class TriggerMessageHandler : IHandleMessages<TriggerMessage>
{
    static readonly ILog Log = LogManager.GetLogger<TriggerMessageHandler>();

    public async Task Handle(TriggerMessage message, IMessageHandlerContext context)
    {
        Log.Info($"Handling {nameof(TriggerMessage)} in {nameof(TriggerMessageHandler)}");
        await context.SendLocal(new FollowupMessage());
    }
}

#endregion