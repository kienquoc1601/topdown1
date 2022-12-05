using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesScript 
{
    public static void MoveScript(Vector2 moveInput , Rigidbody2D rigidbody , float speed)
    {
        Vector2 vel = rigidbody.velocity;
        rigidbody.MovePosition(rigidbody.position + moveInput * speed * Time.fixedDeltaTime);
    }

}
