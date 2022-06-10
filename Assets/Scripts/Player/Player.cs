using System;
using UnityEngine;

[RequireComponent(typeof(MovementController), typeof(AttackController), typeof(AnimationController))]
[RequireComponent(typeof(InputController))]
public abstract class Player : MonoBehaviour
{
    [SerializeField] private MovementController _movementScript;
    [SerializeField] private AttackController _attackScript;
    [SerializeField] private AnimationController _animationScript;
    [SerializeField] private InputController _inputScript;

    public string PlayerName;

    #region Awake

    public virtual void Awake()
    {
        AssignComponents();
        SubscribeInputEvents();
        Debug.Log($"Player Init <color=red>Complete</color>");
    }

    private void AssignComponents()
    {
        _movementScript = GetComponent<MovementController>();
        _attackScript = GetComponent<AttackController>();
        _animationScript = GetComponent<AnimationController>();
        _inputScript = GetComponent<InputController>();
    }

    private void SubscribeInputEvents()
    {
        _inputScript.OnAttackPress += InitiatePlayerAttack;
        _inputScript.OnBlockPress += InitiatePlayerBlock;
        _inputScript.OnSprintPress += InitiatePlayerSprint;
        _inputScript.OnSprintRelease += StopPlayerSprint;

        _inputScript.OnAttackPress += _animationScript.PlayAttackAnimation;
    }

    #endregion

    #region PlayerActions

    public virtual void InitiatePlayerAttack()
    {
        throw new NotImplementedException();
    }

    public virtual void InitiatePlayerSprint()
    {
        throw new NotImplementedException();
    }

    public virtual void InitiatePlayerBlock()
    {
        throw new NotImplementedException();
    }

    public virtual void StopPlayerSprint()
    {
        throw new NotImplementedException();
    }

    #endregion


}
