CREATE DATABASE [PerfilTreino]

USE [PerfilTreino]

CREATE TABLE [Categoria] (
[Id] INT NOT NULL IDENTITY(1, 1),
[Nome] NVARCHAR(100) NOT NULL,

CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id])
)



CREATE TABLE [Produto] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(100) NOT NULL,
    [Preco] DECIMAL(10,2) NOT NULL,
    [Quantidade] INT NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Produto] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Produto_Categoria] FOREIGN KEY([CategoriaId]) REFERENCES [Categoria]([Id])
)



CREATE TABLE [Cliente] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(100) NOT NULL,
    [Email] NVARCHAR(100) NOT NULL,
    [Telefone] NVARCHAR(20) NOT NULL,
    [CPF] NVARCHAR(11) NOT NULL,

    CONSTRAINT [PK_Cliente] PRIMARY KEY ([Id]),
)



CREATE TABLE [Pedido] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [ClienteId] INT NOT NULL,
    [DataPedido] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT [PK_Pedido] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([ClienteId]) REFERENCES [Cliente]([Id])
)



CREATE TABLE [ItemPedido] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [PedidoId] INT NOT NULL,
    [ProdutoId] INT NOT NULL,
    [Quantidade] INT NOT NULL,
    [PrecoUnitario] DECIMAL(10,2) NOT NULL,

    CONSTRAINT [PK_ItemPedido] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ItemPedido_Pedido] FOREIGN KEY([PedidoId]) REFERENCES [Pedido]([Id]),
    CONSTRAINT [FK_ItemPedido_Produto] FOREIGN KEY([ProdutoId]) REFERENCES [Produto]([Id])
)


