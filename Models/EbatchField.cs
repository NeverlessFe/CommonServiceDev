using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchField
{
    public long RecordId { get; set; }

    public string? ModulIdFk { get; set; }

    public string? AppsIdFk { get; set; }

    public string? FieldName { get; set; }

    public string? ValueField { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }
}
