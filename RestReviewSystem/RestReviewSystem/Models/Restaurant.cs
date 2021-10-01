using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestReviewSystem.Models
{
    public class Restaurant
    {
        public string RestaurantName { get; set; }
        public int RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Avgcostofmeal { get; set; }
        public bool VegChoices { get; set; }
        public bool BarAavialable { get; set; }
        public int? NoOFEmployees { get; set; }
        [DataType(DataType.Time)]
        public DateTime OpeningTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime ClosingTime { get; set; }
        public string TypeOfCuisine { get; set; }
        public string PaymentMode { get; set; }
        public bool DeliveryAvailable { get; set; }
        public bool BuffetAvailable { get; set; }
        public bool CafeAvailable { get; set; }
    }
}
