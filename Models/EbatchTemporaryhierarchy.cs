using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchTemporaryhierarchy
{
    public long RecordId { get; set; }

    public int? Id { get; set; }

    public string? Nik { get; set; }

    public string? Nama { get; set; }

    public string? Superiornik { get; set; }
}
