using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] cars = new GameObject[7];
    public GameObject spawn;
    public GameObject grave;
    List<GameObject> children = new List<GameObject>();
    public int dir = -1;
    private float timer = 100.0f;
    //-1 = right 1 = left

    // Start is called before the first frame update
    void Start()
    {
        int carInd = (int)Random.Range(0f, 4f);
        Vector3 toSpawn = new Vector3(spawn.transform.position.x, spawn.transform.position.y - 4, spawn.transform.position.z + 2);
        children.Add(Instantiate(cars[carInd], toSpawn, Quaternion.Euler(0, dir * 90, 0)));
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 240.0f)
        {
            int carInd = (int)Random.Range(0f, 4f);
            Vector3 toSpawn = new Vector3(spawn.transform.position.x, spawn.transform.position.y - 4, spawn.transform.position.z + (2 * -dir));
            children.Add(Instantiate(cars[carInd], toSpawn, Quaternion.Euler(0, dir * 90, 0)));
            timer = 0.0f;
        }
        else timer += 100 * Time.deltaTime;


        foreach(GameObject car in children)
        {
                car.transform.Translate(Vector3.back * Time.deltaTime * 20);
              if(dir == -1 && car.transform.position.x > grave.transform.position.x)
            {
                Destroy(car);
            }
              else if(dir == 1 && car.transform.position.x < grave.transform.position.x)
            {
                Destroy(car);
            }
        }
    }
}
