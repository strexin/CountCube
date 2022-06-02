using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    public int speed;
    public TMP_Text scoreDisplay;

    public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.SetText(score.ToString());

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed, ForceMode.Force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
