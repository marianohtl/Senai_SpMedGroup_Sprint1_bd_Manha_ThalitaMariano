USE SpMedGroupM;

INSERT INTO Generos(Genero) VALUES ('Feminino'),('Maculino'),('Não Declarado');

INSERT INTO PlanoSaude(NomePlano) 
VALUES ('Bradesco Saúde'),
	   ('Amil Assistência Médica Internacional'),
	   ('Unimed Belo Horizonte - Cooperativa de Trabalho Médico'),
	   ('Central Nacional Unimed - Cooperativa Central'),
	   ('Amico Saúde');
GO

INSERT INTO Situacoes (Situacao) 
VALUES ('Realizada'),
	   ('Cancelada'),
	   ('Agendada');
GO



INSERT INTO TipoEspecialidade(NomeEspecialidade) 
VALUES('Acupuntura'),
('Anestesiologia'),
('Angiologia'),
('Cardiologia'),
('Cirurgia Cardiovascular'),
('Cirurgia da Mão'),
('Cirurgia do Aparelho Digestivo'),
('Cirurgia Geral'),
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



INSERT INTO TipoUsuario(Tipo) 
VALUES ('ADM'),
	   ('Médico'),
       ('Paciente');
GO



INSERT INTO  Estados (Estado,Capital,Sigla)
VALUES ('Minas Gerais','Belo Horizonte','MG'),
	   ('São Paulo','São Paulo','SP'),
	   ('Alagoas',	'Maceió',	'AL');
GO


INSERT INTO Bairros(Bairro) VALUES('Mooca'),('Tatuapé'),('Alphavile');
GO


INSERT INTO Cidades(Cidade,IdEstado) VALUES ('São Paulo',2),('Barueri',2),('Carapicuiba',2);
GO


INSERT INTO Ceps(Cep,IdBairro,IdCidade) VALUES('000000-01',1,1),('000000-02',2,1),('000000-03',3,1);
GO


INSERT INTO Enderecos(Logradouro,Numero,Complemento,IdCep)  VALUES ('Avenida Random','5','Perto do Mercado do Zé',1),('Rua Random', '888','Ref. Metro',2); 
GO
INSERT INTO Enderecos(Logradouro,Numero,IdCep)  VALUES ('Alameda Random','90',3);
GO



INSERT INTO Clinicas(CNPJ,NomeFantasia,RazaoSocial,Telefone,HorarioAbertura,HorarioFechamento,IdEndereco)
VALUES ('86400902000130','MedGroup','SP Medical Group','(011)0000-0000','09:00','16:00',1);
GO


INSERT INTO Usuarios(NomeUsuario,Email, Senha, DataNascimento, Telefone,Telefone2,RG,Cpf,IdGenero,IdTipoUsuario,IdEndereco)  
VALUES ('ADM',	'adm@adm.com',	'**********',	'05/03/2018',	'11 7656-6377',	'11 97208-4453',	'54566266-8',	'91305348010' ,1,	1	,2);
GO
INSERT INTO Usuarios(NomeUsuario,Email, Senha, DataNascimento, Telefone,Telefone2,RG,Cpf,IdGenero,IdTipoUsuario,IdEndereco)  
VALUES ('Ricardo Lemos','ricardo.lemos@spmedicalgroup.com.br',	'**********',	'01/03/1900',	'11 1111-1111',	'11 91111-1111',	'888888-8',	'91305348010' ,2,	2,	3),
       ('Roberto Possarle',	'roberto.possarle@spmedicalgroup.com.br','**********',	'10/03/1800',	'11 1111-1111',	'11 91111-1111',	'888888-8',	'91305348010' ,2,	2,	3), 
       ('Helena Strada',	'helena.souza@spmedicalgroup.com.br',	'**********',	'11/09/1980',	'11 1111-1111',	'11 91111-1111',	'888888-8',	'91305348010' ,1,	2,	3);
GO
INSERT INTO Usuarios(NomeUsuario,Email, Senha, DataNascimento, Telefone,Telefone2,RG,Cpf,IdGenero,IdTipoUsuario,IdEndereco)  
VALUES ('Ligia','ligia@gmail.com',	'**********',	'01/03/1900',	'11 2222-2222',	'11 92222-2222',	'888888-8',	'91305348010' ,1,	3,	2),
       ('Alexandre','alexandre@gmail.com',	'**********',	'01/03/1900',	'11 1111-1111',	'11 91111-1111',	'888888-8',	'91305348010' ,2,	3,	2),
	   ('Fernando','fernando@gmail.com',	'**********',	'01/03/1900',	'11 3333-3333',	'11 93333-3333',	'888888-8',	'91305348010' ,2,	3,	2),
	   ('Henrique','henrique@gmail.com',	'**********',	'01/03/1900',	'11 1111-1111',	'11 91111-1111',	'888888-8',	'91305348010' ,3,	3,	2),
	   ('João','joao@hotmail.com',	'**********',	'01/03/1900',	'11 4444-4444',	'11 94444-4444',	'888888-8',	'91305348010' ,2,	3,	2),
	   ('Bruno','bruno@gmail.com',	'**********',	'01/03/1900',	'11 1111-1111',	'11 91111-1111',	'888888-8',	'91305348010' ,2,	3,	2),
       ('Mariana','mariana@outlook.com',	'**********',	'01/03/1900',	'11 5555-5555',	'11 95555-5555',	'888888-8',	'91305348010' ,1,	3,	2);
GO


INSERT INTO Medicos(CRM,IdUsuario,IdClinica)  VALUES ('54356-SP',2,1),('53452-SP',3,1),('65463-SP',4,1); --IDCLI
GO


INSERT INTO EspecialidadeMedico(IdTipoEspecialidade,IdMedico)  VALUES (1,1),(2,2),(2,3);
GO


INSERT INTO Consultas(DataConsulta,ValorConsulta,IdUsuario,IdPlanoSaude,IdSituacao,IdMedico)  
VALUES ('20/01/2020 15:00',00.00,5,1,1,1),
       ('20/01/2020 15:00',800.00,6,2,1,1),
	   ('20/01/2020 15:00',25.50,7,2,3,2),
	   ('20/01/2020 15:00',90.00,6,3,2,1),
	   ('20/01/2020 15:00',10.00,8,5,2,3),
	   ('20/01/2020 15:00',1100.00,6,3,1,3);
GO

UPDATE Consultas  
SET Descricao = ('Cheesy feet cheese and biscuits mascarpone. 
Pecorino bavarian bergkase cheeseburger emmental danish fontina melted 
cheese cheddar goat.Cheesy feet cheese and biscuits mascarpone. 
Pecorino bavarian bergkase cheeseburger bergkase cheeseburger')
WHERE IdConsulta = 1

GO