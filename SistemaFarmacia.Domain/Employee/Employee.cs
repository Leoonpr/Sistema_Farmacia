using System;
using SistemaFarmacia.Domain.Enums;

namespace SistemaFarmacia.Domain.Employee;

public class Employee : Base.Base
{
    public String? Name { get; private set; }
    public String? TaxId { get; private set; }
    public Role Role { get; set; }
    
    

}
