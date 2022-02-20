using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(message:"Awake");

    }
    void Start()
    {
        Debug.Log(message: "Start");
    }

    private void OnEnable()
    {
        Debug.Log(message: "OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log(message: "OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log(message: "OnDestroy");
    }

    void Update()
    {
        Debug.Log(message: "Update");
    }
}
