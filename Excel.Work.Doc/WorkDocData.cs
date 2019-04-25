using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel.Work.Doc
{
    public struct PatientName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }

    public enum WorkDocType
    {
        Primary = 0,
        Doublicate,
        Continuation
    }

    public enum TypeOfEmployment
    {
        Basic = 0,
        Other,
        EmploymentCenter
    }

    /// <summary>
    /// Данные пациента
    /// </summary>
    [Serializable]
    public class WorkDocData
    {
        public PatientName PatientName { get; set; }
        public DateTime PatientBirthDate { get; set; }
        public WorkDocType WorkDocType { get; set; }
        public Byte[] PreviewWorkDocNumber { get; set; }
        public string OrganizationName { get; set; }
        public string MedicalOrganizationName { get; set; }
        public TypeOfEmployment TypeOfEmployment { get; set; }
    }
}
