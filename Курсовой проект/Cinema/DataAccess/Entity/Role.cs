namespace Cinema.DataAccess.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
