using SistemaFarmacia.Domain.Enums;

namespace SistemaFarmacia.Domain.Product;

public class Product : Base.Base
{
    public String? Name { get; private set; }
    public String? Description { get; private set; }
    public Decimal Price { get; private set; }
    public Supplier.Supplier? Supplier { get; private set; }
    public DateTime ExpirationDate { get; private set; }
    public Category Category { get; private set;  }

}
