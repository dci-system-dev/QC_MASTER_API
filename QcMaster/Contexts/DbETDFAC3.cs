using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QcMaster.Models;

namespace QcMaster.Contexts;

public partial class DbETDFAC3 : DbContext
{
    public DbETDFAC3()
    {
    }

    public DbETDFAC3(DbContextOptions<DbETDFAC3> options)
        : base(options)
    {
    }

    public virtual DbSet<EtdCrankShaft> EtdCrankShafts { get; set; }

    public virtual DbSet<EtdCsEcc> EtdCsEccs { get; set; }

    public virtual DbSet<EtdCsOdFr> EtdCsOdFrs { get; set; }

    public virtual DbSet<EtdCsOdPin> EtdCsOdPins { get; set; }

    public virtual DbSet<EtdCyHeight> EtdCyHeights { get; set; }

    public virtual DbSet<EtdCyIdBore> EtdCyIdBores { get; set; }

    public virtual DbSet<EtdCyIdBush> EtdCyIdBushes { get; set; }

    public virtual DbSet<EtdCylinder> EtdCylinders { get; set; }

    public virtual DbSet<EtdFhDetail> EtdFhDetails { get; set; }

    public virtual DbSet<EtdFhFlatness> EtdFhFlatnesses { get; set; }

    public virtual DbSet<EtdFrontHead> EtdFrontHeads { get; set; }

    public virtual DbSet<EtdMstModel> EtdMstModels { get; set; }

    public virtual DbSet<EtdPartValue> EtdPartValues { get; set; }

    public virtual DbSet<EtdPiston> EtdPistons { get; set; }

    public virtual DbSet<EtdPtBlade> EtdPtBlades { get; set; }

    public virtual DbSet<EtdPtFlatness> EtdPtFlatnesses { get; set; }

    public virtual DbSet<EtdPtHeight> EtdPtHeights { get; set; }

    public virtual DbSet<EtdPtId> EtdPtIds { get; set; }

    public virtual DbSet<EtdPtOd> EtdPtOds { get; set; }

    public virtual DbSet<EtdRearHead> EtdRearHeads { get; set; }

    public virtual DbSet<EtdRhDetail> EtdRhDetails { get; set; }

