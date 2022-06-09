using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    public List<Entity> _selfEntity => new List<Entity>();
    public Entity SelfEntity;

    private void Start()
    {
        
    }
}
