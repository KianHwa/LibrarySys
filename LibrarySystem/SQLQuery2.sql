CREATE TABLE [dbo].[Borrow] (
    [borrowID]   INT          IDENTITY (1, 1) NOT NULL,
    [memberID]   VARCHAR (50) NOT NULL,
    [ISBN]       VARCHAR (20) NOT NULL,
    [borrowDate] DATE         NULL,
    [returnDate] DATE         NULL,
    [status]     VARCHAR (20) NULL,
    CONSTRAINT [PK_Borrow] PRIMARY KEY CLUSTERED ([memberID] ASC, [ISBN] ASC, [borrowID] ASC),
    CONSTRAINT [FK_Borrow_Book] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[Book] ([ISBN]),
    CONSTRAINT [FK_Member_Borrow] FOREIGN KEY ([memberID]) REFERENCES [dbo].[Member] ([memberID])
);