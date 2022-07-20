using ApplicationServicesSO.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationServicesSO.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<VMModel> SalesOrder { get; set; }


        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VWSalesModel>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("VW_CHANGE_SEEDS");

                entity.Property(e => e.Datakey)
                    .HasColumnName("DATAKEY");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER");

                entity.Property(e => e.SalesItem)
                    .HasColumnName("SALES_ITEM");

                entity.Property(e => e.MaterialNumber)
                    .HasColumnName("MATERIAL_CODE");

                entity.Property(e => e.MaterialShortText)
                    .HasColumnName("MATERIAL_DESCRIPTION");

                entity.Property(e => e.Plant)
                    .HasColumnName("PLANT");

                entity.Property(e => e.PlanGoodsIssueDate)
                    .HasColumnName("PLAN_GOODS_ISSUE_DATE");

                entity.Property(e => e.SalesQtyInUom)
                    .HasColumnName("SALES_QTY_IN_UOM");

                entity.Property(e => e.BaseUom)
                    .HasColumnName("BASE_UOM");

                entity.Property(e => e.SalesRepOwnerName)
                    .HasColumnName("SALES_REP_OWNER_NAME");

                entity.Property(e => e.SalesDistrictOwner)
                    .HasColumnName("SALES_DISTRICT_OWNER");

                entity.Property(e => e.TotalNetValueItemLc)
                    .HasColumnName("TOTAL_NET_VALUE_ITEM_LC");

                entity.Property(e => e.TaxAmoutItemLc)
                    .HasColumnName("TAX_AMOUNT_ITEM_LC");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("ORDER_STATUS");

                entity.Property(e => e.SoldtoCode)
                    .HasColumnName("SOLDTO_CODE");

                entity.Property(e => e.SoldtoName)
                    .HasColumnName("SOLDTO_NAME");

                entity.Property(e => e.SoldtoState)
                    .HasColumnName("SOLDTO_STATE");

                entity.Property(e => e.TermsOfPayment)
                    .HasColumnName("TERMS_OF_PAYMENT");

                entity.Property(e => e.PaymentDesc)
                    .HasColumnName("PAYMENT_DESC");

                entity.Property(e => e.EmailGerente)
                    .HasColumnName("EMAIL_GERENTE");

                entity.Property(e => e.EmailFranq)
                    .HasColumnName("EMAIL_FRANQ");

            });

        }
        #endregion

    }
}

