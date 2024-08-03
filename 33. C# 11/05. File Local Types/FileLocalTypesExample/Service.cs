internal class Service
{
  public string GetData()
  {
    AdditionalService additionalService = new AdditionalService();
    return $"Main service {additionalService.GetAdditionalData()}";
  }
}

file class AdditionalService
{
  public string GetAdditionalData()
  {
    return "Additional Service";
  }
}