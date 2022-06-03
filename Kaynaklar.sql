CREATE TABLE [dbo].[Kaynaklar] (
    [kaynak_id]          INT           IDENTITY (1, 1) NOT NULL,
    [kaynak_ad]          NVARCHAR (50) NULL,
    [kaynak_yazar]       NVARCHAR (50) NULL,
    [kaynak_yayinci]     NVARCHAR (50) NULL,
    [kaynak_sayfasayisi] INT           NULL,
    [kaynak_basimtarihi] DATETIME      NULL,
    CONSTRAINT [PK_Kaynaklar] PRIMARY KEY CLUSTERED ([kaynak_id] ASC)
);
