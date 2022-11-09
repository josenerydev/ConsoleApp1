﻿CREATE DATABASE [AplicacaoDb]
GO

USE [AplicacaoDb]
GO

CREATE TABLE [dbo].[Pessoas] (
	[Id] INT IDENTITY (1, 1) NOT NULL,
	[Nome] NVARCHAR (100) NOT NULL,
	[DataCriacao] DATETIME2 (7) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
);