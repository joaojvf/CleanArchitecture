using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.CrossCutting.Configuration.Interfaces
{
    public interface IApplicationSettings
    {
        LogginSettings LogginSettings { get; set; }
    }
}
