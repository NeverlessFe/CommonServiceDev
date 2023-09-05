using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class TblTDelegate
{
    public long RecordId { get; set; }

    public string? Nik { get; set; }

    public string? NikDelegate { get; set; }

    public string? Type { get; set; }

    public string? RoleStatic { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? EndDateDelegeate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
