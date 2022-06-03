CREATE TABLE [dbo].[Kayitlar] (
    [kayit_id]     INT      IDENTITY (1, 1) NOT NULL,
    [kullanici_id] INT      NULL,
    [kitap_id]     INT      NULL,
    [alis_tarih]   DATETIME NULL,
    [son_tarih]    DATETIME NULL,
    [durum]        BIT      NULL,
    CONSTRAINT [PK_Kayitlar] PRIMARY KEY CLUSTERED ([kayit_id] ASC),
    CONSTRAINT [FK_Kayitlar_Kullanicilar] FOREIGN KEY ([kullanici_id]) REFERENCES [dbo].[Kullanicilar] ([kullanici_id]),
    CONSTRAINT [FK_Kayitlar_Kaynaklar] FOREIGN KEY ([kitap_id]) REFERENCES [dbo].[Kaynaklar] ([kaynak_id])
);
