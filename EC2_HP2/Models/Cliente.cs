using System;
using System.Collections.Generic;

namespace EC2_HP2.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Documento { get; set; } = null!;
}
