//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Layer
    {
        public long ID { get; set; }
        public string NAME { get; set; }
        public Nullable<double> Layer_rResistance { get; set; }
        public Nullable<long> Layer_wTime { get; set; }
        public Nullable<long> Layer_MS_wPos { get; set; }
        public Nullable<long> Layer_MS_wIPSM1_wMode { get; set; }
        public Nullable<double> Layer_MS_rIPSM1_Prm { get; set; }
        public Nullable<double> Layer_rSpeedUpSmoothSet1 { get; set; }
        public Nullable<double> Layer_rSpeedDownSmoothSet1 { get; set; }
        public Nullable<double> Layer_IPSM1_rSetPrmMin { get; set; }
        public Nullable<long> Layer_IPSM1_wTimeFirstPwr { get; set; }
        public Nullable<long> Layer_MS_wPreSput_Tm { get; set; }
        public Nullable<double> Layer_rWorkPressure { get; set; }
        public Nullable<long> Layer_xUseGV1 { get; set; }
        public Nullable<long> Layer_xUseGV2 { get; set; }
        public Nullable<long> Layer_xUseGV3 { get; set; }
        public Nullable<long> Layer_GMFC1_wSetControl_ { get; set; }
        public Nullable<double> Layer_GMFC1_rSetGasNominal { get; set; }
        public Nullable<long> Layer_GMFC2_wSetControl_ { get; set; }
        public Nullable<long> Layer_GMFC3_wSetControl_ { get; set; }
        public Nullable<double> Layer_GMFC2_rSetGasNominal { get; set; }
        public Nullable<double> Layer_GMFC3_rSetGasNominal { get; set; }
        public Nullable<double> Layer_GMFC1_rSetAmperage { get; set; }
        public Nullable<double> Layer_GMFC2_rSetAmperage { get; set; }
        public Nullable<double> Layer_GMFC3_rSetAmperage { get; set; }
        public Nullable<double> Layer_GMFC1_rSetPressure { get; set; }
        public Nullable<double> Layer_GMFC2_rSetPressure { get; set; }
        public Nullable<double> Layer_GMFC3_rSetPressure { get; set; }
        public Nullable<double> Layer_GMFC1_rSetRatio_ { get; set; }
        public Nullable<double> Layer_GMFC2_rSetRatio_ { get; set; }
        public Nullable<double> Layer_GMFC3_rSetRatio_ { get; set; }
        public Nullable<double> Layer_GMFC1_rSetIntergral { get; set; }
        public Nullable<double> Layer_GMFC2_rSetIntergral { get; set; }
        public Nullable<double> Layer_GMFC3_rSetIntergral { get; set; }
        public Nullable<double> Layer_GMFC1_rSetProportional { get; set; }
        public Nullable<double> Layer_GMFC2_rSetProportional { get; set; }
        public Nullable<double> Layer_GMFC3_rSetProportional { get; set; }
        public Nullable<double> Layer_rThikness { get; set; }
        public Nullable<long> Layer_wMaterial_ID { get; set; }
        public Nullable<double> Layer_rZfactor { get; set; }
        public Nullable<long> Layer_TP_wSpeed { get; set; }
        public Nullable<long> Layer_wCtune { get; set; }
        public Nullable<long> Layer_wCload { get; set; }
        public Nullable<long> Layer_xCoatingIsSelect { get; set; }
    }
}