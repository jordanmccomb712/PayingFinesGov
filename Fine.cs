using System.Text.Json.Serialization;

public class Fine{

    [JsonPropertyName("fineID")]
    public string FineID {get; set; }
    [JsonPropertyName("fullName")]
    public string FullName {get; set;}
    [JsonPropertyName("amountDue")]
    public double AmountDue {get; set;} //in GBP
    [JsonPropertyName("dateIssued")]
    public DateTime DateIssued {get; set;}
    [JsonPropertyName("isPaid")]
     public bool IsPaid {get; set;}

    public Fine(string fineID, string fullName, double amountDue, DateTime dateIssued, bool isPaid)
    {
        this.FineID = fineID;
        this.FullName = fullName;
        this.AmountDue = amountDue;
        this.DateIssued = dateIssued;
        this.IsPaid = isPaid;
    }
}