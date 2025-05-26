using System;
using UnityEngine;

namespace Character
{
   public class CharacterManager : MonoBehaviour
   {
      protected virtual void Awake()
      {
         DontDestroyOnLoad(this);
      }

      protected virtual void Update()
      {
         
      }
   }
}
