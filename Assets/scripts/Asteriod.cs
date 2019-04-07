using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteriod : MonoBehaviour
{
    
    [SerializeField]
    Sprite asteriod11;
    [SerializeField]
    Sprite asteriod22;
    [SerializeField]
    Sprite asteriod33;

    const float MinImpulseForce = 0.5f;
    const float MaxImpulseForce = 2f;
    float angle;
   
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriterenderer = GetComponent<SpriteRenderer>();
        int SpriteNumber = Random.Range(0, 3);
        if (SpriteNumber == 0)
        {
            spriterenderer.sprite = asteriod11;
        }
        else if (SpriteNumber == 1)
        {
            spriterenderer.sprite = asteriod22;
        }
        else
        {
            spriterenderer.sprite = asteriod33;
        }
    }
   
    public void Initialize(Direction dir,Vector3 location)
    {
       
        if (dir == Direction.Up)
        {
            angle = Random.Range(75 * Mathf.Deg2Rad, 105 * Mathf.Deg2Rad);
            Vector2 moveDirection = new Vector2(
           Mathf.Cos(angle), Mathf.Sin(angle));
            float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
            GetComponent<Rigidbody2D>().AddForce(
                moveDirection * magnitude,
                ForceMode2D.Impulse);
        }

        else if (dir == Direction.Down)
        {
            angle = Random.Range(265 * Mathf.Deg2Rad, 285 * Mathf.Deg2Rad);
            Vector2 moveDirection = new Vector2(
           Mathf.Cos(angle), Mathf.Sin(angle));
            float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
            GetComponent<Rigidbody2D>().AddForce(
                moveDirection * magnitude,
                ForceMode2D.Impulse);
        }

        else if (dir == Direction.Right)
        {
            angle = Random.Range(-15 * Mathf.Deg2Rad, 15 * Mathf.Deg2Rad);
            Vector2 moveDirection = new Vector2(
           Mathf.Cos(angle), Mathf.Sin(angle));
            float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
            GetComponent<Rigidbody2D>().AddForce(
                moveDirection * magnitude,
                ForceMode2D.Impulse);
        }

        else if (dir == Direction.Left)
        {
            angle = Random.Range(165 * Mathf.Deg2Rad, 195 * Mathf.Deg2Rad);
            Vector2 moveDirection = new Vector2(
           Mathf.Cos(angle), Mathf.Sin(angle));
            float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
            GetComponent<Rigidbody2D>().AddForce(
                moveDirection * magnitude,
                ForceMode2D.Impulse);
        }
    }

    public void StartMoving() 
    {
        angle = Random.Range(0 , 2 * Mathf.PI);
        Vector2 moveDirection = new Vector2(
       Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            moveDirection * magnitude,
            ForceMode2D.Impulse);
    }
    void OnCollisionEnter2D(Collision2D obj)
    {
       
        if (obj.gameObject.tag == "Bullet")
        {
            AudioManager.Play(AudioClipName.AsteroidHit);
            transform.localScale=new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z)*1/2;
           
            CircleCollider2D rad = GetComponent<CircleCollider2D>();
            rad.radius *= 0.5f;
            if (transform.localScale.x <0.5)
            {

                Destroy(gameObject);
            }
            else
            {
                GameObject astroid = Instantiate(gameObject, transform.position, Quaternion.identity) as GameObject;
                GameObject astroid1 = Instantiate(gameObject, transform.position, Quaternion.identity) as GameObject;
                astroid.GetComponent<Asteriod>().StartMoving();
                astroid1.GetComponent<Asteriod>().StartMoving();
                astroid.transform.position = transform.position;
                astroid1.transform.position = transform.position;
          
            }
             Destroy(gameObject);

        }
    }

    
    
}
