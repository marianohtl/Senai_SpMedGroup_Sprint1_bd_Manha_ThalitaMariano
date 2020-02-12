USE SpMedGroupM;

SELECT * FROM PlanoSaude
SELECT * FROM Consultas
SELECT * FROM Clinicas
SELECT * FROM EspecialidadeMedico
SELECT * FROM TipoEspecialidade
SELECT * FROM Medicos
SELECT * FROM Usuarios
SELECT * FROM TipoUsuario
SELECT * FROM Generos 
SELECT * FROM Situacoes 
SELECT * FROM Estados 
SELECT * FROM Cidades 
SELECT * FROM Bairros 
SELECT * FROM Ceps
SELECT * FROM Enderecos
SELECT * FROM Consultas



SELECT DataConsulta, ValorConsulta,Usuarios.NomeUsuario,PlanoSaude.NomePlano AS PlanoSaude,Situacoes.Situacao AS Situacao, Medicos.CRM FROM Consultas
INNER JOIN Usuarios ON Consultas.IdUsuario = Usuarios.IdUsuario
INNER JOIN PlanoSaude ON Consultas.IdPlanoSaude = PlanoSaude.IdPlanoSaude
INNER JOIN Situacoes ON Consultas.IdSituacao = Situacoes.IdSituacao
INNER JOIN Medicos ON Consultas.IdMedico = Medicos.IdMedico;



SELECT Medicos.CRM,Usuarios.NomeUsuario,Usuarios.Cpf,Usuarios.RG,Usuarios.Email,Usuarios.Telefone,Usuarios.DataNascimento, Generos.Genero, TipoUsuario.Tipo, Enderecos.Logradouro,Enderecos.Numero, Enderecos.Complemento , Ceps.Cep,Clinicas.NomeFantasia AS Clínica   FROM Medicos 
INNER JOIN Usuarios ON Medicos.IdUsuario = Usuarios.IdUsuario
INNER JOIN Generos ON Usuarios.IdGenero = Generos.IdGenero
INNER JOIN TipoUsuario ON Usuarios.IdTipoUsuario = TipoUsuario.IdTipoUsuario
INNER JOIN Enderecos ON Usuarios.IdEndereco = Enderecos.IdEndereco
INNER JOIN Ceps ON Ceps.IdCep = Enderecos.IdCep
INNER JOIN Clinicas ON Medicos.IdClinica = Clinicas.IdClinica
WHERE Medicos.CRM = '54356-SP';


SELECT Medicos.CRM,Usuarios.NomeUsuario,Usuarios.Cpf,Usuarios.RG,Usuarios.Email,Usuarios.Telefone,Usuarios.DataNascimento, Generos.Genero, TipoUsuario.Tipo, Enderecos.Logradouro,Enderecos.Numero, Enderecos.Complemento , Ceps.Cep, Clinicas.NomeFantasia AS Clínica FROM Medicos 
INNER JOIN Usuarios ON Medicos.IdUsuario = Usuarios.IdUsuario
INNER JOIN Generos ON Usuarios.IdGenero = Generos.IdGenero
INNER JOIN TipoUsuario ON Usuarios.IdTipoUsuario = TipoUsuario.IdTipoUsuario
INNER JOIN Enderecos ON Usuarios.IdEndereco = Enderecos.IdEndereco
INNER JOIN Ceps ON Ceps.IdCep = Enderecos.IdCep
INNER JOIN Clinicas ON Medicos.IdClinica = Clinicas.IdClinica
WHERE Medicos.CRM = '65463-SP';





 SELECT CNPJ,NomeFantasia,RazaoSocial,Telefone,HorarioAbertura,HorarioFechamento,Enderecos.Logradouro,Enderecos.Numero, Enderecos.Complemento, Ceps.Cep, Bairros.Bairro, Cidades.Cidade, Estados.Estado, Estados.Capital, Estados.Sigla FROM Clinicas
 INNER JOIN Enderecos ON Clinicas.IdEndereco =  Enderecos.IdEndereco 
 INNER JOIN Ceps ON Enderecos.IdCep = Ceps.IdCep
 INNER JOIN Cidades ON Ceps.IdCidade = Cidades.IdCidade
 INNER JOIN Bairros ON Ceps.IdBairro = Bairros.IdBairro
 INNER JOIN Estados ON Cidades.IdEstado = Estados.IdEstado;


 SELECT Medicos.*,Enderecos.Logradouro,Enderecos.Numero, Enderecos.Complemento, Ceps.Cep, Bairros.Bairro, Cidades.Cidade, Estados.Estado, Estados.Capital, Estados.Sigla FROM Medicos
 INNER JOIN Enderecos ON Medicos.IdUsuario =  Enderecos.IdEndereco 
 INNER JOIN Ceps ON Enderecos.IdCep = Ceps.IdCep
 INNER JOIN Cidades ON Ceps.IdCidade = Cidades.IdCidade
 INNER JOIN Bairros ON Ceps.IdBairro = Bairros.IdBairro
 INNER JOIN Estados ON Cidades.IdEstado = Estados.IdEstado;
 

 SELECT Usuarios.*,Enderecos.Logradouro,Enderecos.Numero, Enderecos.Complemento, Ceps.Cep, Bairros.Bairro, Cidades.Cidade, Estados.Estado, Estados.Capital, Estados.Sigla FROM Usuarios
 INNER JOIN Enderecos ON Usuarios.IdEndereco =  Enderecos.IdEndereco 
 INNER JOIN Ceps ON Enderecos.IdCep = Ceps.IdCep
 INNER JOIN Cidades ON Ceps.IdCidade = Cidades.IdCidade
 INNER JOIN Bairros ON Ceps.IdBairro = Bairros.IdBairro
 INNER JOIN Estados ON Cidades.IdEstado = Estados.IdEstado;
