CREATE DATABASE PlanAnualOperativoAntony2020
GO
CREATE TABLE PAO_EjeTematico (
	IdEjeTematico int identity (1,1) Primary key,
	EjTematico varchar(45)	
);
GO
CREATE TABLE PAO_Objetivo(
	IdObjetivo int identity(1,1) primary key,
	IdTematico int,
	Anno int,
	Oficina varchar(45),
	TemaEstretegico varchar(100),
	Objetivo varchar(500)
);
GO
ALTER TABLE PAO_Objetivo
ADD FOREIGN KEY (IdTematico)
REFERENCES PAO_EjeTematico(IdEjeTematico);
GO
CREATE TABLE PAO_Coordinacion(
	IdCoordinacion int identity(1,1) Primary Key,
	IdObjetivo int,
	TipoOficina varchar(45),
	NombreOficina varchar(200)
);
ALTER TABLE PAO_Coordinacion
ADD CHECK (TipoOficina='INTERNA' OR TipoOficina='EXTERNA');
GO
ALTER TABLE PAO_Coordinacion
ADD FOREIGN KEY (IdObjetivo)
REFERENCES PAO_Objetivo(IdObjetivo);
GO
CREATE TABLE PAO_Meta(
	IdMeta int identity (1,1) Primary Key,
	IdObjetivo int,
	FechaEI VARCHAR(64),
	FechaEF VARCHAR(64),
	ValorInicial int,
	ValorEsperado int,
	Indicador int,
	Formula varchar(100),
	TipoControl varchar(45),
	Cantidad int,
	Medida varchar(50)
);
GO
ALTER TABLE PAO_Meta
ADD FOREIGN KEY (IdObjetivo)
REFERENCES PAO_Objetivo(IdObjetivo);
GO
CREATE TABLE PAO_Actividad(
	IdActividad int identity(1,1) Primary Key,
	IdMeta int,
	IdAvance int,
	Actividad varchar(50),
	DetalleActividad varchar(500)	
);
GO
ALTER TABLE PAO_Actividad
ADD FOREIGN KEY (IdMeta)
REFERENCES PAO_Meta(IdMeta);
GO
CREATE TABLE PAO_Avance(
	IdAvance INT IDENTITY(1,1) PRIMARY KEY,
	Oficina varchar(50),
	Objetivo varchar(500),
	Comentario varchar(500),
	Anno int,
	FechaActividad varchar(64),
	FileUrl varchar(500),
	Terminado int 
);
GO
ALTER TABLE PAO_Actividad
ADD FOREIGN KEY (IdAvance)
REFERENCES PAO_Avance(IdAvance);
GO
ALTER TABLE PAO_Avance
ADD CHECK (Terminado='1' OR Terminado='0');

/*
select(
(
select count(Terminado)
from PAO_Avance
inner join PAO_Actividad
on PAO_Actividad.IdAvance=PAO_Avance.IdAvance
inner join PAO_Meta
on PAO_Meta.IdMeta=PAO_Actividad.IdMeta
inner join PAO_Objetivo
on PAO_Objetivo.IdObjetivo=PAO_Meta.IdObjetivo
inner join PAO_EjeTematico
on PAO_EjeTematico.IdEjeTematico=PAO_Objetivo.IdTematico
where PAO_Avance.Terminado='1'
) -
(
select count(IdActividad)
from PAO_Actividad
inner join PAO_Meta
on PAO_Meta.IdMeta=PAO_Actividad.IdMeta
inner join PAO_Objetivo
on PAO_Objetivo.IdObjetivo=PAO_Meta.IdObjetivo
inner join PAO_EjeTematico
on PAO_EjeTematico.IdEjeTematico=PAO_Objetivo.IdTematico
))*10


*/