USE SpMedGroupM;


INSERT INTO PlanoSaude(NomePlano) 
VALUES ('Bradesco Saúde'),
	   ('Amil Assistência Médica Internacional'),
	   ('Unimed Belo Horizonte - Cooperativa de Trabalho Médico'),
	   ('Central Nacional Unimed - Cooperativa Central'),
	   ('Amico Saúde');

GO

INSERT INTO Situacao (Situacao) 
VALUES ('Realizada'),
	   ('Cancelada'),
	   ('Agendada');
GO


INSERT INTO Clinicas(CNPJ,NomeFantasia,RazaoSocial,Telefone,Endereco)
VALUES ('86400902000130','MedGroup','SP Medical Group','(011)0000-0000','Av. Barão Limeira, 532, São Paulo, SP');
GO

INSERT INTO TipoEspecialidade(NomeEspecialidade) 
VALUES('Acupuntura'),
'Anestesiologia'),
'Angiologia'),
'Cardiologia'),
'Cirurgia Cardiovascular'),
'Cirurgia da Mão'),
'Cirurgia do Aparelho Digestivo'),
'Cirurgia Geral'),
('Cirurgia Pediátrica'),
('Cirurgia Plástica'),
('Cirurgia Torácica'),
('Cirurgia Vascular'),
('Dermatologia'),
('Radioterapia'),
('Urologia'),
('Pediatria'),
('Psiquiatria');

GO

INSERT INTO TipoUsuario(Tipo) VALUES ();
GO


INSERT INTO Usuarios(NomeUsuario,Email, Data_Nascimento, Telefone, Celular,RG,Cpf,Endereco,IdTipoUsuario)  VALUES ();

GO

INSERT INTO Medicos(CRM,IdUsuario,IdClinica)  VALUES ();
GO


INSERT INTO EspecialidadeMedico(IdTipoEspecialidade,IdMedico)  VALUES ();
GO


INSERT INTO FichaPaciente(IdUsuario,IdPlanoSaude)  VALUES ();
GO

INSERT INTO Consultas(Data_Consulta,Situacao,PlanoSaude,ValorConsulta,IdMedico,IdFichaPaciente)  VALUES ();
GO



















