using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Infrastructure.CrossCutting.Configuration.Interfaces;

namespace CleanArchitecture.Infrastructure.CrossCutting.Configuration
{
    public class ApplicationSettings : IApplicationSettings
    {
        public LogginSettings LogginSettings { get ; set; }
    }
}
