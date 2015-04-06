using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspinia_MVC5_SeedProject.Service
{
    interface IBettingService
    {
        ArrayList GetBets(String market);
    }
}
