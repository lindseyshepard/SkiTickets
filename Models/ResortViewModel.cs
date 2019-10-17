using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Lindsey.Models
{
    public class ResortViewModel
    {
        public string State { get; set; }


        public string ResortName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public List<SelectListItem> States { get; set; }

        public ResortViewModel()
        {
            this.States = new List<SelectListItem>();

        }



    }
}