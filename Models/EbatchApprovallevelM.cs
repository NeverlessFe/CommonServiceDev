using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchApprovallevelM
{
    public long RecordId { get; set; }

    public string IdlevelPk { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }
}
