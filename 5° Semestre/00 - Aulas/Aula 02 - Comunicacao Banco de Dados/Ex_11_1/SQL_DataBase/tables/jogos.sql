CREATE TABLE [dbo].[jogos] (
	 id				int				NOT NULL	PRIMARY KEY
	,descricao		varchar(50)		NULL
	,valor_locacao	decimal(18,2)	NULL
	,data_aquisicao	datetime		NULL
	,categoriaId	int				NULL
)