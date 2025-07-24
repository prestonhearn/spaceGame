using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Gameplay
{
    [CreateAssetMenu(menuName = "InputReader")]
    public class InputReader : ScriptableObject, GameInput.IGameplayActions, GameInput.IUIActions
    {
        private GameInput gameInput;

        private void OnEnable()
        {
            if (gameInput == null)
            {
                gameInput = new GameInput();
                gameInput.Gameplay.SetCallbacks(this);
                gameInput.UI.SetCallbacks(this);

                SetGamePlay();
            }
            
        }

        private void OnDisable()
        {
            gameInput.Gameplay.Disable();
            gameInput.UI.Disable();
        }

        public void SetGamePlay()
        {
            gameInput.Gameplay.Enable();
            gameInput.UI.Disable();
        }

        public void SetUI()
        {
            gameInput.Gameplay.Disable();
            gameInput.UI.Enable();
        }

        public event Action<Vector2> VerticalMoveEvent;

        public event Action BoostEvent;
        public event Action BoostCancelEvent;

        public event Action PauseEvent;
        public event Action ResumeEvent;

        public void OnBoost(InputAction.CallbackContext context)
        {

        }

        public void OnPause(InputAction.CallbackContext context)
        {

        }

        public void OnVerticalMove(InputAction.CallbackContext context)
        {
            //Debug.Log($"Phase: {context.phase}, Vertical Move: {context.ReadValue<Vector2>()}");
            Vector2 position = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
            Debug.Log($"Phase: {context.phase}, Vertical Move Position: {position}");
        }

        public void OnResume(InputAction.CallbackContext context)
        {

        }
    }
}

