// See https://aka.ms/new-console-template for more information
using Serialixer;
using Serializacion_level_one.TreatFiles;

Header header = new();
header.ClinicalID = "c00223786";
header.DID = "969149";
header.VIPPatientID = "7765264";
header.VIPOrderID = "17516352";
header.JDEOrderID = "27128654";
header.TreatmentType = "CLEAR_ALIGNER_GO";
header.MaxAllowedStages = "0";
header.PatientType = CommonHeaderTypePatientType.Adult;
header.DoctorRegion = "EUROPE_DIRECT";
header.DoctorCountry = "SE";
header.OrderType = "CLEAR_ALIGNER_GO";
header.TransactionID = "59339112";
header.Timestamp = DateTime.Parse("2018-10-24T03:14:38.518-07:00");
header.DoctorsMarket = "International";
header.DocumentType = CommonHeaderTypeDocumentType.SI;
header.ApplianceMaterialType = CommonHeaderTypeApplianceMaterialType.ST30;
header.ItemNumber = "8874";
header.RxSubmissionMode = CommonHeaderTypeRxSubmissionMode.Online;
header.Alta = true;

string pathHeaderXml = @"E:\repos\FAST\src\FunctionalitiesTests\xml samples\7996965CD.xml";

string pathPreferences = @"C:\Users\alexi\OneDrive\Documentos\GitHub\XmlLearning\Serialixer\Serializacion level one\Preferences.xml";

string pathAlignerTrimming = @"C:\Users\alexi\OneDrive\Documentos\GitHub\XmlLearning\Serialixer\Serializacion level one\AlignerTrimming.xml";

string pathAttachments = @"C:\Users\alexi\OneDrive\Documentos\GitHub\XmlLearning\Serialixer\Serializacion level one\Attachments.xml";

//string resultadoSerializacion = header.Serialize();

//Console.WriteLine(resultadoSerializacion);


Attachments test = new();

test.Qid = "String";
test.Source = AttributeSourceType.preference;
test.IsApplicable = true;
var t1 = new AttachmentsTypeTooth() { Id = 4 };
t1.Attachment.Add(new AttachmentType() { Id = "1",Type = AttachType.OptimizedRotation, Location = AttachmentLocationType.CenterCenter, Surface = ToothSurfaceType.Buccal, Size = new AttachmentTypeSize() { Units = AttachmentTypeSizeUnits.mm, Value = "autosize" }, Status = AttachmentBoostStatusType.NotChanged });
var t2 = new AttachmentsTypeTooth() { Id = 5 };
t2.Attachment.Add(new AttachmentType() { Id = "2", Type = AttachType.OptimizedRotation, Location = AttachmentLocationType.CenterCenter, Surface = ToothSurfaceType.Buccal, Size = new AttachmentTypeSize() { Units = AttachmentTypeSizeUnits.mm, Value = "autosize" }, Status = AttachmentBoostStatusType.NotChanged });
test.Tooth.Add(t1);
test.Tooth.Add(t2);




//string dualString =   test.Serialize();

//var dualArch1 = Attachments.Deserialize(dualString);

var resultado = Attachments.LoadFromFile(pathAttachments);
var preferences = Preference.LoadFromFile(pathPreferences);

if (resultado != null) Console.WriteLine("Se ha deserializado");








public class Person:SerializableXML<Person>
{
    public Person()
    {

        Id = 12;
        Name = "Alexis Daniel Hernandez Gamez";
        Age = 23;
        Status = Status.Level_three;

    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Status Status { get; set; }
 
}


public enum Status
{
    Level_One,
    Level_Two,
    Level_three
}
   
