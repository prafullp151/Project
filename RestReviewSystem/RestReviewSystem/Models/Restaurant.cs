using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestReviewSystem.Models
{
    public class Restaurant
    {
        [DisplayName("Name of the Restaurant")]
        public string RestaurantName { get; set; }
        public int RestaurantId { get; set; }
        [Range(0,5)]
        [DisplayName("Avarage Rating")]
        public int AvgRating { get; set; }
        [DisplayName("How Costly $ $$ $$$")]
        public string Avgcostofmeal { get; set; }
        [DisplayName("Has Vegeterian Entrees?")]
        public bool VegChoices { get; set; }
        [DisplayName("Has Drinks Bar?")]
        public bool BarAavialable { get; set; }
        [DisplayName("Num Of Employees")]
        public int? NoOFEmployees { get; set; }
        [DataType(DataType.Time)]
        [DisplayName("Time Opens")]
        public DateTime OpeningTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayName("Time Closes")]
        public DateTime ClosingTime { get; set; }
        [DisplayName("Cuisine Type")]
        public string TypeOfCuisine { get; set; }
        [DisplayName("Payment Methods")]
        public string PaymentMode { get; set; }
        [DisplayName("Delivers Food?")]
        public bool DeliveryAvailable { get; set; }
        [DisplayName("Has Buffet?")]
        public bool BuffetAvailable { get; set; }
        [DisplayName("Has cafe?")]
        public bool CafeAvailable { get; set; }
    }
}
