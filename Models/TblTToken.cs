using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class TblTToken
{
    public long RecordId { get; set; }

    public string TokenPk { get; set; } = null!;

    public string Nik { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreationDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public string UpdateBy { get; set; } = null!;
}