    public virtual DbSet<EtdRhFlatness> EtdRhFlatnesses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.194.40.103;Database=ETD_FAC3;TrustServerCertificate=True;uid=sa;password=decjapan");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<EtdCrankShaft>(entity =>
        {
            entity.HasKey(e => e.CsId);

            entity.ToTable("etd_crank_shaft", tb =>
                {
                    tb.HasTrigger("crank_shaft_count");
                    tb.HasTrigger("crank_shaft_total_shift");
                });

            entity.HasIndex(e => e.MId, "NonClusteredIndex-20190724-170833");

            entity.HasIndex(e => new { e.CsDate, e.CsJudgement }, "cs_judge_time");

            entity.HasIndex(e => new { e.CsJudgement, e.CsLine, e.FirstStamptime }, "inx_20190627_etd_crank_shaft");

            entity.Property(e => e.CsId)
                .HasMaxLength(20)
                .HasColumnName("cs_id");
            entity.Property(e => e.CsDate)
                .HasColumnType("datetime")
                .HasColumnName("cs_date");
            entity.Property(e => e.CsJudgement)
                .HasMaxLength(4)
                .HasColumnName("cs_judgement");
            entity.Property(e => e.CsLine)
                .HasMaxLength(100)
                .HasColumnName("cs_line");
            entity.Property(e => e.CsMode)
                .HasMaxLength(10)
                .HasColumnName("cs_mode");
            entity.Property(e => e.CsPosition).HasColumnName("cs_position");
            entity.Property(e => e.FirstStamptime)
                .HasColumnType("datetime")
                .HasColumnName("first_stamptime");
            entity.Property(e => e.MId)
                .HasMaxLength(20)
                .HasColumnName("m_id");
            entity.Property(e => e.ProId)
                .HasMaxLength(20)
                .HasColumnName("pro_id");
        });

        modelBuilder.Entity<EtdCsEcc>(entity =>
        {
            entity.HasKey(e => e.CsId);

            entity.ToTable("etd_cs_ecc");

            entity.HasIndex(e => new { e.CsEccJudgement, e.CsEccDate }, "cs_ecc_judge_time");

            entity.Property(e => e.CsId)
                .HasMaxLength(20)
                .HasColumnName("cs_id");
            entity.Property(e => e.CsEccDate)
                .HasColumnType("datetime")
                .HasColumnName("cs_ecc_date");
            entity.Property(e => e.CsEccJudgement)
                .HasMaxLength(4)
                .HasColumnName("cs_ecc_judgement");
            entity.Property(e => e.CsEccRank).HasColumnName("cs_ecc_rank");
            entity.Property(e => e.CsEccRankC)
                .HasMaxLength(4)
                .HasColumnName("cs_ecc_rank_c");
        });

        modelBuilder.Entity<EtdCsOdFr>(entity =>
        {
            entity.HasKey(e => e.CsId);

            entity.ToTable("etd_cs_od_fr");

            entity.HasIndex(e => new { e.CsFrJudgement, e.CsFrDate }, "cs_fr_judge_time");

            entity.Property(e => e.CsId)
                .HasMaxLength(20)
                .HasColumnName("cs_id");
            entity.Property(e => e.CsFrDate)
                .HasColumnType("datetime")
                .HasColumnName("cs_fr_date");
            entity.Property(e => e.CsFrFCylindricity).HasColumnName("cs_fr_f_cylindricity");
            entity.Property(e => e.CsFrFJudgeRoundness).HasColumnName("cs_fr_f_judge_roundness");
            entity.Property(e => e.CsFrFRank).HasColumnName("cs_fr_f_rank");
            entity.Property(e => e.CsFrFRankC)
                .HasMaxLength(4)
                .HasColumnName("cs_fr_f_rank_c");
            entity.Property(e => e.CsFrJudgement)
                .HasMaxLength(4)
                .HasColumnName("cs_fr_judgement");
            entity.Property(e => e.CsFrOd1).HasColumnName("cs_fr_od1");
            entity.Property(e => e.CsFrOd2).HasColumnName("cs_fr_od2");
            entity.Property(e => e.CsFrOd3).HasColumnName("cs_fr_od3");
            entity.Property(e => e.CsFrOd4).HasColumnName("cs_fr_od4");
            entity.Property(e => e.CsFrOd5).HasColumnName("cs_fr_od5");
            entity.Property(e => e.CsFrRCylindricity).HasColumnName("cs_fr_r_cylindricity");
            entity.Property(e => e.CsFrRJudgeRoundness).HasColumnName("cs_fr_r_judge_roundness");
            entity.Property(e => e.CsFrRRank).HasColumnName("cs_fr_r_rank");
            entity.Property(e => e.CsFrRRankC)
                .HasMaxLength(4)
                .HasColumnName("cs_fr_r_rank_c");
            entity.Property(e => e.CsFrRoundness1).HasColumnName("cs_fr_roundness1");
            entity.Property(e => e.CsFrRoundness2).HasColumnName("cs_fr_roundness2");
            entity.Property(e => e.CsFrRoundness3).HasColumnName("cs_fr_roundness3");
            entity.Property(e => e.CsFrRoundness4).HasColumnName("cs_fr_roundness4");
            entity.Property(e => e.CsFrRoundness5).HasColumnName("cs_fr_roundness5");
        });

        modelBuilder.Entity<EtdCsOdPin>(entity =>
        {
            entity.HasKey(e => e.CsId);

            entity.ToTable("etd_cs_od_pin");

            entity.HasIndex(e => new { e.CsPinJudgement, e.CsPinDate }, "cs_pin_judge_time");

            entity.Property(e => e.CsId)
                .HasMaxLength(20)
                .HasColumnName("cs_id");
            entity.Property(e => e.CsPinCylindricity).HasColumnName("cs_pin_cylindricity");
            entity.Property(e => e.CsPinDate)
                .HasColumnType("datetime")
                .HasColumnName("cs_pin_date");
            entity.Property(e => e.CsPinJudgeRoundness).HasColumnName("cs_pin_judge_roundness");
            entity.Property(e => e.CsPinJudgement)
                .HasMaxLength(4)
                .HasColumnName("cs_pin_judgement");
            entity.Property(e => e.CsPinOd1).HasColumnName("cs_pin_od1");
            entity.Property(e => e.CsPinOd2).HasColumnName("cs_pin_od2");
            entity.Property(e => e.CsPinOd3).HasColumnName("cs_pin_od3");
            entity.Property(e => e.CsPinRank).HasColumnName("cs_pin_rank");
            entity.Property(e => e.CsPinRankC)
                .HasMaxLength(4)
                .HasColumnName("cs_pin_rank_c");
            entity.Property(e => e.CsPinRoundness1).HasColumnName("cs_pin_roundness1");
            entity.Property(e => e.CsPinRoundness2).HasColumnName("cs_pin_roundness2");
            entity.Property(e => e.CsPinRoundness3).HasColumnName("cs_pin_roundness3");
        });

        modelBuilder.Entity<EtdCyHeight>(entity =>
        {
            entity.HasKey(e => e.CyId);

            entity.ToTable("etd_cy_height");

            entity.HasIndex(e => new { e.CyHeJudgement, e.CyHeDate }, "cy_hei_judge_time");

            entity.Property(e => e.CyId)
                .HasMaxLength(20)
                .HasColumnName("cy_id");
            entity.Property(e => e.CyHe1).HasColumnName("cy_he1");
            entity.Property(e => e.CyHe2).HasColumnName("cy_he2");
            entity.Property(e => e.CyHe3).HasColumnName("cy_he3");
            entity.Property(e => e.CyHe4).HasColumnName("cy_he4");
            entity.Property(e => e.CyHeDate)
                .HasColumnType("datetime")
                .HasColumnName("cy_he_date");
            entity.Property(e => e.CyHeJudgement)
                .HasMaxLength(4)
                .HasColumnName("cy_he_judgement");
            entity.Property(e => e.CyHeMode)
                .HasMaxLength(10)
                .HasColumnName("cy_he_mode");
            entity.Property(e => e.CyHeParallism).HasColumnName("cy_he_parallism");
            entity.Property(e => e.CyHeRank).HasColumnName("cy_he_rank");
            entity.Property(e => e.CyHeRankC)
                .HasMaxLength(4)
                .HasColumnName("cy_he_rank_c");
        });

        modelBuilder.Entity<EtdCyIdBore>(entity =>
        {
            entity.HasKey(e => e.CyId);

            entity.ToTable("etd_cy_id_bore");

            entity.HasIndex(e => new { e.CyBoJudgement, e.CyBoDate }, "cy_bo_judge_time");

            entity.Property(e => e.CyId)
                .HasMaxLength(20)
                .HasColumnName("cy_id");
            entity.Property(e => e.CyBo1).HasColumnName("cy_bo1");
            entity.Property(e => e.CyBo2).HasColumnName("cy_bo2");
            entity.Property(e => e.CyBo3).HasColumnName("cy_bo3");
            entity.Property(e => e.CyBoConcentricity).HasColumnName("cy_bo_concentricity");
            entity.Property(e => e.CyBoCylindricity).HasColumnName("cy_bo_cylindricity");
            entity.Property(e => e.CyBoDate)
                .HasColumnType("datetime")
                .HasColumnName("cy_bo_date");
            entity.Property(e => e.CyBoJudgeRoundness).HasColumnName("cy_bo_judge_roundness");
            entity.Property(e => e.CyBoJudgement)
                .HasMaxLength(4)
                .HasColumnName("cy_bo_judgement");
            entity.Property(e => e.CyBoPerpendicularity).HasColumnName("cy_bo_perpendicularity");
            entity.Property(e => e.CyBoRank).HasColumnName("cy_bo_rank");
            entity.Property(e => e.CyBoRankC)
                .HasMaxLength(4)
                .HasColumnName("cy_bo_rank_c");
            entity.Property(e => e.CyBoRoundness1).HasColumnName("cy_bo_roundness1");
            entity.Property(e => e.CyBoRoundness2).HasColumnName("cy_bo_roundness2");
            entity.Property(e => e.CyBoRoundness3).HasColumnName("cy_bo_roundness3");
        });

        modelBuilder.Entity<EtdCyIdBush>(entity =>
        {
            entity.HasKey(e => e.CyId);

            entity.ToTable("etd_cy_id_bush");

            entity.HasIndex(e => new { e.CyBuJudgement, e.CyBuDate }, "cy_bu_judge_time");

            entity.Property(e => e.CyId)
                .HasMaxLength(20)
                .HasColumnName("cy_id");
            entity.Property(e => e.CyBu1).HasColumnName("cy_bu1");
            entity.Property(e => e.CyBu2).HasColumnName("cy_bu2");
            entity.Property(e => e.CyBu3).HasColumnName("cy_bu3");
            entity.Property(e => e.CyBuCylindricity).HasColumnName("cy_bu_cylindricity");
            entity.Property(e => e.CyBuDate)
                .HasColumnType("datetime")
                .HasColumnName("cy_bu_date");
            entity.Property(e => e.CyBuJudgeRoundness).HasColumnName("cy_bu_judge_roundness");
            entity.Property(e => e.CyBuJudgement)
                .HasMaxLength(4)
                .HasColumnName("cy_bu_judgement");
            entity.Property(e => e.CyBuPerpendicularity).HasColumnName("cy_bu_perpendicularity");
            entity.Property(e => e.CyBuRank).HasColumnName("cy_bu_rank");
            entity.Property(e => e.CyBuRankC)
                .HasMaxLength(4)
                .HasColumnName("cy_bu_rank_c");
            entity.Property(e => e.CyBuRoundness1).HasColumnName("cy_bu_roundness1");
            entity.Property(e => e.CyBuRoundness2).HasColumnName("cy_bu_roundness2");
            entity.Property(e => e.CyBuRoundness3).HasColumnName("cy_bu_roundness3");
        });

        modelBuilder.Entity<EtdCylinder>(entity =>
        {
            entity.HasKey(e => e.CyId);

            entity.ToTable("etd_cylinder", tb =>
                {
                    tb.HasTrigger("cylinder_count");
                    tb.HasTrigger("cylinder_total_shift");
                });

            entity.HasIndex(e => e.MId, "NonClusteredIndex-20190724-170859");

            entity.HasIndex(e => new { e.CyJudgement, e.CyDate }, "cy_judge_time");

            entity.HasIndex(e => new { e.CyLine, e.CyId, e.FirstStamptime }, "idxnon_cy_judge");

            entity.HasIndex(e => new { e.CyLine, e.CyJudgement, e.CyId, e.FirstStamptime }, "idxnon_cy_mcid");

            entity.Property(e => e.CyId)
                .HasMaxLength(20)
                .HasColumnName("cy_id");
            entity.Property(e => e.CyDate)
                .HasColumnType("datetime")
                .HasColumnName("cy_date");
            entity.Property(e => e.CyJudgement)
                .HasMaxLength(4)
                .HasColumnName("cy_judgement");
            entity.Property(e => e.CyLine)
                .HasMaxLength(100)
                .HasColumnName("cy_line");
            entity.Property(e => e.CyMode)
                .HasMaxLength(10)
                .HasColumnName("cy_mode");
            entity.Property(e => e.CyPosition).HasColumnName("cy_position");
            entity.Property(e => e.FirstStamptime)
                .HasColumnType("datetime")
                .HasColumnName("first_stamptime");
            entity.Property(e => e.MId)
                .HasMaxLength(20)
                .HasColumnName("m_id");
            entity.Property(e => e.ProId)
                .HasMaxLength(20)
                .HasColumnName("pro_id");
        });

        modelBuilder.Entity<EtdFhDetail>(entity =>
        {
            entity.HasKey(e => e.FhId);

            entity.ToTable("etd_fh_detail");

            entity.HasIndex(e => new { e.FhJudgement, e.FhDate }, "fh_id_judge_time");

            entity.Property(e => e.FhId)
                .HasMaxLength(20)
                .HasColumnName("fh_id");
            entity.Property(e => e.FhConcentricity).HasColumnName("fh_concentricity");
            entity.Property(e => e.FhCylindricity).HasColumnName("fh_cylindricity");
            entity.Property(e => e.FhDate)
                .HasColumnType("datetime")
                .HasColumnName("fh_date");
            entity.Property(e => e.FhId1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fh_id1");
            entity.Property(e => e.FhId2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fh_id2");
            entity.Property(e => e.FhId3).HasColumnName("fh_id3");
            entity.Property(e => e.FhJudgeRoundness).HasColumnName("fh_judge_roundness");
            entity.Property(e => e.FhJudgement)
                .HasMaxLength(4)
                .HasColumnName("fh_judgement");
            entity.Property(e => e.FhPerpendicularity).HasColumnName("fh_perpendicularity");
            entity.Property(e => e.FhRank).HasColumnName("fh_rank");
            entity.Property(e => e.FhRankC)
                .HasMaxLength(4)
                .HasColumnName("fh_rank_c");
            entity.Property(e => e.FhRonudness3).HasColumnName("fh_ronudness3");
            entity.Property(e => e.FhRoundness1).HasColumnName("fh_roundness1");
            entity.Property(e => e.FhRoundness2).HasColumnName("fh_roundness2");
        });

        modelBuilder.Entity<EtdFhFlatness>(entity =>
        {
            entity.HasKey(e => e.FhId);

            entity.ToTable("etd_fh_flatness");

            entity.HasIndex(e => new { e.FhFlJudgement, e.FhFlDate }, "fh_fl_judge_time");

            entity.Property(e => e.FhId)
                .HasMaxLength(20)
                .HasColumnName("fh_id");
            entity.Property(e => e.FhFl1Judge).HasColumnName("fh_fl1_judge");
            entity.Property(e => e.FhFl1JudgeRank)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fh_fl1_judge_rank");
            entity.Property(e => e.FhFl1Max).HasColumnName("fh_fl1_max");
            entity.Property(e => e.FhFl1Min).HasColumnName("fh_fl1_min");
            entity.Property(e => e.FhFl1PointMax).HasColumnName("fh_fl1_point_max");
            entity.Property(e => e.FhFl1PointMin).HasColumnName("fh_fl1_point_min");
            entity.Property(e => e.FhFl2Judge).HasColumnName("fh_fl2_judge");
            entity.Property(e => e.FhFl2JudgeRank)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fh_fl2_judge_rank");
            entity.Property(e => e.FhFl2Max).HasColumnName("fh_fl2_max");
            entity.Property(e => e.FhFl2Min).HasColumnName("fh_fl2_min");
            entity.Property(e => e.FhFl2PointMax).HasColumnName("fh_fl2_point_max");
            entity.Property(e => e.FhFl2PointMin).HasColumnName("fh_fl2_point_min");
            entity.Property(e => e.FhFlDate)
                .HasColumnType("datetime")
                .HasColumnName("fh_fl_date");
            entity.Property(e => e.FhFlJudgement)
                .HasMaxLength(4)
                .HasColumnName("fh_fl_judgement");
        });

        modelBuilder.Entity<EtdFrontHead>(entity =>
        {
            entity.HasKey(e => e.FhId);

            entity.ToTable("etd_front_head", tb =>
                {
                    tb.HasTrigger("front_head_count");
                    tb.HasTrigger("front_head_total_shift");
                });

            entity.HasIndex(e => e.MId, "NonClusteredIndex-20190724-170811");

            entity.HasIndex(e => new { e.FhJudgement, e.FhDate }, "fh_judge_time");

            entity.HasIndex(e => new { e.FhLine, e.FhId, e.FirstStamptime }, "idxnon_FH_judge");

            entity.HasIndex(e => new { e.FhLine, e.FhJudgement, e.FhId, e.FirstStamptime }, "inx_20190617_etd_front_head");

            entity.Property(e => e.FhId)
                .HasMaxLength(20)
                .HasColumnName("fh_id");
            entity.Property(e => e.FhDate)
                .HasColumnType("datetime")
                .HasColumnName("fh_date");
            entity.Property(e => e.FhJudgement)
                .HasMaxLength(4)
                .HasColumnName("fh_judgement");
            entity.Property(e => e.FhLine)
                .HasMaxLength(100)
                .HasColumnName("fh_line");
            entity.Property(e => e.FhMode)
                .HasMaxLength(10)
                .HasColumnName("fh_mode");
            entity.Property(e => e.FhPosition).HasColumnName("fh_position");
            entity.Property(e => e.FirstStamptime)
                .HasColumnType("datetime")
                .HasColumnName("first_stamptime");
            entity.Property(e => e.MId)
                .HasMaxLength(20)
                .HasColumnName("m_id");
            entity.Property(e => e.ProId)
                .HasMaxLength(20)
                .HasColumnName("pro_id");
        });

        modelBuilder.Entity<EtdMstModel>(entity =>
        {
            entity.HasKey(e => e.MId);

            entity.ToTable("etd_mst_model");

            entity.Property(e => e.MId)
                .HasMaxLength(20)
                .HasColumnName("m_id");
            entity.Property(e => e.MDate)
                .HasColumnType("datetime")
                .HasColumnName("m_date");
            entity.Property(e => e.MName)
                .HasMaxLength(50)
                .HasColumnName("m_name");
            entity.Property(e => e.MUser)
                .HasMaxLength(50)
                .HasColumnName("m_user");
        });

        modelBuilder.Entity<EtdPartValue>(entity =>
        {
            entity.HasKey(e => new { e.PartNo, e.MufflerId });

            entity.ToTable("etd_part_value");

            entity.Property(e => e.PartNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("part_no");
            entity.Property(e => e.MufflerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("muffler_id");
            entity.Property(e => e.PId).HasColumnName("p_id");
        });

        modelBuilder.Entity<EtdPiston>(entity =>
        {
            entity.HasKey(e => e.PtId);

            entity.ToTable("etd_piston", tb =>
                {
                    tb.HasTrigger("piston_count");
                    tb.HasTrigger("piston_total_shift");
                });

            entity.HasIndex(e => e.MId, "NonClusteredIndex-20190724-170940");

            entity.HasIndex(e => new { e.PtLine, e.PtId, e.FirstStamptime }, "idxnon_PT_judge");

            entity.HasIndex(e => new { e.PtLine, e.PtJudgement, e.PtId, e.FirstStamptime }, "inx_20190617_etd_piston");

            entity.HasIndex(e => new { e.PtJudgement, e.PtDate }, "pt_judge_time");

            entity.HasIndex(e => e.PtLine, "pt_line");

            entity.Property(e => e.PtId)
                .HasMaxLength(20)
                .HasColumnName("pt_id");
            entity.Property(e => e.FirstStamptime)
                .HasColumnType("datetime")
                .HasColumnName("first_stamptime");
            entity.Property(e => e.MId)
                .HasMaxLength(20)
                .HasColumnName("m_id");
            entity.Property(e => e.ProId)
                .HasMaxLength(20)
                .HasColumnName("pro_id");
            entity.Property(e => e.PtDate)
                .HasColumnType("datetime")
                .HasColumnName("pt_date");
            entity.Property(e => e.PtJudgement)
                .HasMaxLength(4)
                .HasColumnName("pt_judgement");
            entity.Property(e => e.PtLine)
                .HasMaxLength(100)
                .HasColumnName("pt_line");
            entity.Property(e => e.PtMode)
                .HasMaxLength(10)
                .HasColumnName("pt_mode");
            entity.Property(e => e.PtPosition).HasColumnName("pt_position");
        });

        modelBuilder.Entity<EtdPtBlade>(entity =>
        {
            entity.HasKey(e => e.PtId).HasName("PK__etd_pt_b__5630B1207755B73D");

            entity.ToTable("etd_pt_blade");

            entity.HasIndex(e => new { e.PtBlJudgement, e.PtBlDate }, "pt_bl_judge_time");

            entity.Property(e => e.PtId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pt_id");
            entity.Property(e => e.PtBl1).HasColumnName("pt_bl1");
            entity.Property(e => e.PtBl2).HasColumnName("pt_bl2");
            entity.Property(e => e.PtBl3).HasColumnName("pt_bl3");
            entity.Property(e => e.PtBl4).HasColumnName("pt_bl4");
            entity.Property(e => e.PtBl5).HasColumnName("pt_bl5");
            entity.Property(e => e.PtBl6).HasColumnName("pt_bl6");
            entity.Property(e => e.PtBlDate)
                .HasColumnType("datetime")
                .HasColumnName("pt_bl_date");
            entity.Property(e => e.PtBlJudgement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_bl_judgement");
            entity.Property(e => e.PtBlParallism).HasColumnName("pt_bl_parallism");
            entity.Property(e => e.PtBlPerpendicularity).HasColumnName("pt_bl_perpendicularity");
            entity.Property(e => e.PtBlRank).HasColumnName("pt_bl_rank");
            entity.Property(e => e.PtBlRankC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_bl_rank_c");
        });

        modelBuilder.Entity<EtdPtFlatness>(entity =>
        {
            entity.HasKey(e => e.PtId);

            entity.ToTable("etd_pt_flatness");

            entity.Property(e => e.PtId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pt_id");
            entity.Property(e => e.PtFlDate)
                .HasColumnType("datetime")
                .HasColumnName("pt_fl_date");
            entity.Property(e => e.PtFlJudgement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_fl_judgement");
            entity.Property(e => e.PtFlMax).HasColumnName("pt_fl_max");
            entity.Property(e => e.PtFlMin).HasColumnName("pt_fl_min");
            entity.Property(e => e.PtFlRank).HasColumnName("pt_fl_rank");
        });

        modelBuilder.Entity<EtdPtHeight>(entity =>
        {
            entity.HasKey(e => e.PtId).HasName("PK__etd_pt_h__5630B12073852659");

            entity.ToTable("etd_pt_height");

            entity.HasIndex(e => new { e.PtHeJudgement, e.PtHeDate }, "pt_hei_judge_time");

            entity.Property(e => e.PtId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pt_id");
            entity.Property(e => e.PtHe1).HasColumnName("pt_he1");
            entity.Property(e => e.PtHe2).HasColumnName("pt_he2");
            entity.Property(e => e.PtHe3).HasColumnName("pt_he3");
            entity.Property(e => e.PtHe4).HasColumnName("pt_he4");
            entity.Property(e => e.PtHeDate)
                .HasColumnType("datetime")
                .HasColumnName("pt_he_date");
            entity.Property(e => e.PtHeJudgement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_he_judgement");
            entity.Property(e => e.PtHeMode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pt_he_mode");
            entity.Property(e => e.PtHeParallism).HasColumnName("pt_he_parallism");
            entity.Property(e => e.PtHeRank).HasColumnName("pt_he_rank");
            entity.Property(e => e.PtHeRankC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_he_rank_c");
        });

        modelBuilder.Entity<EtdPtId>(entity =>
        {
            entity.HasKey(e => e.PtId).HasName("PK__etd_pt_i__5630B1206BE40491");

            entity.ToTable("etd_pt_id");

            entity.HasIndex(e => new { e.PtIdJudgement, e.PtIdDate }, "pt_id_judge_time");

            entity.Property(e => e.PtId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pt_id");
            entity.Property(e => e.PtId1).HasColumnName("pt_id1");
            entity.Property(e => e.PtId2).HasColumnName("pt_id2");
            entity.Property(e => e.PtId3).HasColumnName("pt_id3");
            entity.Property(e => e.PtIdConcentricity).HasColumnName("pt_id_concentricity");
            entity.Property(e => e.PtIdCylindricity).HasColumnName("pt_id_cylindricity");
            entity.Property(e => e.PtIdDate)
                .HasColumnType("datetime")
                .HasColumnName("pt_id_date");
            entity.Property(e => e.PtIdJudgement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_id_judgement");
            entity.Property(e => e.PtIdPerpendicularity).HasColumnName("pt_id_perpendicularity");
            entity.Property(e => e.PtIdRank).HasColumnName("pt_id_rank");
            entity.Property(e => e.PtIdRankC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_id_rank_c");
            entity.Property(e => e.PtIdRoundness).HasColumnName("pt_id_roundness");
            entity.Property(e => e.PtIdRoundness1).HasColumnName("pt_id_roundness1");
            entity.Property(e => e.PtIdRoundness2).HasColumnName("pt_id_roundness2");
            entity.Property(e => e.PtIdRoundness3).HasColumnName("pt_id_roundness3");
        });

        modelBuilder.Entity<EtdPtOd>(entity =>
        {
            entity.HasKey(e => e.PtId).HasName("PK__etd_pt_o__5630B1206FB49575");

            entity.ToTable("etd_pt_od");

            entity.HasIndex(e => new { e.PtOdJudgement, e.PtOdDate }, "pt_od_judge_time");

            entity.Property(e => e.PtId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pt_id");
            entity.Property(e => e.PtOd1).HasColumnName("pt_od1");
            entity.Property(e => e.PtOd2).HasColumnName("pt_od2");
            entity.Property(e => e.PtOd3).HasColumnName("pt_od3");
            entity.Property(e => e.PtOdCylindricity).HasColumnName("pt_od_cylindricity");
            entity.Property(e => e.PtOdDate)
                .HasColumnType("datetime")
                .HasColumnName("pt_od_date");
            entity.Property(e => e.PtOdJudgeRoundness).HasColumnName("pt_od_judge_roundness");
            entity.Property(e => e.PtOdJudgement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_od_judgement");
            entity.Property(e => e.PtOdPerpendicularity).HasColumnName("pt_od_perpendicularity");
            entity.Property(e => e.PtOdRank).HasColumnName("pt_od_rank");
            entity.Property(e => e.PtOdRankC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pt_od_rank_c");
            entity.Property(e => e.PtOdRoundness1).HasColumnName("pt_od_roundness1");
            entity.Property(e => e.PtOdRoundness2).HasColumnName("pt_od_roundness2");
            entity.Property(e => e.PtOdRoundness3).HasColumnName("pt_od_roundness3");
        });

        modelBuilder.Entity<EtdRearHead>(entity =>
        {
            entity.HasKey(e => e.RhId);

            entity.ToTable("etd_rear_head", tb =>
                {
                    tb.HasTrigger("rear_head_count");
                    tb.HasTrigger("rear_head_total_shift");
                });

            entity.HasIndex(e => e.MId, "NonClusteredIndex-20190724-171005");

            entity.HasIndex(e => new { e.RhLine, e.RhId, e.FirstStamptime }, "idxnon_RH_judge");

            entity.HasIndex(e => new { e.RhLine, e.RhJudgement, e.RhId, e.FirstStamptime }, "inx_20190617_etd_rear_head");

            entity.HasIndex(e => new { e.RhJudgement, e.RhDate }, "rh_judge_time");

            entity.Property(e => e.RhId)
                .HasMaxLength(20)
                .HasColumnName("rh_id");
            entity.Property(e => e.FirstStamptime)
                .HasColumnType("datetime")
                .HasColumnName("first_stamptime");
            entity.Property(e => e.MId)
                .HasMaxLength(20)
                .HasColumnName("m_id");
            entity.Property(e => e.ProId)
                .HasMaxLength(20)
                .HasColumnName("pro_id");
            entity.Property(e => e.RhDate)
                .HasColumnType("datetime")
                .HasColumnName("rh_date");
            entity.Property(e => e.RhJudgement)
                .HasMaxLength(4)
                .HasColumnName("rh_judgement");
            entity.Property(e => e.RhLine)
                .HasMaxLength(100)
                .HasColumnName("rh_line");
            entity.Property(e => e.RhMode)
                .HasMaxLength(10)
                .HasColumnName("rh_mode");
            entity.Property(e => e.RhPosition).HasColumnName("rh_position");
        });

        modelBuilder.Entity<EtdRhDetail>(entity =>
        {
            entity.HasKey(e => e.RhId);

            entity.ToTable("etd_rh_detail");

            entity.HasIndex(e => new { e.RhJudgement, e.RhDate }, "rh_id_judge_time");

            entity.Property(e => e.RhId)
                .HasMaxLength(20)
                .HasColumnName("rh_id");
            entity.Property(e => e.RhCylindricity).HasColumnName("rh_cylindricity");
            entity.Property(e => e.RhDate)
                .HasColumnType("datetime")
                .HasColumnName("rh_date");
            entity.Property(e => e.RhId1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rh_id1");
            entity.Property(e => e.RhId2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rh_id2");
            entity.Property(e => e.RhId3).HasColumnName("rh_id3");
            entity.Property(e => e.RhJudgeRoundness).HasColumnName("rh_judge_roundness");
            entity.Property(e => e.RhJudgement)
                .HasMaxLength(4)
                .HasColumnName("rh_judgement");
            entity.Property(e => e.RhPerpendicularity).HasColumnName("rh_perpendicularity");
            entity.Property(e => e.RhRank).HasColumnName("rh_rank");
            entity.Property(e => e.RhRankC)
                .HasMaxLength(4)
                .HasColumnName("rh_rank_c");
            entity.Property(e => e.RhRoundness1).HasColumnName("rh_roundness1");
            entity.Property(e => e.RhRoundness2).HasColumnName("rh_roundness2");
            entity.Property(e => e.RhRoundness3).HasColumnName("rh_roundness3");
        });

        modelBuilder.Entity<EtdRhFlatness>(entity =>
        {
            entity.HasKey(e => e.RhId).HasName("PK_rh_flatness");

            entity.ToTable("etd_rh_flatness");

            entity.HasIndex(e => new { e.RhFlJudgement, e.RhFlDate }, "rh_fl_judge_time");

            entity.Property(e => e.RhId)
                .HasMaxLength(20)
                .HasColumnName("rh_id");
            entity.Property(e => e.RhFl1Judge).HasColumnName("rh_fl1_judge");
            entity.Property(e => e.RhFl1JudgeRank)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rh_fl1_judge_rank");
            entity.Property(e => e.RhFl1Max).HasColumnName("rh_fl1_max");
            entity.Property(e => e.RhFl1Min).HasColumnName("rh_fl1_min");
            entity.Property(e => e.RhFl1PointMax).HasColumnName("rh_fl1_point_max");
            entity.Property(e => e.RhFl1PointMin).HasColumnName("rh_fl1_point_min");
            entity.Property(e => e.RhFl2Judge).HasColumnName("rh_fl2_judge");
            entity.Property(e => e.RhFl2JudgeRank)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rh_fl2_judge_rank");
            entity.Property(e => e.RhFl2Max).HasColumnName("rh_fl2_max");
            entity.Property(e => e.RhFl2Min).HasColumnName("rh_fl2_min");
            entity.Property(e => e.RhFl2PointMax).HasColumnName("rh_fl2_point_max");
            entity.Property(e => e.RhFl2PointMin).HasColumnName("rh_fl2_point_min");
            entity.Property(e => e.RhFlDate)
                .HasColumnType("datetime")
                .HasColumnName("rh_fl_date");
            entity.Property(e => e.RhFlJudgement)
                .HasMaxLength(4)
                .HasColumnName("rh_fl_judgement");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
