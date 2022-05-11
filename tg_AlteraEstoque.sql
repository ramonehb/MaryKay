DROP TRIGGER IF EXISTS tg_AlteraEstoque

Go

CREATE TRIGGER tg_AlteraEstoque
ON Produto
AFTER INSERT
AS

DECLARE  @ID_Produto INT
		,@Qtd INT 

SELECT 
	@ID_Produto = I.ID_Produto
	,@Qtd		= I.Quantidade
	From INSERTED AS I

IF EXISTS (SELECT 1 
					FROM ESTOQUE 
					WHERE ID_Produto = @ID_Produto)
		BEGIN
			UPDATE Estoque SET QTD_Item += @Qtd
			WHERE ID_Produto = @ID_Produto 

			UPDATE Produto Set Quantidade = 0
			WHERE ID_Produto = @ID_Produto
		END
	ELSE
		BEGIN
			INSERT INTO ESTOQUE 
			VALUES (@ID_Produto, @Qtd)

			UPDATE Produto Set Quantidade = 0
		END	