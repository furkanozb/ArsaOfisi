﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreArsaOfisi.Models.db
{
    public partial class u9673886_arsdbContext : DbContext
    {
        public u9673886_arsdbContext()
        {
        }

        public u9673886_arsdbContext(DbContextOptions<u9673886_arsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AdvertisementDetail> AdvertisementDetails { get; set; }
        public virtual DbSet<AdvertisementType> AdvertisementTypes { get; set; }
        public virtual DbSet<AdvertisementTypeProperty> AdvertisementTypeProperties { get; set; }
        public virtual DbSet<Advertiser> Advertisers { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<BuildingType> BuildingTypes { get; set; }
        public virtual DbSet<DeedStatus> DeedStatuses { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<NumberOfRoom> NumberOfRooms { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<SocialMedium> SocialMedia { get; set; }
        public virtual DbSet<TblRefTip> TblRefTips { get; set; }
        public virtual DbSet<VIlanDetay> VIlanDetays { get; set; }
        public virtual DbSet<VIlanListesi> VIlanListesis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=94.73.146.5;initial catalog=u9673886_arsdb;persist security info=True;user id=u9673886_arsdb;password=FStx14J6HPwq20L;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.ToTable("Advertisement");

                entity.Property(e => e.Adress).HasMaxLength(300);

                entity.Property(e => e.AdvertisementDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsForSale).HasColumnName("isForSale");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.AdvertisementType)
                    .WithMany(p => p.Advertisements)
                    .HasForeignKey(d => d.AdvertisementTypeId)
                    .HasConstraintName("FK_Advertisement_AdvertisementType");

                entity.HasOne(d => d.Advertiser)
                    .WithMany(p => p.Advertisements)
                    .HasForeignKey(d => d.AdvertiserId)
                    .HasConstraintName("FK_Advertisement_Advertiser");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Advertisements)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Advertisement_District");
            });

            modelBuilder.Entity<AdvertisementDetail>(entity =>
            {
                entity.ToTable("AdvertisementDetail");

                entity.Property(e => e.AdvertisementDetailId).HasColumnName("Advertisement_Detail_Id");

                entity.Property(e => e.AApartmentAge)
                    .HasColumnName("A_ApartmentAge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AFlatsOnTheFloor)
                    .HasColumnName("A_FlatsOnTheFloor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AHealtingType)
                    .HasMaxLength(50)
                    .HasColumnName("A_HealtingType");

                entity.Property(e => e.ANumberofFloors)
                    .HasColumnName("A_NumberofFloors")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ASquareMeters)
                    .HasColumnName("A_SquareMeters")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BuildingType).HasDefaultValueSql("((1))");

                entity.Property(e => e.HBuildingAge)
                    .HasColumnName("H_BuildingAge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HDues)
                    .HasColumnType("money")
                    .HasColumnName("H_Dues");

                entity.Property(e => e.HFloorLocation)
                    .HasColumnName("H_FloorLocation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HGrossSquareMeters)
                    .HasColumnName("H_GrossSquareMeters")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HHealtingType)
                    .HasMaxLength(40)
                    .HasColumnName("H_HealtingType");

                entity.Property(e => e.HInsidetheSite)
                    .HasColumnName("H_InsidetheSite")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HNetSquareMeters).HasColumnName("H_NetSquareMeters");

                entity.Property(e => e.HNumberofBathrooms)
                    .HasColumnName("H_NumberofBathrooms")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HNumberofFloorsoftheBuilding)
                    .HasColumnName("H_NumberofFloorsoftheBuilding")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HNumberofWc)
                    .HasColumnName("H_NumberofWC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HRentalIncome)
                    .HasColumnType("money")
                    .HasColumnName("H_RentalIncome")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LAdaNo).HasColumnName("L_AdaNo");

                entity.Property(e => e.LDeedStatudId).HasColumnName("L_DeedStatudId");

                entity.Property(e => e.LPaftaNo).HasColumnName("L_PaftaNo");

                entity.Property(e => e.LParselNo).HasColumnName("L_ParselNo");

                entity.Property(e => e.LSquareMeters).HasColumnName("L_SquareMeters");

                entity.Property(e => e.LZoningStatus).HasColumnName("L_ZoningStatus");

                entity.Property(e => e.NumberOfRoomsId).HasDefaultValueSql("((1))");

                entity.Property(e => e.WApartmentAge)
                    .HasColumnName("W_ApartmentAge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WFloorLocation).HasColumnName("W_FloorLocation");

                entity.Property(e => e.WGrossSquareMeters)
                    .HasColumnName("W_GrossSquareMeters")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WHealtingType)
                    .HasMaxLength(30)
                    .HasColumnName("W_HealtingType")
                    .HasDefaultValueSql("(N'Belirtilmemiş')");

                entity.Property(e => e.WNetSquareMeters)
                    .HasColumnName("W_NetSquareMeters")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.AdvertisementDetails)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_AdvertisementDetail_Advertisement");

                entity.HasOne(d => d.BuildingTypeNavigation)
                    .WithMany(p => p.AdvertisementDetails)
                    .HasForeignKey(d => d.BuildingType)
                    .HasConstraintName("FK_AdvertisementDetail_BuildingType1");

                entity.HasOne(d => d.LDeedStatud)
                    .WithMany(p => p.AdvertisementDetails)
                    .HasForeignKey(d => d.LDeedStatudId)
                    .HasConstraintName("FK_AdvertisementDetail_DeedStatus");

                entity.HasOne(d => d.NumberOfRooms)
                    .WithMany(p => p.AdvertisementDetails)
                    .HasForeignKey(d => d.NumberOfRoomsId)
                    .HasConstraintName("FK_AdvertisementDetail_NumberOfRooms1");
            });

            modelBuilder.Entity<AdvertisementType>(entity =>
            {
                entity.ToTable("AdvertisementType");

                entity.Property(e => e.AdvertisementTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<AdvertisementTypeProperty>(entity =>
            {
                entity.HasOne(d => d.AdvertisementType)
                    .WithMany(p => p.AdvertisementTypeProperties)
                    .HasForeignKey(d => d.AdvertisementTypeId)
                    .HasConstraintName("FK_AdvertisementTypeProperties_AdvertisementType");

                entity.HasOne(d => d.Properties)
                    .WithMany(p => p.AdvertisementTypeProperties)
                    .HasForeignKey(d => d.PropertiesId)
                    .HasConstraintName("FK_AdvertisementTypeProperties_Properties");
            });

            modelBuilder.Entity<Advertiser>(entity =>
            {
                entity.ToTable("Advertiser");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'default.png')");

                entity.Property(e => e.CompanyName).HasMaxLength(70);

                entity.Property(e => e.DateOfRegistration).HasColumnType("smalldatetime");

                entity.Property(e => e.LandPhone).HasMaxLength(11);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.OfficalName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.WhatsappNumber).HasMaxLength(11);

                entity.HasOne(d => d.Authority)
                    .WithMany(p => p.Advertisers)
                    .HasForeignKey(d => d.AuthorityId)
                    .HasConstraintName("FK_Advertiser_Authority");
            });

            modelBuilder.Entity<Authority>(entity =>
            {
                entity.ToTable("Authority");

                entity.Property(e => e.AuthorityName).HasMaxLength(50);
            });

            modelBuilder.Entity<BuildingType>(entity =>
            {
                entity.ToTable("BuildingType");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<DeedStatus>(entity =>
            {
                entity.ToTable("DeedStatus");

                entity.Property(e => e.DeedStatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_District_Province");
            });

            modelBuilder.Entity<NumberOfRoom>(entity =>
            {
                entity.Property(e => e.RoomName).HasMaxLength(50);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.FotTipId).HasColumnName("FotTipID");

                entity.Property(e => e.PhotoUrl).HasMaxLength(50);

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_Photos_Advertisement1");

                entity.HasOne(d => d.FotTip)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.FotTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photos_tbl_Ref_Tip");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(e => e.PropertiesName).HasMaxLength(50);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);
            });

            modelBuilder.Entity<SocialMedium>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Facebook)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.GooglePlus)
                    .HasMaxLength(60)
                    .HasColumnName("Google_Plus")
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Pinterest)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Skype)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Twitter)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Vimeo)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.WebSite)
                    .HasMaxLength(60)
                    .HasColumnName("Web_Site")
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Youtube)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'-')");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.SocialMedium)
                    .HasForeignKey<SocialMedium>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SocialMedia_Id");
            });

            modelBuilder.Entity<TblRefTip>(entity =>
            {
                entity.ToTable("tbl_Ref_Tip");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OrdId).HasColumnName("ordId");

                entity.Property(e => e.Vsbl).HasColumnName("vsbl");
            });

            modelBuilder.Entity<VIlanDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ilan_detay");

                entity.Property(e => e.AApartmentAge).HasColumnName("A_ApartmentAge");

                entity.Property(e => e.AFlatsOnTheFloor).HasColumnName("A_FlatsOnTheFloor");

                entity.Property(e => e.AHealtingType)
                    .HasMaxLength(50)
                    .HasColumnName("A_HealtingType");

                entity.Property(e => e.ANumberofFloors).HasColumnName("A_NumberofFloors");

                entity.Property(e => e.ASquareMeters).HasColumnName("A_SquareMeters");

                entity.Property(e => e.Adress).HasMaxLength(300);

                entity.Property(e => e.AdvertisementDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AdvertisementTypeName).HasMaxLength(50);

                entity.Property(e => e.Avatar).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(70);

                entity.Property(e => e.DeedStatusName).HasMaxLength(50);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.HBuildingAge).HasColumnName("H_BuildingAge");

                entity.Property(e => e.HDues)
                    .HasColumnType("money")
                    .HasColumnName("H_Dues");

                entity.Property(e => e.HFloorLocation).HasColumnName("H_FloorLocation");

                entity.Property(e => e.HGrossSquareMeters).HasColumnName("H_GrossSquareMeters");

                entity.Property(e => e.HHealtingType)
                    .HasMaxLength(40)
                    .HasColumnName("H_HealtingType");

                entity.Property(e => e.HInsidetheSite).HasColumnName("H_InsidetheSite");

                entity.Property(e => e.HNumberofBathrooms).HasColumnName("H_NumberofBathrooms");

                entity.Property(e => e.HNumberofFloorsoftheBuilding).HasColumnName("H_NumberofFloorsoftheBuilding");

                entity.Property(e => e.HNumberofWc).HasColumnName("H_NumberofWC");

                entity.Property(e => e.HRentalIncome)
                    .HasColumnType("money")
                    .HasColumnName("H_RentalIncome");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsForSale).HasColumnName("isForSale");

                entity.Property(e => e.LandPhone).HasMaxLength(11);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.OfficalName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);

                entity.Property(e => e.RoomName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.TypeName).HasMaxLength(50);

                entity.Property(e => e.WApartmentAge).HasColumnName("W_ApartmentAge");

                entity.Property(e => e.WFloorLocation).HasColumnName("W_FloorLocation");

                entity.Property(e => e.WGrossSquareMeters).HasColumnName("W_GrossSquareMeters");

                entity.Property(e => e.WHealtingType)
                    .HasMaxLength(30)
                    .HasColumnName("W_HealtingType");

                entity.Property(e => e.WNetSquareMeters).HasColumnName("W_NetSquareMeters");

                entity.Property(e => e.WhatsappNumber).HasMaxLength(11);
            });

            modelBuilder.Entity<VIlanListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ilan_listesi");

                entity.Property(e => e.Adress).HasMaxLength(300);

                entity.Property(e => e.AdvertisementDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AdvertisementTypeName).HasMaxLength(50);

                entity.Property(e => e.Avatar).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(70);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsForSale).HasColumnName("isForSale");

                entity.Property(e => e.PhotoUrl).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
