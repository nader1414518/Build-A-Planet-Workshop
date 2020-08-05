// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.EventSystems;
// 
// public class PlanetBtn1Handler : MonoBehaviour, IPointerClickHandler
// {
//     public GameObject planet;
//     public CameraController camCtrl;
//     public GameManager gm;
// 
//     public void CreatePLanet(GameObject planet)
//     {
//       GameObject planetObj = GameObject.Instantiate<GameObject>(planet);
//       planetObj.transform.position = new Vector3(-3, -0.5f, -5);
//       camCtrl.targets.Add(planetObj.transform);
//       gm.solarGroup.Add(planetObj);
//     }
// 
//     public void OnPointerClick(PointerEventData eventData)
//     {
//       if (planet)
//       {
//         CreatePLanet(planet);
//         this.GetComponent<Button>().interactable = false;
//         for (int i = 0; i < gm.toolboxBtns.Count; i++)
//         {
//           if (gm.toolboxBtns[i].gameObject.tag == "PlanetBtn")
//           {
//             gm.toolboxBtns[i].GetComponent<Button>().interactable = false;
//           }
//         }
//         gm.CheckLevel(gm.solarGroup);
//         gm.LoadLevel(gm.currentLevel);
//         this.enabled = false;
//       }
//     }
// }
