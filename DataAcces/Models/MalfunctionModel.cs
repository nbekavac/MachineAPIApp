using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models;

public class MalfunctionModel
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Priority { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string Description { get; set; }

    public string Status { get; set; }

    public int MachineId { get; set; }

}
