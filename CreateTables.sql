CREATE TABLE Tipo_Produto 
(
	ID_TipoProduto		INT IDENTITY,
	Categoria			VARCHAR(100) NOT NULL,

	CONSTRAINT PK_ID_TipoProduto PRIMARY KEY (ID_TipoProduto)
)

GO
CREATE TABLE TipoUsuario
(
	ID_TipoUsuario INT PRIMARY KEY NOT NULL,
	NM_Tipo		   VARCHAR(100)
)

GO
INSERT TipoUsuario 
	VALUES (1,'Administrador'), (2,'Gerencial'), (3,'Comum')

GO
CREATE TABLE Usuario 
(
	ID_Usuario		INT IDENTITY,
	ID_TipoUsuario  INT NOT NULL,
	Usuario			VARCHAR(50) NOT NULL,
	Senha			VARCHAR(20) NOT NULL,
	Email			VARCHAR(100) NOT NULL,

	CONSTRAINT PK_ID_Usuario PRIMARY KEY (ID_Usuario),
	CONSTRAINT FK_ID_TipoUsuario FOREIGN KEY (ID_TipoUsuario) REFERENCES TipoUsuario (ID_TipoUsuario)
)

GO
CREATE TABLE Produto 
(
	ID_Produto				INT IDENTITY,
	ID_Usuario				INT NOT NULL,
	ID_TipoProduto			INT NOT NULL,
	Nome					VARCHAR(100) NOT NULL,
	Codigo					INT NOT NULL,
	Pontos					INT NULL,
	VL_Pago					DECIMAL(5,2) NOT NULL,
	VL_Venda				DECIMAL(5,2) NOT NULL,
	Lucro					AS (IsNull(VL_Venda, 0) - IsNull(VL_Pago, 0 )),
	Sessao					INT NOT NULL,

	CONSTRAINT PK_ID_Produto PRIMARY KEY (ID_Produto),
	CONSTRAINT FK_ID_TipoProduto FOREIGN KEY (ID_TipoProduto) REFERENCES Tipo_Produto(ID_TipoProduto),
	CONSTRAINT FK_ID_Usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)
)

GO
CREATE TABLE Estoque 
(
	ID_Estoque		INT IDENTITY,
	ID_Produto		INT NOT NULL,
	QTD_Item		INT NOT NULL,

	CONSTRAINT PK_ID_Estoque PRIMARY KEY (ID_Estoque),
	CONSTRAINT FK_Estoque_Produto FOREIGN KEY (ID_Produto) REFERENCES Produto(ID_Produto)
)

CREATE TABLE PedidoStatus 
(
	ID_PedidoStatus INT NOT NULL,
	NM_Descricao	VARCHAR(50)
)

GO 
INSERT PedidoStatus 
	VALUES (1,'Pagamento Pendete'),(2,'Em Processamento'),(3,'Enviado'),(4,'Entregue')

GO
CREATE TABLE Pedido 
(
	ID_Pedido			INT IDENTITY,
	ID_Cliente			INT NOT NULL,
	ID_PedidoStatus		INT NOT NULL,
	ID_Usuario			INT NOT NULL,
	DT_Venda			DATETIME NOT NULL,
	VL_Total			DECIMAL(5,2) NOT NULL,

	CONSTRAINT PK_ID_Pedido PRIMARY KEY (ID_Pedido),
	CONSTRAINT FK_ID_PedidoStatus FOREIGN KEY (ID_PedidoStatus) REFERENCES PedidoStatus (ID_PedidoStatus),
	CONSTRAINT FK_ID_Cliente FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
)

GO
CREATE TABLE ItemPedido
(
	ID_ItemPedido		INT IDENTITY,
	ID_Pedido			INT NOT NULL,
	ID_Produto			INT NOT NULL,
	Quantidade			INT NOT NULL,
	SubTotal			DECIMAL(5,2) NOT NULL,

	CONSTRAINT PK_ID_ItemPedido PRIMARY KEY (ID_ItemPedido),
	CONSTRAINT FK_ID_Pedido FOREIGN KEY (ID_Pedido) REFERENCES Pedido (ID_Pedido),
	CONSTRAINT FK_ID_Produto FOREIGN KEY (ID_Produto) REFERENCES Produto (ID_Produto)
)

GO
CREATE TABLE Cliente 
(
	ID_Cliente		INT IDENTITY,
	Nome			VARCHAR (100) NOT NULL,
	CPF				VARCHAR (11) NULL,
	Email			VARCHAR (100) NULL,
	DT_Nascimento	DATE,
	Telefone		VARCHAR (20) NOT NULL,
	Rua				VARCHAR(100) NULL,
	CEP				INT NOT NULL,
	NR_Logradouro	INT NULL,
	Estado			VARCHAR(50) NULL,
	Cidade			VARCHAR(100) NULL,
	FL_EnviaEmail	BIT NULL,

	CONSTRAINT PK_ID_Cliente PRIMARY KEY (ID_Cliente)
)

