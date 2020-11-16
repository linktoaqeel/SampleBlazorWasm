using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleBlazorWasm.ModelDTO
{
    public class DashboardFilterDTO
    {
        [Display(Name = "Department Id List")]
        public string DepartmentIdList { get; set; }

        [Display(Name = "Employee Id")]
        public string EmployeeId { get; set; }

        [Display(Name = "Duration")]
        public string Daterange { get; set; }

        [Display(Name = "Filter Set?")]
        public bool IsFilterSet { get; set; }

        public DashboardFilterDTO()
        {
            DepartmentIdList = string.Empty;
            EmployeeId = string.Empty;
            Daterange = DateTime.Now.Date.ToString("MM/01/yyyy") + " - " + DateTime.Now.Date.ToString("MM/dd/yyyy");
            IsFilterSet = false;
        }
    }
}
