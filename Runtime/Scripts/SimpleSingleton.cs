public class SimpleSingleton<T> where T : new()
{
  protected static T _instance;

  public static T Instance
  {
    get
    {
      CreateIfNull();
      return _instance;
    }
  }

  internal static void CreateIfNull()
  {
    if (_instance == null)
      _instance = new T();
  }
}
