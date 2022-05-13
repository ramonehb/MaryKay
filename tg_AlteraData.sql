DROP TRIGGER IF EXISTS tg_AlteraData

GO 

CREATE TRIGGER tg_AlteraData
ON Estimativa
AFTER INSERT
AS

DECLARE @ID_Estimativa INT

	SELECT @ID_Estimativa = I.ID_Estimativa
		FROM INSERTED AS I

	UPDATE Estimativa 
		SET DT_Mes = datefromparts(year(DT_Mes), month(DT_Mes), 1)
		WHERE ID_Estimativa = @ID_Estimativa