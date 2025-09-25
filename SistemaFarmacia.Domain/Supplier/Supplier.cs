using System;

namespace SistemaFarmacia.Domain.Supplier;

public class Supplier : Base.Base
{
    public String? Name { get; private set; }
    public String? Email { get; private set; }
    public String? Phone { get; private set; }

}
