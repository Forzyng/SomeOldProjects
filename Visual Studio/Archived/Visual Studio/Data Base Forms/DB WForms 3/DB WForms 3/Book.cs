//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_WForms_3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public System.Guid AuthorsId { get; set; }
        public System.Guid ThemesId { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Theme Theme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
