﻿using UnityEngine;
using System.Collections;
  
public class RaycastExample : MonoBehaviour {
     void Update() {
         if (Input.GetMouseButtonDown(0)) {
             Debug.Log("mousedown");
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
              if (Physics.Raycast(ray, out hit)) {
                 Debug.Log ("Name = " + hit.collider.name);
                 Debug.Log ("Tag = " + hit.collider.tag);
                 Debug.Log ("Hit Point = " + hit.point);
                 Debug.Log ("Object position = " + hit.collider.gameObject.transform.position);
                 Debug.Log ("--------------");
              }
         }
     }
 }