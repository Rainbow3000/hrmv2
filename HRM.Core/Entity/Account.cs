

namespace Core.Entity
{
   
    public class Account:BaseEntity
    {
        public Guid AccountId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Status { get; set; }
        public EmployeeEntity Employee { get; set; }
    }
}
