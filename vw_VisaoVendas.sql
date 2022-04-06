
CREATE VIEW vw_VisaoVendas
As
SELECT	ID_Pedido AS ID,
		UPPER(C.Nome) AS 'NOME CLIENTE',
		UPPER(PS.NM_Descricao) AS 'STATUS',
		UPPER(U.Usuario) AS USUARIO,
		UPPER(FP.NM_Descricao) AS 'TIPO DE PAGAMENTO',
		P.DT_Venda AS 'DATA DA VENDA',
		P.VL_Total AS TOTAL
	FROM Pedido AS P
	INNER JOIN Cliente AS C
	ON P.ID_Cliente = C.ID_Cliente
	FULL JOIN PedidoStatus AS PS
	ON P.ID_PedidoStatus = PS.ID_PedidoStatus
	FULL JOIN Usuario AS U
	ON P.ID_Usuario = U.ID_Usuario
	FULL JOIN FormaPagamento AS FP
	ON P.ID_FormaPagamento = FP.ID_FormaPagamento