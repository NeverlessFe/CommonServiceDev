using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchSectionM
{
    public long RecordId { get; set; }

    public string IdsectionPk { get; set; } = null!;

    public string SectionName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreationDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public string UpdateBy { get; set; } = null!;
}
