using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThridPersonCamCtrl : MonoBehaviour
{
    GameObject player;
    public float yOffset;
    public float zOffset;
    
    void Start()
    {
      player = GameObject.FindWithTag("Player");
    }
    
    void FixedUpdate()
    {
      this.transform.position = new Vector3(
        player.transform.position.x,
        player.transform.position.y+yOffset,
        player.transform.position.z+zOffset
      );
    }
}
