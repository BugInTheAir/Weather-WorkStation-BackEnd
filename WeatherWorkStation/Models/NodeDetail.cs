//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherWorkStation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NodeDetail
    {
        public string NodeId { get; set; }
        public Nullable<double> Temperature { get; set; }
        public Nullable<double> SoilMoisture { get; set; }
        public Nullable<double> Humidity { get; set; }
        public Nullable<int> Raining { get; set; }
        public int Id { get; set; }
        public long updateTime { get; set; }
    
        public virtual Node Node { get; set; }
    }
}
