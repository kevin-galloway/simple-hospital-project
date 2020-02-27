using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospitals.Models
{
    public enum StateAbbreviation
    {
        AL, AK, AS, AZ, AR, CA, CO, CT, DE, DC, FL, GA, HI, ID, IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ, NM, NY, NC, ND, OH, OK, OR, PA, RI, SC, SD, TN, TX, UT, VT, VA, WA, WV, WI, WY
    }
    public class Hospital
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public StateAbbreviation State { get; set; }
    }
}