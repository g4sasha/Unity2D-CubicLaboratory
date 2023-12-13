using System;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [NonSerialized] public bool IsGrounded;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            IsGrounded = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            IsGrounded = false;
        }
    }
}