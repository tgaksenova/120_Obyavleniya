//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Privateads
{
    using System;
    using System.Collections.Generic;
    
    public partial class Продавцы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продавцы()
        {
            this.ADSPR = new HashSet<ADSPR>();
        }
    
        public int id_продавца { get; set; }
        public string регион { get; set; }
        public string ФИО { get; set; }
        public string телефон { get; set; }
        public string e_mail { get; set; }
        public string адрес_осмотра { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADSPR> ADSPR { get; set; }
    }
}
