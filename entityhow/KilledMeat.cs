//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityhow
{
    using System;
    using System.Collections.Generic;
    
    public partial class KilledMeat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KilledMeat()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ID_KilledMeat { get; set; }
        public string CName { get; set; }
        public string CSureName { get; set; }
        public string CMiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}