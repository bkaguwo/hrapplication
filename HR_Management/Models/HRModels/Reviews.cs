using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HR_Management.Models.HRModels
{
    public class Reviews
    {
        [Required]
        [Key]
        public int ID { get; set; }
        public string empId { get; set; }
        public string date { get; set; }
        public string title { get; set; }
        public string manager { get; set; }
        public double score { get; set; }
        public string description { get; set; }
    }
}
