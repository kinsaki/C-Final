//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class PER_DETAILS_TBL
    {
        public string PATIENT_ID { get; set; }
        public string BLOOD_TYPE { get; set; }
        public Nullable<bool> ORGAN_DONOR { get; set; }
        public Nullable<bool> HIV_STATUS { get; set; }
        public Nullable<short> HEIGHT_INCHES { get; set; }
        public Nullable<short> WEIGHT_LBS { get; set; }
    
        public virtual PATIENT_TBL PATIENT_TBL { get; set; }
    }
}