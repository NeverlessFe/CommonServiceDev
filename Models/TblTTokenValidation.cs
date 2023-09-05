using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class TblTTokenValidation
{
    public long RecordId { get; set; }

    public string? UserAd { get; set; }

    public int? Idapps { get; set; }

    public string? Token { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ValidUntil { get; set; }
}
