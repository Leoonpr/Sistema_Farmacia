using System;

namespace SistemaFarmacia.Domain.Customer;

public class Customer : Base.Base
{
    public string? Name { get; private set; }
    public string? Cpf { get; private set; }
    public string? Phone { get; private set; }
    public string? Email { get; private set; }

}
