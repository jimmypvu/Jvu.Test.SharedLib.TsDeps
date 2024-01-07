using Newtonsoft.Json;

namespace Jvu.Test.SharedLib.TsDeps
{
  public class Serializer
  {
    public string Serialize(object obj)
    {
      return JsonConvert.SerializeObject(obj);
    }

    public T Deserialize<T>(string jsonString)
    {
      return JsonConvert.DeserializeObject<T>(jsonString);
    }
  }
}
