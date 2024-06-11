using UnityEngine;

public class CatJump : MonoBehaviour
{
    public void Jump()
    {
        Debug.Log("Pressed");
        transform.LeanMoveLocal(new Vector2(854, 100), 1f).setEaseOutQuart().setLoopPingPong();
        
    }
}
