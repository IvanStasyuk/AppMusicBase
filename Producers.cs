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
    
    public partial class Producers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producers()
        {
            this.Singers = new HashSet<Singers>();
        }
    
        public string idProducer { get; set; }
        public string NameProducer { get; set; }
        public string FamiliaProducer { get; set; }
        public string PatronymicProducer { get; set; }
        public Nullable<System.DateTime> YearBirthday { get; set; }
        public string NameStudio { get; set; }
    
        public virtual MusicStudios MusicStudios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Singers> Singers { get; set; }
    }
}
