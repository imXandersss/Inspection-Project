// <auto-generated />
using InspectionAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InspectionAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220911224738_secondmigration")]
    partial class secondmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InspectionAPI.Models.Inspection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("inspectionTypeId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.HasIndex("inspectionTypeId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("InspectionAPI.Models.InspectionType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("inspectionName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("InspectionType");
                });

            modelBuilder.Entity("InspectionAPI.Models.Status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("statusOptions")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("InspectionAPI.Models.Inspection", b =>
                {
                    b.HasOne("InspectionAPI.Models.InspectionType", "inspectionType")
                        .WithMany()
                        .HasForeignKey("inspectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("inspectionType");
                });
#pragma warning restore 612, 618
        }
    }
}
