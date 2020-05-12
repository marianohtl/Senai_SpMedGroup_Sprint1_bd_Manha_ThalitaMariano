using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpMedGroup.Domains
{
    public partial class ApiContext : DbContext
    {
        public ApiContext()
        {
        }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bairros> Bairros { get; set; }
        public virtual DbSet<Ceps> Ceps { get; set; }
        public virtual DbSet<Cidades> Cidades { get; set; }
        public virtual DbSet<Clinicas> Clinicas { get; set; }
        public virtual DbSet<Consultas> Consultas { get; set; }
        public virtual DbSet<Enderecos> Enderecos { get; set; }
        public virtual DbSet<EspecialidadeMedico> EspecialidadeMedico { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<PlanoSaude> PlanoSaude { get; set; }
        public virtual DbSet<Situacoes> Situacoes { get; set; }
        public virtual DbSet<TipoEspecialidade> TipoEspecialidade { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=SpMedGroupM; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bairros>(entity =>
            {
                entity.HasKey(e => e.IdBairro);

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ceps>(entity =>
            {
                entity.HasKey(e => e.IdCep);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBairroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBairro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ceps__IdBairro__4316F928");

                entity.HasOne(d => d.IdCidadeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ceps__IdCidade__440B1D61");
            });

            modelBuilder.Entity<Cidades>(entity =>
            {
                entity.HasKey(e => e.IdCidade);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cidades__IdEstad__3E52440B");
            });

            modelBuilder.Entity<Clinicas>(entity =>
            {
                entity.HasKey(e => e.IdClinica);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEnderecoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clinicas__IdEnde__49C3F6B7");
            });

            modelBuilder.Entity<Consultas>(entity =>
            {
                entity.HasKey(e => e.IdConsulta);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValorConsulta).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__IdMed__5FB337D6");

                entity.HasOne(d => d.IdPlanoSaudeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPlanoSaude)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__IdPla__5DCAEF64");

                entity.HasOne(d => d.IdSituacaoNavigation)
                    .WithMany(p => p.Consultas)
                    .HasForeignKey(d => d.IdSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__IdSit__5EBF139D");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Consultas__IdUsu__5CD6CB2B");
            });

            modelBuilder.Entity<Enderecos>(entity =>
            {
                entity.HasKey(e => e.IdEndereco);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCepNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Enderecos__IdCep__46E78A0C");
            });

            modelBuilder.Entity<EspecialidadeMedico>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidadeMedico);

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.EspecialidadeMedico)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Especiali__IdMed__59FA5E80");

                entity.HasOne(d => d.IdTipoEspecialidadeNavigation)
                    .WithMany(p => p.EspecialidadeMedico)
                    .HasForeignKey(d => d.IdTipoEspecialidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Especiali__IdTip__59063A47");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.Capital)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Generos>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.Property(e => e.Crm)
                    .IsRequired()
                    .HasColumnName("CRM")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdClinica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicos__IdClini__5629CD9C");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicos__IdUsuar__5535A963");
            });

            modelBuilder.Entity<PlanoSaude>(entity =>
            {
                entity.HasKey(e => e.IdPlanoSaude);

                entity.Property(e => e.NomePlano)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Situacoes>(entity =>
            {
                entity.HasKey(e => e.IdSituacao);

                entity.Property(e => e.Situacao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEspecialidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoEspecialidade);

                entity.Property(e => e.NomeEspecialidade)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                //p => p.Usuarios
                entity.HasOne(d => d.IdEnderecoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdEnde__52593CB8");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdGene__5070F446");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__IdTipo__5165187F");
            });
        }
    }
}
