
CREATE TABLE Produto (
	ID_Produto		INT IDENTITY,
	ID_TipoProduto	INT NOT NULL,
	Nome			VARCHAR(100) NOT NULL,
	Codigo			INT NOT NULL,
	Ponto			INT NULL,
	VL_Pago			DECIMAL(5,2) NOT NULL,
	VL_Venda		DECIMAL(5,2) NOT NULL,
	Lucro			As (IsNull(VL_Venda, 0) - IsNull(VL_Pago, 0 )),
	Sessao			INT NOT NULL,

	CONSTRAINT PK_ID_Produto PRIMARY KEY (ID_Produto),
	CONSTRAINT FK_ID_TipoProduto FOREIGN KEY (ID_TipoProduto) REFERENCES Tipo_Produto(ID_TipoProduto),
)

GO 


CREATE TABLE Estoque (
	ID_Estoque		INT IDENTITY,
	ID_Produto		INT NOT NULL,
	QTD_Item		INT NOT NULL,

	CONSTRAINT PK_ID_Estoque PRIMARY KEY (ID_Estoque),
	CONSTRAINT FK_Estoque_Produto FOREIGN KEY (ID_Produto) REFERENCES Produto(ID_Produto)
)

GO 

CREATE TABLE  Tipo_Produto (
	ID_TipoProduto		INT IDENTITY,
	Categoria			VARCHAR(100) NOT NULL,

	CONSTRAINT PK_ID_TipoProduto PRIMARY KEY (ID_TipoProduto)
)

GO 


CREATE TABLE Venda_Cliente (
	ID_Venda		INT IDENTITY,
	ID_Produto		INT,
	ID_Cliente		INT,
	DT_Venda		DATETIME NOT NULL,
	QTD_Item		INT NOT NULL,
	VL_Total		DECIMAL(5,2) NOT NULL,

	CONSTRAINT PK_ID_Venda PRIMARY KEY (ID_Venda),
	CONSTRAINT FK_Produto FOREIGN KEY (ID_Produto) REFERENCES Produto(ID_Produto),
	CONSTRAINT FK_ID_Cliente FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
)

GO 

CREATE TABLE Cliente (
	ID_Cliente		INT IDENTITY,
	ID_Usuario		INT NULL,
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

	CONSTRAINT PK_ID_Cliente PRIMARY KEY (ID_Cliente),
	--CONSTRAINT FK_ID_UsuarioCliente FOREIGN KEY (ID_Usuario) REFERENCES Usuario (ID_Usuario)
)
