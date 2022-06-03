CREATE TABLE [dbo].[Personeller] (
    [personel_id]          INT           IDENTITY (1, 1) NOT NULL,
    [personel_ad]          NVARCHAR (50) NULL,
    [personel_soyad]       NVARCHAR (50) NULL,
    [personel_tc]          NVARCHAR (11) NULL,
    [personel_tel]         NVARCHAR (11) NULL,
    [personel_mail]        NVARCHAR (50) NULL,
    [personel_kullaniciAd] NVARCHAR (50) NULL,
    [personel_sifre]       NVARCHAR (50) NULL,
    CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED ([personel_id] ASC)
);
