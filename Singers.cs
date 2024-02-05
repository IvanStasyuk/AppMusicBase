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
    
    public partial class Singers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Singers()
        {
            this.Alboms = new HashSet<Alboms>();
        }
    
        public string idSinger { get; set; }
        public string NameSinger { get; set; }
        public string FamiliaSinger { get; set; }
        public string PatronymicSinger { get; set; }
        public string MusicIntrument { get; set; }
        public Nullable<System.DateTime> YearBirthday { get; set; }
        public string idProducer { get; set; }
        public string NameTirage { get; set; }
        public Nullable<int> idOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alboms> Alboms { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual Producers Producers { get; set; }
        public virtual Tirage Tirage { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
