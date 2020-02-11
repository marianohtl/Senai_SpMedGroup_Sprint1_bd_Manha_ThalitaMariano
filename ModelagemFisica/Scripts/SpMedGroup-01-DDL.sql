-- DROP DATABASE SpMedGroupM;

CREATE DATABASE SpMedGroupM;

USE SpMedGroupM;


CREATE TABLE PlanoSaude(
IdPlanoSaude INT PRIMARY KEY IDENTITY, 	
NomePlano VARCHAR(255) NOT NULL
);

GO

CREATE TABLE Clinicas(
IdClinica INT PRIMARY KEY IDENTITY, 	
CNPJ VARCHAR(14) NOT NULL,
NomeFantasia  VARCHAR(255) NOT NULL,	
RazaoSocial	 VARCHAR(255) NOT NULL,
Telefone VARCHAR(16) NOT NULL,
Endereco  VARCHAR(255) NOT NULL
);

GO

CREATE TABLE TipoEspecialidade(
IdTipoEspecialidade INT PRIMARY KEY IDENTITY, 	
NomeEspecialidade VARCHAR(255) NOT NULL
);

GO

CREATE TABLE TipoUsuario(
IdTipoUsuario INT PRIMARY KEY IDENTITY, 	
Tipo VARCHAR(100) NOT NULL
);

GO


CREATE TABLE Usuarios(
IdUsuario INT PRIMARY KEY IDENTITY,
NomeUsuario VARCHAR(255) NOT NULL,
Email VARCHAR(100),
Data_Nascimento	Date NOT NULL,
Telefone VARCHAR(16) NOT NULL,
Celular	VARCHAR(16), 
RG	VARCHAR(14) NOT NULL,
Cpf	VARCHAR(14) NOT NULL,
Endereco VARCHAR(255) NOT NULL,
IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario) NOT NULL
);

GO

CREATE TABLE Medicos(
IdMedico INT PRIMARY KEY IDENTITY, 	
CRM VARCHAR(14) NOT NULL,
IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario) NOT NULL,
IdClinica INT FOREIGN KEY REFERENCES Clinicas(IdClinica) NOT NULL
);

GO

CREATE TABLE EspecialidadeMedico(
IdEspecialidadeMedico INT PRIMARY KEY IDENTITY, 	
IdTipoEspecialidade INT FOREIGN KEY REFERENCES TipoEspecialidade(IdTipoEspecialidade) NOT NULL,
IdMedico INT FOREIGN KEY REFERENCES Medicos(IdMedico) NOT NULL
);


GO

CREATE TABLE FichaPaciente(
IdFichaPaciente INT PRIMARY KEY IDENTITY, 	
IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario) NOT NULL,
IdPlanoSaude INT FOREIGN KEY REFERENCES PlanoSaude(IdPlanoSaude) 
);

GO

CREATE TABLE Consultas(
IdConsulta INT PRIMARY KEY IDENTITY,
Data_Consulta DateTime2 NOT NULL, 	
Situacao VARCHAR(150) NOT NULL,
PlanoSaude BIT NOT NULL,
ValorConsulta DECIMAL,
IdMedico INT FOREIGN KEY REFERENCES Medicos(IdMedico) NOT NULL,
IdFichaPaciente INT	FOREIGN KEY REFERENCES FichaPaciente(IdFichaPaciente) NOT NULL
);
GO





