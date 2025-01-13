namespace WepAppTest.Models
{
    public class Doctor:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Photo { get; set; }
        public int DepatmentId {  get; set; }
        public Department Department { get; set; }
    }
}
