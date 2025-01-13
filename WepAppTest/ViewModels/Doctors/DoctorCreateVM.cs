namespace WepAppTest.ViewModels.Doctors
{
    public class DoctorCreateVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public IFormFile Photo { get; set; }
    }
}
