namespace ParksandAPI.Models
{
  public class Park
  {
    public int ParkId { get; set;}
    public string Name { get; set; }
    public bool StatePark { get; set; }
    public bool NationalPark { get; set; }
    public string Activities { get; set; }
    public int Acreage { get; set; }
    public string Address { get; set; }
  }
}