using System;

namespace SistemaFarmacia.Domain.Base;

public class Base
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

}
