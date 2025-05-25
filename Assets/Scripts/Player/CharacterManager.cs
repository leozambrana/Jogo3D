using UnityEngine;

namespace Player
{
   public class CharacterManager : MonoBehaviour
   {
      private void Awake()
      {
         DontDestroyOnLoad(this);
      }
   }
}
