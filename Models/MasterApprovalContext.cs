using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CommonServiceCore.Models;

public partial class MasterApprovalContext : DbContext
{
    public MasterApprovalContext()
    {
    }

    public MasterApprovalContext(DbContextOptions<MasterApprovalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DataSectionK2> DataSectionK2s { get; set; }

    public virtual DbSet<EbatchApprovallevelM> EbatchApprovallevelMs { get; set; }

    public virtual DbSet<EbatchApprovaltypeM> EbatchApprovaltypeMs { get; set; }

    public virtual DbSet<EbatchApprvdetailM> EbatchApprvdetailMs { get; set; }

    public virtual DbSet<EbatchApprvheadM> EbatchApprvheadMs { get; set; }

    public virtual DbSet<EbatchApprvldetailT> EbatchApprvldetailTs { get; set; }

    public virtual DbSet<EbatchField> EbatchFields { get; set; }

    public virtual DbSet<EbatchHierarchytemporary> EbatchHierarchytemporaries { get; set; }

    public virtual DbSet<EbatchModulhead> EbatchModulheads { get; set; }

    public virtual DbSet<EbatchRoleidM> EbatchRoleidMs { get; set; }

    public virtual DbSet<EbatchSectionM> EbatchSectionMs { get; set; }

    public virtual DbSet<EbatchTemporaryhierarchy> EbatchTemporaryhierarchies { get; set; }

    public virtual DbSet<EbatchUserhierarchy> EbatchUserhierarchies { get; set; }

    public virtual DbSet<EbatchUsernameM> EbatchUsernameMs { get; set; }

    public virtual DbSet<EbatchUserroleidT> EbatchUserroleidTs { get; set; }

    public virtual DbSet<TblMApprovalHeaderUserPrivilage> TblMApprovalHeaderUserPrivilages { get; set; }

    public virtual DbSet<TblMSection> TblMSections { get; set; }

    public virtual DbSet<TblTDelegate> TblTDelegates { get; set; }

    public virtual DbSet<TblTErrorLog> TblTErrorLogs { get; set; }

    public virtual DbSet<TblTToken> TblTTokens { get; set; }

    public virtual DbSet<TblTTokenValidation> TblTTokenValidations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.100.19.52;Initial Catalog=Master_Approval;Persist Security Info=False;User ID=sab7;Password=sqlb7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DataSectionK2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataSectionK2");

            entity.Property(e => e.ApprovalType)
                .HasMaxLength(255)
                .HasColumnName("APPROVAL_TYPE");
            entity.Property(e => e.MappingCode)
                .HasMaxLength(255)
                .HasColumnName("MAPPING_CODE");
            entity.Property(e => e.Paygroup)
                .HasMaxLength(255)
                .HasColumnName("PAYGROUP");
            entity.Property(e => e.RfaRfpRfs)
                .HasMaxLength(255)
                .HasColumnName("RFA_RFP_RFS");
        });

        modelBuilder.Entity<EbatchApprovallevelM>(entity =>
        {
            entity.HasKey(e => e.IdlevelPk);

            entity.ToTable("EBATCH_APPROVALLEVEL_M");

            entity.Property(e => e.IdlevelPk)
                .HasMaxLength(10)
                .HasColumnName("IDLEVEL_PK");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<EbatchApprovaltypeM>(entity =>
        {
            entity.HasKey(e => e.ApprovaltypeidPk);

            entity.ToTable("EBATCH_APPROVALTYPE_M");

            entity.Property(e => e.ApprovaltypeidPk)
                .HasMaxLength(50)
                .HasColumnName("APPROVALTYPEID_PK");
            entity.Property(e => e.Approvaltype)
                .HasMaxLength(50)
                .HasColumnName("APPROVALTYPE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<EbatchApprvdetailM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_APPRVDETAIL_M");

            entity.Property(e => e.AmountLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Apprvlevel)
                .HasMaxLength(50)
                .HasColumnName("APPRVLEVEL");
            entity.Property(e => e.Apprvroleid)
                .HasMaxLength(50)
                .HasColumnName("APPRVROLEID");
            entity.Property(e => e.Apprvtype)
                .HasMaxLength(50)
                .HasColumnName("APPRVTYPE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.IdappsFk)
                .HasMaxLength(50)
                .HasColumnName("IDAPPS_FK");
            entity.Property(e => e.IdsectionFk)
                .HasMaxLength(50)
                .HasColumnName("IDSection_FK");
            entity.Property(e => e.Modulid)
                .HasMaxLength(50)
                .HasColumnName("MODULID");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<EbatchApprvheadM>(entity =>
        {
            entity.HasKey(e => e.Idapps);

            entity.ToTable("EBATCH_APPRVHEAD_M");

            entity.Property(e => e.Idapps)
                .HasMaxLength(50)
                .HasColumnName("IDAPPS");
            entity.Property(e => e.Applicationname)
                .HasMaxLength(255)
                .HasColumnName("APPLICATIONNAME");
            entity.Property(e => e.Applydate)
                .HasColumnType("datetime")
                .HasColumnName("APPLYDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<EbatchApprvldetailT>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_APPRVLDETAIL_T");

            entity.Property(e => e.AmountLimit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Applydate)
                .HasColumnType("datetime")
                .HasColumnName("APPLYDATE");
            entity.Property(e => e.Apprvlevel).HasColumnName("APPRVLEVEL");
            entity.Property(e => e.Apprvlroleid)
                .HasMaxLength(50)
                .HasColumnName("APPRVLROLEID");
            entity.Property(e => e.Attribute1).HasMaxLength(200);
            entity.Property(e => e.Attribute2).HasMaxLength(200);
            entity.Property(e => e.Attribute3).HasMaxLength(200);
            entity.Property(e => e.Attribute4).HasMaxLength(200);
            entity.Property(e => e.Attribute5).HasMaxLength(200);
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IdappsFk)
                .HasMaxLength(50)
                .HasColumnName("IDAPPS_FK");
            entity.Property(e => e.Idtransc)
                .HasMaxLength(50)
                .HasColumnName("IDTRANSC");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.Lob)
                .HasMaxLength(50)
                .HasColumnName("LOB");
            entity.Property(e => e.ModulidFk)
                .HasMaxLength(50)
                .HasColumnName("MODULID_FK");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Rejectreason).HasColumnName("REJECTREASON");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<EbatchField>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_FIELDS");

            entity.Property(e => e.AppsIdFk)
                .HasMaxLength(50)
                .HasColumnName("AppsID_FK");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.FieldName).HasMaxLength(50);
            entity.Property(e => e.ModulIdFk)
                .HasMaxLength(50)
                .HasColumnName("ModulID_FK");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.ValueField).HasMaxLength(50);
        });

        modelBuilder.Entity<EbatchHierarchytemporary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_HIERARCHYTEMPORARY");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Nama)
                .HasMaxLength(50)
                .HasColumnName("NAMA");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.Superiornik)
                .HasMaxLength(50)
                .HasColumnName("SUPERIORNIK");
        });

        modelBuilder.Entity<EbatchModulhead>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_MODULHEAD");

            entity.Property(e => e.Applydate)
                .HasColumnType("datetime")
                .HasColumnName("APPLYDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(50)
                .HasColumnName("DATABASE_NAME");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Idapps)
                .HasMaxLength(50)
                .HasColumnName("IDAPPS");
            entity.Property(e => e.Kategori1)
                .HasMaxLength(50)
                .HasColumnName("KATEGORI_1");
            entity.Property(e => e.Kategori2)
                .HasMaxLength(50)
                .HasColumnName("KATEGORI_2");
            entity.Property(e => e.Kategori3)
                .HasMaxLength(50)
                .HasColumnName("KATEGORI_3");
            entity.Property(e => e.Kategori4)
                .HasMaxLength(50)
                .HasColumnName("KATEGORI_4");
            entity.Property(e => e.Kategori5)
                .HasMaxLength(50)
                .HasColumnName("KATEGORI_5");
            entity.Property(e => e.Lob)
                .HasMaxLength(50)
                .HasColumnName("LOB");
            entity.Property(e => e.Modulid)
                .HasMaxLength(50)
                .HasColumnName("MODULID");
            entity.Property(e => e.Modulname)
                .HasMaxLength(250)
                .HasColumnName("MODULNAME");
            entity.Property(e => e.PkField)
                .HasMaxLength(50)
                .HasColumnName("PK_FIELD");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.ServerName)
                .HasMaxLength(50)
                .HasColumnName("SERVER_NAME");
            entity.Property(e => e.SpName)
                .HasMaxLength(50)
                .HasColumnName("SP_NAME");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Urlmodul)
                .HasMaxLength(500)
                .HasColumnName("URLMODUL");
            entity.Property(e => e.Urlwebhook)
                .HasMaxLength(500)
                .HasColumnName("URLWEBHOOK");
        });

        modelBuilder.Entity<EbatchRoleidM>(entity =>
        {
            entity.HasKey(e => e.Roleid);

            entity.ToTable("EBATCH_ROLEID_M");

            entity.Property(e => e.Roleid)
                .HasMaxLength(10)
                .HasColumnName("ROLEID");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Roledescription)
                .HasMaxLength(250)
                .HasColumnName("ROLEDESCRIPTION");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<EbatchSectionM>(entity =>
        {
            entity.HasKey(e => e.IdsectionPk);

            entity.ToTable("EBATCH_SECTION_M");

            entity.Property(e => e.IdsectionPk)
                .HasMaxLength(50)
                .HasColumnName("IDSection_PK");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.SectionName).HasMaxLength(500);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EbatchTemporaryhierarchy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_TEMPORARYHIERARCHY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nama)
                .HasMaxLength(50)
                .HasColumnName("NAMA");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Superiornik)
                .HasMaxLength(50)
                .HasColumnName("SUPERIORNIK");
        });

        modelBuilder.Entity<EbatchUserhierarchy>(entity =>
        {
            entity.HasKey(e => e.No);

            entity.ToTable("EBATCH_USERHIERARCHY");

            entity.Property(e => e.No).HasColumnName("NO");
            entity.Property(e => e.Empname)
                .HasMaxLength(250)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.Superiorid)
                .HasMaxLength(50)
                .HasColumnName("SUPERIORID");
            entity.Property(e => e.Superiorname)
                .HasMaxLength(250)
                .HasColumnName("SUPERIORNAME");
        });

        modelBuilder.Entity<EbatchUsernameM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_USERNAME_M");

            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.UsernamePk)
                .HasMaxLength(50)
                .HasColumnName("USERNAME_PK");
        });

        modelBuilder.Entity<EbatchUserroleidT>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBATCH_USERROLEID_T");

            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.RoleidFk)
                .HasMaxLength(50)
                .HasColumnName("ROLEID_FK");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<TblMApprovalHeaderUserPrivilage>(entity =>
        {
            entity.HasKey(e => e.Username);

            entity.ToTable("tblM_ApprovalHeaderUserPrivilage");

            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMSection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblM_Sections");

            entity.Property(e => e.Atribut1).HasMaxLength(200);
            entity.Property(e => e.Atribut2).HasMaxLength(200);
            entity.Property(e => e.Atribut3).HasMaxLength(200);
            entity.Property(e => e.Atribut4).HasMaxLength(200);
            entity.Property(e => e.Atribut5).HasMaxLength(200);
            entity.Property(e => e.Category1).HasMaxLength(200);
            entity.Property(e => e.Category2).HasMaxLength(200);
            entity.Property(e => e.Category3).HasMaxLength(200);
            entity.Property(e => e.Category4).HasMaxLength(200);
            entity.Property(e => e.Category5).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Idapps)
                .HasMaxLength(50)
                .HasColumnName("IDAPPS");
            entity.Property(e => e.Lob)
                .HasMaxLength(50)
                .HasColumnName("LOB");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.SectionDescription).HasMaxLength(1000);
            entity.Property(e => e.SectionName).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTDelegate>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tblT_Delegate");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateDelegeate).HasColumnType("datetime");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .HasColumnName("NIK");
            entity.Property(e => e.NikDelegate)
                .HasMaxLength(50)
                .HasColumnName("NIK_Delegate");
            entity.Property(e => e.RoleStatic)
                .HasMaxLength(50)
                .HasColumnName("Role_Static");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTErrorLog>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tblT_ErrorLog");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TransactionID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTToken>(entity =>
        {
            entity.HasKey(e => e.TokenPk);

            entity.ToTable("tblT_Token");

            entity.Property(e => e.TokenPk)
                .HasMaxLength(50)
                .HasColumnName("Token_PK");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Nik)
                .HasMaxLength(25)
                .HasColumnName("NIK");
            entity.Property(e => e.RecordId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecordID");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTTokenValidation>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tblT_TokenValidation");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.Idapps).HasColumnName("IDApps");
            entity.Property(e => e.Token).HasMaxLength(50);
            entity.Property(e => e.UserAd)
                .HasMaxLength(500)
                .HasColumnName("UserAD");
            entity.Property(e => e.ValidUntil).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
