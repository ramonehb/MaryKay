Create View vw_Usuarios
As
Select	 U.ID_Usuario
		,Upper(U.Usuario) as 'USU�RIO'
		,Upper(T.NM_Tipo) as 'TIPO DO USU�RIO'
		,Upper(U.FL_Habilitado) as HABILITADO 
		,Format(U.DT_Cadastro, 'dd/MM/yyyy HH:mm') as 'DATA DE CADASTRO'
		From Usuario As U
		Inner Join TipoUsuario as T
		On U.ID_TipoUsuario = T.ID_TipoUsuario