using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchHierarchytemporary
{
    public long Id { get; set; }

    public string? Nik { get; set; }

    public string? Nama { get; set; }

    public string? Superiornik { get; set; }
}
