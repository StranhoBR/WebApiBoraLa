using System.ComponentModel.DataAnnotations;

namespace ApplicationServicesSO.Models
{
    public class SalesModel
    {
        [Key]
        [Required]
        public int key { get; set; }
        public string Org { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ReportName { get; set; }
        public string SoldtoCode { get; set; }
        public string SoldtoName { get; set; }
        public string SoldtoReportName { get; set; }
        
    }
}
