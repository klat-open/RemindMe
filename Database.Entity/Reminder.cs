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
     public partial class Reminder
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string RepeatType { get; set; }
        public string Note { get; set; }
        public long Enabled { get; set; }
        public Nullable<long> EveryXCustom { get; set; }
        public string RepeatDays { get; set; }
        public string SoundFilePath { get; set; }
        public string PostponeDate { get; set; }
        public long Deleted { get; set; }
        public Nullable<long> DayOfMonth { get; set; }
        public Nullable<long> Hide { get; set; }
    }
}
