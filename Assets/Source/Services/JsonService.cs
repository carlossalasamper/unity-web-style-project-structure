using UnityEngine;

/// <summary>
/// Serializes/Deserializes objects
/// </summary>
public class JsonService : IService
{
    // Singleton
    private static JsonService instance;
    public static JsonService Instance
    {
        get
        {
            if (instance == null) {
                instance = new JsonService();  
            }

            return instance;
        }
    }

    private JsonService() { }

    public void Initialize() { }
    public void Dispose() { }

    /// <summary>
    /// String to object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="text"></param>
    /// <returns></returns>
    public T Deserialize<T>(string text)
    {
        return JsonUtility.FromJson<T>(text);
    }

    /// <summary>
    /// Object to String
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public string Serialize<T>(T data)
    {
        return JsonUtility.ToJson(data);
    }
}

