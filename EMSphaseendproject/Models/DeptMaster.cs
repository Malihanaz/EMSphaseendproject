using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMSphaseendproject.Models
{
    [Table("DeptMaster")]
    public class DeptMaster
    {
        [Key]
    public int DeptCode { get; set; }
    public string DeptName { get; set; }
        [StringLength(100)]
    public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
    }
}

