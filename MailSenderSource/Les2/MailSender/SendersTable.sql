CREATE TABLE [dbo].[Senders] (
    [SenderId]    INT            NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    [Address]  NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.Senders] PRIMARY KEY CLUSTERED ([SenderId] ASC)
);