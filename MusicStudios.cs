//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMusicBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusicStudios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusicStudios()
        {
            this.Producers = new HashSet<Producers>();
        }
    
        public string NameStudio { get; set; }
        public string NameAdministrator { get; set; }
        public string City { get; set; }
        public string NameAccountant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producers> Producers { get; set; }
    }
}