﻿// <auto-generated />
using System;
using BoletosWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoletosWeb.Migrations
{
    [DbContext(typeof(BoletosWebContext))]
    [Migration("20221018030000_23")]
    partial class _23
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoletosWeb.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("BoletosWeb.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Conta")
                        .HasColumnType("int");

                    b.Property<int>("IdUF")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("BoletosWeb.Models.Financeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataReferencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdConta")
                        .HasColumnType("int");

                    b.Property<int>("IdImovel")
                        .HasColumnType("int");

                    b.Property<int>("IdPessoaMorador")
                        .HasColumnType("int");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<double>("ValorDevido")
                        .HasColumnType("float");

                    b.Property<double>("ValorExtra")
                        .HasColumnType("float");

                    b.Property<double>("ValorPago")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Financeiro");
                });

            modelBuilder.Entity("BoletosWeb.Models.Garagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("Conta")
                        .HasColumnType("int");

                    b.Property<int?>("ImovelId")
                        .HasColumnType("int");

                    b.Property<string>("codGaragem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImovelId");

                    b.ToTable("Garagem");
                });

            modelBuilder.Entity("BoletosWeb.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Conta")
                        .HasColumnType("int");

                    b.Property<int?>("MoradorId")
                        .HasColumnType("int");

                    b.Property<int?>("ProprietarioId")
                        .HasColumnType("int");

                    b.Property<string>("codImovel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("dimensao")
                        .HasColumnType("float");

                    b.Property<int>("numGaragem")
                        .HasColumnType("int");

                    b.Property<double>("valor")
                        .HasColumnType("float");

                    b.Property<double>("vrDevido")
                        .HasColumnType("float");

                    b.Property<double>("vrExtra")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MoradorId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Imovel");
                });

            modelBuilder.Entity("BoletosWeb.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Conta")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TipoPessoa")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("BoletosWeb.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("BoletosWeb.Models.Endereco", b =>
                {
                    b.HasOne("BoletosWeb.Models.Pessoa", "Pessoa")
                        .WithOne("Endereco")
                        .HasForeignKey("BoletosWeb.Models.Endereco", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BoletosWeb.Models.Garagem", b =>
                {
                    b.HasOne("BoletosWeb.Models.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelId");

                    b.Navigation("Imovel");
                });

            modelBuilder.Entity("BoletosWeb.Models.Imovel", b =>
                {
                    b.HasOne("BoletosWeb.Models.Pessoa", "Morador")
                        .WithMany()
                        .HasForeignKey("MoradorId");

                    b.HasOne("BoletosWeb.Models.Pessoa", "Proprietario")
                        .WithMany()
                        .HasForeignKey("ProprietarioId");

                    b.Navigation("Morador");

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("BoletosWeb.Models.Telefone", b =>
                {
                    b.HasOne("BoletosWeb.Models.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("PessoaId");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BoletosWeb.Models.Pessoa", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
