using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models;

public class FullMachineModel:MachineModel
{
    //public int Id { get; set; }
    public MalfunctionModel Malfunction { get; set; }

    public int DateDiff { get; set; }
}
