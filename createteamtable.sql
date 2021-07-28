CREATE TABLE [dbo].[Team] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [City]     VARCHAR (50) NULL,
    [TeamName] VARCHAR (50) NULL,
    [Stadium]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED ([ID] ASC)
);