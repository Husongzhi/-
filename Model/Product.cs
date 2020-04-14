//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.BadReport = new HashSet<BadReport>();
            this.CheckStock = new HashSet<CheckStock>();
            this.InStorage = new HashSet<InStorage>();
            this.MoveReport = new HashSet<MoveReport>();
            this.ReturnOrderStock = new HashSet<ReturnOrderStock>();
        }
    
        public int Id { get; set; }
        public string ProductNum { get; set; }
        public string ProductName { get; set; }
        public int MinNum { get; set; }
        public Nullable<int> MaxNum { get; set; }
        public Nullable<int> InPrice { get; set; }
        public Nullable<int> OutPrice { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int PCateId { get; set; }
        public int MeasureId { get; set; }
        public int LocationId { get; set; }
        public Nullable<int> CreateUser { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int IsDelete { get; set; }
        public string Remark { get; set; }
    
        public virtual Admin Admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadReport> BadReport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckStock> CheckStock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InStorage> InStorage { get; set; }
        public virtual Location Location { get; set; }
        public virtual Measure Measure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoveReport> MoveReport { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnOrderStock> ReturnOrderStock { get; set; }
    }
}
