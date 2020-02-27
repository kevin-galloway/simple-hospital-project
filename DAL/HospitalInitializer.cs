using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Hospitals.Models;

namespace Hospitals.DAL
{
    public class HospitalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HospitalContext>
    {
        protected override void Seed(HospitalContext context)
        {
            var hospitals = new List<Hospital>
            {
                new Hospital{Name="Mercy Hospital",City="Oklahoma City",State=StateAbbreviation.OK},
                new Hospital{Name="St. Anthony",City="Oklahoma City",State=StateAbbreviation.OK},
                new Hospital{Name="INTEGRIS Southwest",City="Oklahoma City",State=StateAbbreviation.OK},
                new Hospital{Name="The Children's Hospital",City="Oklahoma City",State=StateAbbreviation.OK},
                new Hospital{Name="Curahealth",City="Oklahoma City",State=StateAbbreviation.OK},
                new Hospital{Name="Promise Hospital of Dallas",City="Dallas",State=StateAbbreviation.TX},
                new Hospital{Name="Baylor University Medical Center",City="Dallas",State=StateAbbreviation.TX},
                new Hospital{Name="Select Specialty Hospital",City="Curahealth",State=StateAbbreviation.TX},
            };

            hospitals.ForEach(h => context.Hospitals.Add(h));
            context.SaveChanges();
        }
    }
}