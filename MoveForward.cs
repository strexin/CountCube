using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs", 5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if(transform.position.z < -30)
        {
            Destroy(gameObject);
        }
    }

    private void SpawnObs()
    {
        Instantiate(Obstacle, new Vector3(0, 0, 6), Quaternion.identity);
    }
}
