//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.Entity
{
    using System;
    using System.Collections.Generic;
    
    [Serializable] 
     public partial class Settings
    {
        public long Id { get; set; }
        public long AlwaysOnTop { get; set; }
        public long StickyForm { get; set; }
        public long EnableReminderCountPopup { get; set; }
        public long EnableHourBeforeReminder { get; set; }
        public Nullable<long> HideReminderConfirmation { get; set; }
    }
}
