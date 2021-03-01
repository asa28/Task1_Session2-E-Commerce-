using System;
using System.ComponentModel.DataAnnotations;

namespace Domain_DataLayer.CommonModels
{
    public class BasicModel
    {        
        public BasicModel()
        {
            CreatedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

    }
}
