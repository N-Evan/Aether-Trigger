using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;
    
    public bool IsMoving;
    public bool IsRunning;

    private void MovePlayer(Vector2 input)
    {
        IsMoving = input.magnitude == 0;
        //Necessary move function here
    }
}
