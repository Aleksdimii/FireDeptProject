namespace FireDeptProject.Models
{
    public class Vehicles
    {
        public int Id { get; set; }

        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }

        public DateTime CaseStarted { get; set; }
        public DateTime CaseResolved { get; set; }

        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

    }
}
