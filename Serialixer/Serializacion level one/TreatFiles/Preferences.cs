using Serialixer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion_level_one.TreatFiles
{
   
        [XmlInclude(typeof(CommonFormQuestionsType))]
        [XmlInclude(typeof(RententionFormQuestionsType))]
        [XmlInclude(typeof(PrimaryFormQuestionsType))]
        [XmlInclude(typeof(SecondaryFormQuestionsType))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
        [Serializable]
        [DebuggerStepThrough]
        [DesignerCategoryAttribute("code")]
        //[XmlTypeAttribute(Namespace = "http://aligntech.com/Prescription/1.0")]
        [XmlRootAttribute("Preferences", IsNullable = false)]
        public partial class Preference : SerializableXML<Preference>
        {
            [XmlElement(IsNullable = true, Order = 0)]
            public ToothNumberingSystem ToothNumberingSystem { get; set; }
            [XmlElement(IsNullable = true, Order = 1)]
            public DualArchPreference DualArchPreference { get; set; }
            [XmlElement(IsNullable = true, Order = 2)]
            public Leveling Leveling { get; set; }
            [XmlElement(IsNullable = true, Order = 3)]
            public Attachments Attachments { get; set; }
            [XmlElement(IsNullable = true, Order = 4)]
            public PreferenceTypeIPROnFirstClinCheck IPROnFirstClinCheck { get; set; }
            [XmlElement(IsNullable = true, Order = 5)]
            public PreferenceTypeIPROnPermanentTeeth IPROnPermanentTeeth { get; set; }
            [XmlElement(IsNullable = true, Order = 6)]
            public PreferenceTypeIPROnPrimaryTeeth IPROnPrimaryTeeth { get; set; }
            [XmlElement(IsNullable = true, Order = 7)]
            public PreferenceTypeIPRStaging IPRStaging { get; set; }
            [XmlElement(Order = 8)]
            public PreferenceTypeToothStagingForArchExpansion ToothStagingForArchExpansion { get; set; }
            [XmlElement(IsNullable = true, Order = 9)]
            public PreferenceTypeDelayStageToStartIPR DelayStageToStartIPR { get; set; }
            [XmlElement(IsNullable = true, Order = 10)]
            public PreferenceTypeDelayAttachmentPlacement DelayAttachmentPlacement { get; set; }
            [XmlElement(IsNullable = true, Order = 11)]
            public PreferenceTypeDelayStageOfExtraction DelayStageOfExtraction { get; set; }
            [XmlElement(IsNullable = true, Order = 12)]
            public PreferenceTypePonticsForOpenSpaces PonticsForOpenSpaces { get; set; }
            [XmlElement(IsNullable = true, Order = 13)]
            public PreferenceTypePrecisionCutPreference PrecisionCutPreference { get; set; }
            [XmlElement(Order = 14)]
            public PreferenceTypeArchExpansion ArchExpansion { get; set; }
            [XmlElement(IsNullable = true, Order = 15)]
            public PreferenceTypeToothSizeDiscrepancy ToothSizeDiscrepancy { get; set; }
            [XmlElement(IsNullable = true, Order = 16)]
            public PreferenceTypePassiveAligners PassiveAligners { get; set; }
            [XmlElement(IsNullable = true, Order = 17)]
            public PreferenceTypePassiveAlignersPreference PassiveAlignersPreference { get; set; }
            [XmlElement(IsNullable = true, Order = 18)]
            public PreferenceTypeStageToRemoveAttachmentAtEnd StageToRemoveAttachmentAtEnd { get; set; }
            [XmlElement(IsNullable = true, Order = 19)]
            public AlignerTrimming AlignerTrimming { get; set; }
            [XmlElement(IsNullable = true, Order = 20)]
            public PreferenceTypeApplyVirtualCChainMethod ApplyVirtualCChainMethod { get; set; }
            [XmlElement(IsNullable = true, Order = 21)]
            public OptimizedAttachmentVsPrecisionCutType OptimizedAttachmentVsPrecisionCut { get; set; }
            [XmlElement(IsNullable = true, Order = 22)]
            public PreferenceTypeOptimizedAttachmentSizePreference OptimizedAttachmentSizePreference { get; set; }
            [XmlElement(IsNullable = true, Order = 23)]
            public PreferenceTypeTerminalMolarDistortion TerminalMolarDistortion { get; set; }
        }






    
}
