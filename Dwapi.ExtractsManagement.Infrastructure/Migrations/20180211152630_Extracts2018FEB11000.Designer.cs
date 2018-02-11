﻿// <auto-generated />
using Dwapi.ExtractsManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dwapi.ExtractsManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ExtractsContext))]
    [Migration("20180211152630_Extracts2018FEB11000")]
    partial class Extracts2018FEB11000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Stage.Psmart.PsmartStage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime>("DateStaged");

                    b.Property<string>("Demographics")
                        .HasMaxLength(100);

                    b.Property<string>("Emr")
                        .HasMaxLength(50);

                    b.Property<string>("Encounters")
                        .HasMaxLength(100);

                    b.Property<int?>("FacilityCode");

                    b.Property<string>("Serial")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PsmartStages");
                });
#pragma warning restore 612, 618
        }
    }
}