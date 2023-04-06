using System.ComponentModel.DataAnnotations;

public class FromNowAttribute : ValidationAttribute
    {
        public FromNowAttribute() {}

        public string GetErrorMessage() => "Card expiry date must be in the future";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (DateTime.Compare(date, DateTime.Now) < 0) return new ValidationResult(GetErrorMessage());
            else return ValidationResult.Success;
        }
    }
public class PaymentModel

{
    [Required]
    public string? Title { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Name must be less than 50 digits")]
    public string? Name { get; set; }

    [Required]
    [FromNow]
    public DateTime? ExpDate { get; set; }

    [Required]
    // [CreditCard]
    [StringLength(19, MinimumLength = 16, ErrorMessage = "Card number must be between 16-19 digits")]
    public string? CardNum { get; set; }

    [Required]
    [StringLength(3, MinimumLength = 3, ErrorMessage = "CVC must be 3 digits")]
    public string? CVC { get; set; }
    public string? FineID { get; set; }
}