//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SessiaOneZininaMatveeva.Model
{
    using SessiaOneZininaMatveeva.View.Organizer;
    using System;
    using System.Collections.Generic;
    
    public partial class Organizer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organizer()
        {
            this.Events = new HashSet<Event>();
        }
    
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string CountryId { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public int GenderId { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }
        public virtual Gender Gender { get; set; }

        public static implicit operator Organizer(View.Organizer.Organizer v)
        {
            throw new NotImplementedException();
        }
    }
}
