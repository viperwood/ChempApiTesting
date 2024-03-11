using System;
using System.Collections.Generic;
using ApiChemp.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChemp.Context;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Medcart> Medcarts { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Resept> Resepts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Tipeevent> Tipeevents { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host = 89.110.53.87; Database = postgres; Username = postgres; Password = 492492");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_pkey");

            entity.ToTable("events", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dataevent)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataevent");
            entity.Property(e => e.Doctor).HasColumnName("doctor");
            entity.Property(e => e.Eventid).HasColumnName("eventid");
            entity.Property(e => e.Medcartid).HasColumnName("medcartid");
            entity.Property(e => e.Nameevent)
                .HasMaxLength(100)
                .HasColumnName("nameevent");
            entity.Property(e => e.Opisanie)
                .HasMaxLength(100)
                .HasColumnName("opisanie");
            entity.Property(e => e.Resultevent)
                .HasMaxLength(100)
                .HasColumnName("resultevent");

            entity.HasOne(d => d.DoctorNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.Doctor)
                .HasConstraintName("events_doctor_fkey");

            entity.HasOne(d => d.EventNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("events_eventid_fkey");

            entity.HasOne(d => d.Medcart).WithMany(p => p.Events)
                .HasForeignKey(d => d.Medcartid)
                .HasConstraintName("events_medcartid_fkey");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genders_pkey");

            entity.ToTable("genders", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Namegender)
                .HasMaxLength(100)
                .HasColumnName("namegender");
        });

        modelBuilder.Entity<Medcart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("medcarts_pkey");

            entity.ToTable("medcarts", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diagnos)
                .HasMaxLength(100)
                .HasColumnName("diagnos");
            entity.Property(e => e.Numbermedcart).HasColumnName("numbermedcart");
            entity.Property(e => e.Patientid).HasColumnName("patientid");

            entity.HasOne(d => d.Patient).WithMany(p => p.Medcarts)
                .HasForeignKey(d => d.Patientid)
                .HasConstraintName("medcarts_patientid_fkey");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("patients_pkey");

            entity.ToTable("patients", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bethday)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("bethday");
            entity.Property(e => e.Datafinishpolis)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datafinishpolis");
            entity.Property(e => e.Datagetmeadcart)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datagetmeadcart");
            entity.Property(e => e.Datalastvisit)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datalastvisit");
            entity.Property(e => e.Datanextvisit)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datanextvisit");
            entity.Property(e => e.Numberpolis).HasColumnName("numberpolis");
            entity.Property(e => e.Pasportn).HasColumnName("pasportn");
            entity.Property(e => e.Pasports).HasColumnName("pasports");
            entity.Property(e => e.Strahovcompani)
                .HasMaxLength(100)
                .HasColumnName("strahovcompani");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Worck)
                .HasMaxLength(100)
                .HasColumnName("worck");

            entity.HasOne(d => d.User).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("patients_userid_fkey");
        });

        modelBuilder.Entity<Resept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resepts_pkey");

            entity.ToTable("resepts", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Eventid).HasColumnName("eventid");
            entity.Property(e => e.Preparat)
                .HasMaxLength(100)
                .HasColumnName("preparat");
            entity.Property(e => e.Procedur)
                .HasMaxLength(100)
                .HasColumnName("procedur");
            entity.Property(e => e.Recomendation)
                .HasMaxLength(100)
                .HasColumnName("recomendation");

            entity.HasOne(d => d.Event).WithMany(p => p.Resepts)
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("resepts_eventid_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Namerole)
                .HasMaxLength(100)
                .HasColumnName("namerole");
        });

        modelBuilder.Entity<Tipeevent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipeevents_pkey");

            entity.ToTable("tipeevents", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nameevent)
                .HasMaxLength(100)
                .HasColumnName("nameevent");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users", "BDChemp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adres)
                .HasMaxLength(100)
                .HasColumnName("adres");
            entity.Property(e => e.Emailuser)
                .HasMaxLength(100)
                .HasColumnName("emailuser");
            entity.Property(e => e.Foto)
                .HasMaxLength(100)
                .HasColumnName("foto");
            entity.Property(e => e.Genderuser).HasColumnName("genderuser");
            entity.Property(e => e.Nameuser)
                .HasMaxLength(100)
                .HasColumnName("nameuser");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.Roleuser).HasColumnName("roleuser");

            entity.HasOne(d => d.GenderuserNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Genderuser)
                .HasConstraintName("users_genderuser_fkey");

            entity.HasOne(d => d.RoleuserNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Roleuser)
                .HasConstraintName("users_roleuser_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
