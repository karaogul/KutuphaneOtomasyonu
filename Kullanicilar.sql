CREATE TABLE [dbo].[Kullanicilar] (
    [kullanici_id]       INT           IDENTITY (1, 1) NOT NULL,
    [kullanici_ad]       NVARCHAR (50) NULL,
    [kullanici_soyad]    NVARCHAR (50) NULL,
    [kullanici_tc]       NVARCHAR (11) NULL,
    [kullanici_mail]     NVARCHAR (50) NULL,
    [kullanici_tel]      NVARCHAR (50) NULL,
    [kullanici_ceza]     FLOAT (53)    NULL,
    [kullanici_cinsiyet] NVARCHAR (1)  NULL,
    CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED ([kullanici_id] ASC)
);
