ALTER TABLE [dbo].[PaymentPointVersions]
    ADD CONSTRAINT [PaymentPointVersion_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([CityId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

