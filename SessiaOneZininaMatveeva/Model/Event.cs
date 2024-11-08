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
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.Activities = new HashSet<Activity>();
            this.EventParticipants = new HashSet<EventParticipant>();
            this.Moderators = new HashSet<Moderator>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int Days { get; set; }
        public int CityId { get; set; }
        public Nullable<int> OrganizerId { get; set; }
        public int DirectionId { get; set; }
        public string Logo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual City City { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual Organizer Organizer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventParticipant> EventParticipants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moderator> Moderators { get; set; }
    }
}
