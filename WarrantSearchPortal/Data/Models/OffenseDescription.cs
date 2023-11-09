using System;
using System.Collections.Generic;

namespace WarrantSearchPortal.Data.Models;

public partial class OffenseDescription
{
    public int OffenseDescriptionId { get; set; }

    public string OffenseName { get; set; }

    public string OffenseDefinition { get; set; }

    public string CurrentFlag { get; set; }
}
