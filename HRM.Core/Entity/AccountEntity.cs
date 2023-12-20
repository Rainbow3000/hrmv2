

using System.ComponentModel.DataAnnotations;

namespace Core.Entity
{
   
    public class AccountEntity:BaseEntity
    {
        [Key]
        public Guid AccountId { get; set; }
        public Guid EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Status { get; set; }
        public EmployeeEntity Employee { get; set; }
    }
}
