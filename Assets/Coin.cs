using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float t = 0;
    public float amp = 0.03f;
    public float freq = 2;
    public float offset = 0;
    public Vector3 startPos;

    public Player objWithCounter;

    private void Start()
    {
        startPos = transform.position;
    }

    private void FixedUpdate()
    {
        t = t + Time.deltaTime;
        offset = amp * Mathf.Sin (t * freq);
        transform.position = transform.position + new Vector3(0, offset, 0);
    }

    void Update()
    {
        transform.Rotate(0.0f, 1f, 0.0f);

    }


    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player == null) return;

        Debug.Log(message:"Coin was collected!");
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        objWithCounter.counter += 1;
        Debug.Log(message: "Coins: " + objWithCounter.counter.ToString());
    }

}
