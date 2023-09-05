using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchApprvheadM
{
    public long RecordId { get; set; }

    public string Idapps { get; set; } = null!;

    public DateTime? Applydate { get; set; }

    public string? Description { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public string? Applicationname { get; set; }
}
