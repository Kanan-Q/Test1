namespace WepAppTest.ViewModels.Doctors
{
    public class DoctorUpdateVM
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public IFormFile Photo { get; set; }
    }
}
