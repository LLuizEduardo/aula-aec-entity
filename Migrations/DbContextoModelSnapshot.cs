﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aec_mvc_entity_framework.Servicos;

namespace aec_mvc_entity_framework.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("aec_mvc_entity_framework.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("matricula");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("notas");

                    b.HasKey("Id");

                    b.ToTable("alunos");
                });

            modelBuilder.Entity("aec_mvc_entity_framework.Models.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Tel")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefone");

                    b.HasKey("Codigo");

                    b.ToTable("tb_cliente");
                });

            modelBuilder.Entity("aec_mvc_entity_framework.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_do_pedido");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float")
                        .HasColumnName("valor_total");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("aec_mvc_entity_framework.Models.Pedido", b =>
                {
                    b.HasOne("aec_mvc_entity_framework.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("aec_mvc_entity_framework.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
