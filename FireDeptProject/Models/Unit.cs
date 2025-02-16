namespace FireDeptProject.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Vehicles> Vehicles { get; set; }
    }
}
