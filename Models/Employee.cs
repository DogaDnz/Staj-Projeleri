using System.ComponentModel.DataAnnotations.Schema;


namespace MersinLiman.Models
{
    [Table("Employee_Table")]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public int Wage { get; set; }
    }
}
