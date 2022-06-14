CREATE TRIGGER tg_AbateEstimativa
ON Pedido
AFTER INSERT

AS 

DECLARE  @ID_Produto	INT
		,@Qtd			INT 

UPDATE ESTIMATIVA
	SET VL_TotalVendido = (SELECT SUM(VL_Total)
								FROM PEDIDO
								WHERE MONTH(DT_Venda) = MONTH(GETDATE()) AND
									  ID_PedidoStatus = 3)
	WHERE MONTH(DT_Mes) = MONTH(GETDATE())