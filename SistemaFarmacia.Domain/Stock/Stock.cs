using System;

namespace SistemaFarmacia.Domain.Stock;

public class Stock : Base.Base
{
    public Product.Product Product { get; private set; }
    public int Quantity { get; private set; }
    public String? Location { get; private set; }

}
