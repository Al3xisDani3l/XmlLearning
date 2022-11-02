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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://aligntech.com/Prescription/1.0")]

    public partial class PrescriptionFormData : SerializableXML<PrescriptionFormData>
    {
        [XmlArrayAttribute(IsNullable = true)]
        [XmlArrayItemAttribute("PriorPrescriptions")]
        public List<PrescriptionFormData> PriorPrescriptions { get; set; }

        [XmlElement("Header")]
        public Header Header { get; set; }
        [XmlArrayItemAttribute("Study", IsNullable = false)]
        public List<StudyType> ClinicalStudies { get; set; }
        [XmlElement("PrescriptionQuestions")]
        public PrescriptionFormTypePrescriptionQuestions PrescriptionQuestions { get; set; }
        [XmlElement("Preferences")]
        public Preference Preferences { get; set; }
        [XmlAttribute(AttributeName = "schemaVersion")]
        [DefaultValue("20.0")]
        public string SchemaVersion { get; set; }


        public PrescriptionFormData()
        {
            PriorPrescriptions = new List<PrescriptionFormData>();
            ClinicalStudies = new List<StudyType>();
            SchemaVersion = "20.0";
        }
    }
}
