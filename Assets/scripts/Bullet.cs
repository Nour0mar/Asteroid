using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
const float SPEED = 20f;
const float BulletLife =2;
private Timer DeathTimer;
    // Start is called before the first frame update
    void Start()
    {
        DeathTimer = gameObject.AddComponent<Timer>();
       DeathTimer.Duration=BulletLife;
       DeathTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (DeathTimer.Finished)
        {
            Destroy(gameObject);
        }
    }
    public void ApplyForce(Vector2 ForceDirction)
    {
        GetComponent<Rigidbody2D>().AddForce(ForceDirction * SPEED, ForceMode2D.Impulse);
    }

}



