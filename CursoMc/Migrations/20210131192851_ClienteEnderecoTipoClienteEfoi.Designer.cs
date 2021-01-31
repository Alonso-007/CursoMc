﻿// <auto-generated />
using System;
using CursoMc.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CursoMc.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210131192851_ClienteEnderecoTipoClienteEfoi")]
    partial class ClienteEnderecoTipoClienteEfoi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CategoriaProduto", b =>
                {
                    b.Property<int>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasId", "ProdutosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("CategoriaProduto");
                });

            modelBuilder.Entity("CursoMc.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("CursoMc.Model.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("CursoMc.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CpfOuCnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CursoMc.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("CursoMc.Model.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("CursoMc.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CursoMc.Model.TipoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoClientes");
                });

            modelBuilder.Entity("CategoriaProduto", b =>
                {
                    b.HasOne("CursoMc.Model.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CursoMc.Model.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CursoMc.Model.Cidade", b =>
                {
                    b.HasOne("CursoMc.Model.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("CursoMc.Model.Cliente", b =>
                {
                    b.HasOne("CursoMc.Model.TipoCliente", "TipoCliente")
                        .WithMany()
                        .HasForeignKey("TipoClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoCliente");
                });

            modelBuilder.Entity("CursoMc.Model.Endereco", b =>
                {
                    b.HasOne("CursoMc.Model.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.HasOne("CursoMc.Model.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cidade");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CursoMc.Model.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("CursoMc.Model.Estado", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
