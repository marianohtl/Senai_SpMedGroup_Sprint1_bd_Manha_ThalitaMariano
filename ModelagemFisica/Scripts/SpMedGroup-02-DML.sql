USE SpMedGroupM;


INSERT INTO PlanoSaude(NomePlano) VALUES ();
GO

INSERT INTO Clinicas(CNPJ,NomeFantasia,RazaoSocial,Telefone,Endereco) VALUES ();
GO

INSERT INTO TipoEspecialidade(NomeEspecialidade) VALUES();
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



















