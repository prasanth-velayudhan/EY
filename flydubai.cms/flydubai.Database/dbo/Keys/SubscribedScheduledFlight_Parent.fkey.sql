ALTER TABLE [dbo].[SubscribedScheduledFlights]
    ADD CONSTRAINT [SubscribedScheduledFlight_Parent] FOREIGN KEY ([Parent_ScheduledFlightSubscriptionId]) REFERENCES [dbo].[ScheduledFlightSubscriptions] ([ScheduledFlightSubscriptionId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

