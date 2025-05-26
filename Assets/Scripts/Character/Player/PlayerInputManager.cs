using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class PlayerInputManager : MonoBehaviour
    {
        public static PlayerInputManager Instance;
        
        private PlayerControls _playerControls;
        
        [SerializeField] Vector2 movementInput;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            SceneManager.activeSceneChanged += OnSceneChange; 
        }

        private void Start()
        {
            DontDestroyOnLoad(gameObject);

            Instance.enabled = false;
        }

        private void OnSceneChange(Scene oldScene, Scene newScene)
        {
            Instance.enabled = newScene.buildIndex == WorldSaveGameManager.instance.GetWorldSceneIndex();
        }
        
        private void OnEnable()
        {
            if (_playerControls == null)
            {
                _playerControls = new PlayerControls();
                
                _playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            }
            
            _playerControls.Enable();
        }
        
        private void OnDestroy()
        {
            SceneManager.activeSceneChanged -= OnSceneChange;
        }

    }
}
