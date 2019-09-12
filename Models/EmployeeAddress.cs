
namespace FirstDotnetCoreMVC.Models
{
    public class EmployeeAddress
    {
        public int EmployeeAddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public Employee Employee { get; set; }
        
    }
}