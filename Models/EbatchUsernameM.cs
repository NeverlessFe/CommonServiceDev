using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchUsernameM
{
    public long RecordId { get; set; }

    public string UsernamePk { get; set; } = null!;

    public string? Nik { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }
}
