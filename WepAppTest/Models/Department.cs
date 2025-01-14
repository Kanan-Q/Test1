namespace WepAppTest.Models
{
    public class Department:BaseEntity
    {
        public string? DepartmentName {  get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
