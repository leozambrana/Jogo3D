using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSaveGameManager : MonoBehaviour
{
  public static WorldSaveGameManager instance;

  [SerializeField] int worldSceneIndex = 1;
  private void Awake()
  {
    // SO VAI TER UMA INSTANCIA DESSE SCRIPT POR VEZ, SE TIVER OUTRO ELE DESTROY
    if (instance == null)
    {
      instance = this;  
    }
    else
    {
      Destroy(gameObject);
    }
  }

  public IEnumerator LoadNewGame()
  {
    AsyncOperation loadOperation = SceneManager.LoadSceneAsync(worldSceneIndex);
    
    yield return null;
  }

  public int GetWorldSceneIndex()
  {
    return worldSceneIndex;
  }
}
