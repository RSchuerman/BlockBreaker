CREATE TABLE [dbo].[Items] (
    [itemID]        INT        NOT NULL,
    [amount]        INT        DEFAULT ((0)) NOT NULL,
    [image]         IMAGE      NOT NULL,
    [breakTime]     FLOAT (53) NULL,
    [preferredTool] TEXT       NULL,
    [dropAmount]    INT        DEFAULT ((1)) NULL,
    [breakLevel]    INT        NULL,
    [durability]    INT        NULL,
    [toolLevel]     INT        NULL,
    [itemName] TEXT NOT NULL, 
    PRIMARY KEY CLUSTERED ([itemID] ASC)
);

