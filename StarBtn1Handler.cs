// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;
// using UnityEngine.UI;
// 
// public class StarBtn1Handler : MonoBehaviour, IPointerClickHandler
// {
//     public GameObject star;
//     public CameraController camCtrl;
//     public GameManager gm;
// 
//     public void CreateStar(GameObject star)
//     {
//         GameObject starObj = GameObject.Instantiate<GameObject>(star);
//         starObj.transform.position = new Vector3(0, 0, 0);
//         camCtrl.targets.Add(starObj.transform);
//         gm.solarGroup.Add(starObj);
//     }
// 
//     public void OnPointerClick(PointerEventData eventData)
//     {
//         if (star)
//         {
//             CreateStar(star);
//             this.gameObject.GetComponent<Button>().interactable = false;
//             for (int i = 0; i < gm.toolboxBtns.Count; i++)
//             {
//               if (gm.toolboxBtns[i].gameObject.tag == "StarBtn")
//               {
//                 gm.toolboxBtns[i].GetComponent<Button>().interactable = false;
//               }
//             }
//             gm.CheckLevel(gm.solarGroup);
//             gm.LoadLevel(gm.currentLevel);
//             this.enabled = false;
//         }
//     }
// }
