using UnityEngine;
using UnityEngine.InputSystem;

public class Hero_Controls : MonoBehaviour
{
    public Animator heroAnimator;

    public void OnWave(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            heroAnimator.SetTrigger("Wave");
        }
    }
}
