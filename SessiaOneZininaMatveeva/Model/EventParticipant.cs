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
    
    public partial class EventParticipant
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ParticipantId { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Participant Participant { get; set; }
    }
}