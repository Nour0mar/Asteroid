using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject PrefabAsteroid;
    

    // Start is called before the first frame update
    void Start()
    {

        GameObject astroid = Instantiate(PrefabAsteroid, transform.position, Quaternion.identity) as GameObject;
        GameObject astroid1 = Instantiate(PrefabAsteroid, transform.position, Quaternion.identity) as GameObject;
        GameObject astroid2 = Instantiate(PrefabAsteroid, transform.position, Quaternion.identity) as GameObject;
        GameObject astroid3 = Instantiate(PrefabAsteroid, transform.position, Quaternion.identity) as GameObject;



        astroid.GetComponent<Asteriod>().Initialize(Direction.Right, new Vector3(-10, 0, 0));
        astroid.transform.position = new Vector3(-10, 0, 0);

        astroid1.GetComponent<Asteriod>().Initialize(Direction.Up, new Vector3(0, -6, 0));
        astroid1.transform.position = new Vector3(0, -6, 0);

        astroid2.GetComponent<Asteriod>().Initialize(Direction.Down, new Vector3(0, 6, 0));
        astroid2.transform.position = new Vector3(0, 6, 0);

        astroid3.GetComponent<Asteriod>().Initialize(Direction.Left, new Vector3(10, 0, 0));
        astroid3.transform.position = new Vector3(10, 0, 0);

    }

  
}
