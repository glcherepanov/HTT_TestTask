namespace EntityFramework.Entity
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public virtual Category Category { get; set; }
    }
}
