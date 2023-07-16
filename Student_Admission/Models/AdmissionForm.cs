using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Admission.Models
{
    public class AdmissionForm
    {
        // server side validation by using data annotation
        [Key]
        
        public int SNo { get; set; }
        [Required]
        [DisplayName("Student Name")]
        [MaxLength(30, ErrorMessage ="Name cannot be larger than 30 characters")]
        public string SName { get; set; }
        [Required]
        [DisplayName("Father Name")]
        [MaxLength(30, ErrorMessage = "Name cannot be larger than 30 characters")]
        public string FName { get; set; }
        [Required]
        
        public string Class { get; set; }
        [Required]
       
        public string Section { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime admissionDate { get; set; }
    }
}
