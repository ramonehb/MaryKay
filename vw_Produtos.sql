CREATE VIEW dbo.vw_Produtos
AS
SELECT	ID_Produto,
		Nome AS NOME,
		TP.Categoria AS 'CATEGORIA DO PRODUTO',
		Codigo as 'CÓDIGO RÁPIDO',
		Ponto AS PONTOS,
		VL_Pago AS 'VALOR DE COMPRA',
		VL_Venda AS 'VALOR DE VENDA',
		Lucro AS LUCRO,
		Sessao AS SESSÃO
FROM Produto AS P
INNER JOIN Tipo_Produto AS TP
ON P.ID_TipoProduto = TP.ID_TipoProduto