﻿CREATE VIEW dbo.vw_Estoque 
AS
	SELECT	 E.ID_Produto	
			,P.Nome					AS NOME
			,TP.Categoria			AS CATEGORIA
			,E.QTD_Item				AS QUANTIDADE
			,P.VL_Pago				AS 'VALOR DE COMPRA'
			,P.VL_Venda				AS 'VALOR DE VENDA'
			,P.Lucro				AS LUCRO
	FROM Estoque AS E
	INNER JOIN Produto AS P
	ON P.ID_Produto = E.ID_Produto
	INNER JOIN Tipo_Produto AS TP
	ON TP.ID_TipoProduto = P.ID_TipoProduto