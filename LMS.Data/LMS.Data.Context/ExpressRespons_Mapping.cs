//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class ExpressRespons_Mapping : EntityTypeConfiguration<ExpressRespons>
    {
        public ExpressRespons_Mapping()
        {                        
              this.HasKey(t => t.WayBillNumber);        
              this.ToTable("ExpressResponses");
              this.Property(t => t.WayBillNumber).HasColumnName("WayBillNumber").IsRequired().HasMaxLength(20);
              this.Property(t => t.ServiceAreaCode).HasColumnName("ServiceAreaCode").HasMaxLength(50);
              this.Property(t => t.FacilityCode).HasColumnName("FacilityCode").HasMaxLength(50);
              this.Property(t => t.ShipmentDetailTime).HasColumnName("ShipmentDetailTime");
              this.Property(t => t.AirwayBillNumber).HasColumnName("AirwayBillNumber").HasMaxLength(50);
              this.Property(t => t.AirwayBillNumberBarCodeImg).HasColumnName("AirwayBillNumberBarCodeImg").HasMaxLength(100);
              this.Property(t => t.DHLRoutingDataId).HasColumnName("DHLRoutingDataId").HasMaxLength(50);
              this.Property(t => t.DHLRoutingBarCode).HasColumnName("DHLRoutingBarCode").HasMaxLength(50);
              this.Property(t => t.DHLRoutingBarCodeImg).HasColumnName("DHLRoutingBarCodeImg").HasMaxLength(100);
              this.Property(t => t.DataIdentifier).HasColumnName("DataIdentifier").HasMaxLength(50);
              this.Property(t => t.LicensePlate).HasColumnName("LicensePlate").HasMaxLength(50);
              this.Property(t => t.LicensePlateBarCodeImg).HasColumnName("LicensePlateBarCodeImg").HasMaxLength(100);
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.HasRequired(t => t.WayBillInfo).WithOptional(t => t.ExpressRespons);
         }
    }
}
