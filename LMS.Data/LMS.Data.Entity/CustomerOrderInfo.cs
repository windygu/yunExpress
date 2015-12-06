//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class CustomerOrderInfo : Entity
    {
    
        ICollection<ApplicationInfo> _applicationInfos;
        ICollection<CustomerOrderStatus> _customerOrderStatuses;
        ICollection<WayBillInfo> _wayBillInfos;
    
    
        public virtual int CustomerOrderID { get; set; }
        public virtual string CustomerOrderNumber { get; set; }
        public virtual string CustomerCode { get; set; }
        public virtual string TrackingNumber { get; set; }
        public virtual Nullable<int> ShippingMethodId { get; set; }
        public virtual string ShippingMethodName { get; set; }
        public virtual Nullable<int> ShippingInfoID { get; set; }
        public virtual Nullable<int> SenderInfoID { get; set; }
        public virtual Nullable<int> GoodsTypeID { get; set; }
        public virtual bool IsReturn { get; set; }
        public virtual bool IsInsured { get; set; }
        public virtual bool IsBattery { get; set; }
        public virtual bool IsHold { get; set; }
        public virtual Nullable<int> InsuredID { get; set; }
        public virtual bool IsPrinted { get; set; }
        public virtual int Status { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual Nullable<int> SensitiveTypeID { get; set; }
        public virtual Nullable<int> PackageNumber { get; set; }
        public virtual Nullable<decimal> InsureAmount { get; set; }
        public virtual int AppLicationType { get; set; }
        public virtual decimal Weight { get; set; }
        public virtual decimal Length { get; set; }
        public virtual decimal Width { get; set; }
        public virtual decimal Height { get; set; }
        public virtual bool EnableTariffPrepay { get; set; }
        public virtual string Remark { get; set; }
    
        public virtual ICollection<ApplicationInfo> ApplicationInfos 
    	{
            get { return _applicationInfos  ?? (_applicationInfos  = new List<ApplicationInfo>()); }
            protected set { _applicationInfos  = value; }
        }
    
        public virtual ICollection<CustomerOrderStatus> CustomerOrderStatuses 
    	{
            get { return _customerOrderStatuses  ?? (_customerOrderStatuses  = new List<CustomerOrderStatus>()); }
            protected set { _customerOrderStatuses  = value; }
        }
    
        public virtual GoodsTypeInfo GoodsTypeInfo { get; set; }
        public virtual InsuredCalculation InsuredCalculation { get; set; }
        public virtual SensitiveTypeInfo SensitiveTypeInfo { get; set; }
        public virtual ShippingInfo ShippingInfo { get; set; }
        public virtual SenderInfo SenderInfo { get; set; }
        public virtual ICollection<WayBillInfo> WayBillInfos 
    	{
            get { return _wayBillInfos  ?? (_wayBillInfos  = new List<WayBillInfo>()); }
            protected set { _wayBillInfos  = value; }
        }
    
    }
}