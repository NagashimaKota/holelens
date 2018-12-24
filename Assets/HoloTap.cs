using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class HoloTap : MonoBehaviour, IInputClickHandler {

    public void OnInputClicked(InputClickedEventData eventData)
    {
        gameObject.AddComponent<Rigidbody>();
    }

    void Start ()
    {
		
	}


    void Update ()
    {
		
	}
}
