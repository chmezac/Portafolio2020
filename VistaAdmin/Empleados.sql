create table Empleado (
IdEmp int not null identity,
RutEmp numeric(8) not null,
DfEmp char(1) not null,
NomPrimEmp varchar(50) not null,
NomSecEmp varchar(50) not null,
ApePrimEmp varchar(50) not null,
ApeSecEmp varchar(50) not null,
FonoEmp numeric(9) not null,
EmailEmp varchar(30) not null
constraint pk_empleado primary key (IdEmp)
);

create table CodAreaEmp (
IdCodAreaEmp int not null identity,
NomAreaEmp varchar (15) not null,
constraint pk_IdCodAreaEmp primary key (IdCodAreaEmp)
);

create table Plato (
IdPlato int not null identity,
NomPlato varchar(50)
);

create table Cliente (
IdCliente int not null identity,
NombrePrimCliente varchar(50) not null,
NombreSecCliente varchar(50) not null,
ApePatCliente varchar(50) not null,
ApeMatCliente varchar(50) not null,
FonoCliente numeric(9) not null,
EdadCliente numeric(3) not null,
EmailCliente varchar(30) not null
constraint pk_IdCliente primary key (IdCliente)
);

create table Carta (
IdCarta int not null identity,
NomCarta varchar(30) not null,
TempCarta varchar(20) not null,
EncarCarta varchar(50) not null,
constraint pk_IdCarta primary key (IdCarta)
);

create table Cuenta (
IdCuenta int not null identity,
DiaCuenta numeric(2) not null,
MesCuenta numeric(2) not null,
AnoCuenta numeric(4) not null,
TotalCuenta float(9) not null,
IvaCuenta float(9) not null,
MetodoPagoCuenta char(1) not null
constraint pk_IdCuenta primary key (IdCuenta)
);


create table Garzon (
IdGarzon int not null identity,
NombrePrimGarzon varchar(50) not null,
NombreSecGarzon varchar(50) not null,
ApePatGarzon varchar(50) not null,
ApeMatGarzon varchar(50) not null,
constraint pk_IdGarzon primary key (IdGarzon)
);

create table Administrador (
IdAdmin int not null identity,
NomPrimAdmin varchar(50) not null,
NomSecAdmin varchar(50) not null,
ApePatAdmin varchar(50) not null,
ApeMatAdmin varchar(50) not null,
RutAdmin numeric(8) not null,
DfAdmin char(1) not null,
constraint pk_IdAdmin primary key (IdAdmin)
);

create table Proveedor(
IdProv int not null identity,
NomPrimProv varchar(50) not null,
NomSecProv varchar(50) not null,
ApePatProv varchar(50) not null,
ApeMatProv varchar(50) not null,
FonoProv numeric(9) not null,
EmailProv varchar(30) not null,
RutProv numeric(8) not null,
DfProv char(1) not null,
constraint pk_IdProv primary key (IdProv)
);


create table ProductoProv(
IdProdProv int not null identity,
NomProdProv varchar(50) not null,
CantProdProv numeric(6) not null,
constraint pk_IdProdProv primary key (IdProdProv)
);

create table Bodega(
IdBodega int not null identity,
StockTotal numeric(9) not null,
NomPrimAdminBodega varchar(50) not null,
NomSecAdminBodega varchar(50) not null,
ApePatAdminBodega varchar(50) not null,
ApeMatAdminBodega varchar(50) not null,
RutAdminBodega numeric(8) not null,
DfAdminBodega char(1) not null,
constraint pk_IdBodega primary key (IdBodega)
);

create table ProductoBod(
IdProdBodega int not null identity,
NomProdBodega varchar(50) not null,
StockProdBodega varchar(50) not null,
constraint pk_IdProdBodega primary key (IdProdBodega) 
);

create table CuentaCorriente(
IdCC int not null identity,
SaldoTotalCC int not null,
SaldoMensualCC int not null,
SaldoDiarioCC int not null,
DiaCC numeric(2)not null,
MesCC numeric(2) not null,
AnoCC numeric(2) not null,
VentasTotalesCC int not null,
VentasMensualesCC int not null,
VentasDiaCC int not null,
constraint pk_IdCC primary key (IdCC)
);

create table Orden(
IdOrden int not null identity,
NumOrden numeric (10) not null,
DiaOrden numeric(2) not null,
MesOrden numeric(2) not null,
AnoOrden numeric(4) not null,
HoraOrden numeric(4) not null
constraint pk_IdOrden primary key (IdOrden)
);

create table Cocinero(
IdCocinero int not null identity,
RutCocinero numeric(8) not null,
DfCocinero char(1) not null,
NomPrimCocinero varchar(50) not null,
NomSecCocinero varchar(50) not null,
ApePatCocinero varchar(50) not null,
ApeMatCocinero varchar(50) not null,
constraint pk_IdCocinero primary key (IdCocinero)
);
