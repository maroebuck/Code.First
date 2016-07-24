using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Code.First.Data;

namespace Code.First.Migrations
{
    [DbContext(typeof(CodeFirstContext))]
    partial class CodeFirstContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Code.First.Models.Gender", b =>
                {
                    b.Property<short>("GenderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenderName")
                        .HasAnnotation("MaxLength", 6);

                    b.HasKey("GenderId");

                    b.ToTable("Genders");
                });
        }
    }
}
