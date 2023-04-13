﻿// <auto-generated />
using System;
using Manutemovel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Manutemovel.Domain.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Carro", b =>
                {
                    b.Property<Guid>("CarroId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AnoFabricacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("ModeloAnoId")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uuid");

                    b.HasKey("CarroId");

                    b.HasIndex("ModeloAnoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Historico", b =>
                {
                    b.Property<Guid>("HistoricoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CarroId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.HasKey("HistoricoId");

                    b.HasIndex("CarroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Historicos");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.HistoricoItem", b =>
                {
                    b.Property<Guid>("HistoricoItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("HistoricoId")
                        .HasColumnType("uuid");

                    b.Property<int>("Instancia")
                        .HasColumnType("integer");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uuid");

                    b.HasKey("HistoricoItemId");

                    b.HasIndex("HistoricoId");

                    b.HasIndex("ItemId");

                    b.ToTable("HistoricoItems");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Item", b =>
                {
                    b.Property<Guid>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Marca", b =>
                {
                    b.Property<Guid>("MarcaId")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Modalidade", b =>
                {
                    b.Property<Guid>("ModalidadeId")
                        .HasColumnType("uuid");

                    b.Property<int>("ACadaInspecao")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ModeloItemId")
                        .HasColumnType("uuid");

                    b.Property<byte>("Tipo")
                        .HasColumnType("smallint");

                    b.Property<int>("VidaUtilDias")
                        .HasColumnType("integer");

                    b.Property<int>("VidaUtilKM")
                        .HasColumnType("integer");

                    b.HasKey("ModalidadeId");

                    b.HasIndex("ModeloItemId");

                    b.ToTable("Modalidades");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.ModeloAno", b =>
                {
                    b.Property<Guid>("ModeloAnoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Ano")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("MarcaId")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ModeloAnoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("ModeloAnos");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.ModeloItem", b =>
                {
                    b.Property<Guid>("ModeloItemId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModeloAnoId")
                        .HasColumnType("uuid");

                    b.HasKey("ModeloItemId");

                    b.HasIndex("ItemId");

                    b.HasIndex("ModeloAnoId");

                    b.ToTable("ModeloItems");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.Property<string>("CPFCNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Carro", b =>
                {
                    b.HasOne("Manutemovel.Domain.Models.Entidades.ModeloAno", null)
                        .WithMany("Carros")
                        .HasForeignKey("ModeloAnoId");

                    b.HasOne("Manutemovel.Domain.Models.Entidades.Usuario", null)
                        .WithMany("Carros")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Historico", b =>
                {
                    b.HasOne("Manutemovel.Domain.Models.Entidades.Carro", null)
                        .WithMany()
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Manutemovel.Domain.Models.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.HistoricoItem", b =>
                {
                    b.HasOne("Manutemovel.Domain.Models.Entidades.Historico", null)
                        .WithMany()
                        .HasForeignKey("HistoricoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Manutemovel.Domain.Models.Entidades.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Modalidade", b =>
                {
                    b.HasOne("Manutemovel.Domain.Models.Entidades.ModeloItem", null)
                        .WithMany("Modalidades")
                        .HasForeignKey("ModeloItemId");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.ModeloAno", b =>
                {
                    b.HasOne("Manutemovel.Domain.Models.Entidades.Marca", null)
                        .WithMany("ModelosAnos")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.ModeloItem", b =>
                {
                    b.HasOne("Manutemovel.Domain.Models.Entidades.Item", null)
                        .WithMany("ModelosItens")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Manutemovel.Domain.Models.Entidades.ModeloAno", null)
                        .WithMany("ModelosItens")
                        .HasForeignKey("ModeloAnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Item", b =>
                {
                    b.Navigation("ModelosItens");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Marca", b =>
                {
                    b.Navigation("ModelosAnos");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.ModeloAno", b =>
                {
                    b.Navigation("Carros");

                    b.Navigation("ModelosItens");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.ModeloItem", b =>
                {
                    b.Navigation("Modalidades");
                });

            modelBuilder.Entity("Manutemovel.Domain.Models.Entidades.Usuario", b =>
                {
                    b.Navigation("Carros");
                });
#pragma warning restore 612, 618
        }
    }
}