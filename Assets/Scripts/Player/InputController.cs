using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [SerializeField] private PlayerInputs PlayerInputsScript;

    public delegate void OnActionEvent();
    
    public event OnActionEvent OnAttackPress;
    public event OnActionEvent OnBlockPress;
    public event OnActionEvent OnSprintPress;
    public event OnActionEvent OnSprintRelease;
    public event OnActionEvent OnPausePress;

    private void Awake()
    {
        
    }

    public Vector2 GetAimPosition()
    {
        //TODO
        return Vector2.one;
        //return PlayerInputsScript.Gameplay.AimInput.ReadValue<Vector2>();
    }

    public void PressAttack(InputAction.CallbackContext ctx)
    {
         if (ctx.performed)
             OnAttackPress?.Invoke();
    }

    public void PressBlock(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            OnBlockPress?.Invoke();
    }

    public void SprintButton(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            OnSprintPress?.Invoke();
        if (ctx.canceled)
            OnSprintRelease?.Invoke();
    }
}
