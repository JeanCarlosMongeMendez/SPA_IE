using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class ScheduleData
    {


        public List<SelectSchedule_Result> ListAllSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SPSelectSchedule().ToList();
            }
        }


    }
}