using UnityEngine;

public interface ICharacterMovement
{
    public Vector3 moveDirection{get; set;} // Desired Move direction
    public float speed{get;} // how fast our character is moving
    public bool grounded{get;} // Whether character is on ground
    public void Jump(); // Called to jump if we are on the ground
}

