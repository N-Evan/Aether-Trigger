using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animatorComponent;

    [SerializeField] private RuntimeAnimatorController _defaultController;

    private void Awake()
    {
        AssignComponents();
    }

    private void AssignComponents()
    {
        _animatorComponent = GetComponent<Animator>();
        if (_animatorComponent.runtimeAnimatorController == null)
        {
            Debug.LogWarning($"<color=red>Animation controller not found</color>");
            _animatorComponent.runtimeAnimatorController = _defaultController;
        }
    }

    public void PlayMoveAnimation()
    {
        //Todo
    }

    public void PlayAttackAnimation()
    {

    }
}
