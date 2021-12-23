CREATE PROCEDURE dbo.usp_AlterarEstoque 
(
	 @ID_Produto INT
	,@Quantidade INT
)
AS
	IF EXISTS (SELECT 1 
					FROM ESTOQUE 
					WHERE ID_Produto = @ID_Produto)
		BEGIN
			UPDATE Estoque SET QTD_Item += @Quantidade WHERE ID_Produto = @ID_Produto 
		END;
	ELSE
		BEGIN
			INSERT INTO ESTOQUE 
			VALUES (@ID_Produto, @Quantidade)
		END;

