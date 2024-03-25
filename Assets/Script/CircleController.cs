using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    AudioSource _Circle;
    private int direction = 1;
    public float movespeed = 3;
    public float Up = 0;
    public float Down = 0;
    // Start is called before the first frame update
    void Start()

    {
        _Circle = GameObject.FindWithTag("Circle").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f, direction, 0f);
        transform.Translate(Vector3.up * direction * movespeed * Time.deltaTime);
        if (transform.position.y > Up)
        {
            direction *= -1;
        }
        else if (transform.position.y < Down)
        {
            direction *= -1;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           _Circle.Play();
        }
    }
}
