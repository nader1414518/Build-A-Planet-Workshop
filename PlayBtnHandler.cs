// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;
// 
// public class PlayBtnHandler : MonoBehaviour, IPointerClickHandler
// {
//     public GameManager gm;
//     public float starOptDistance;
// 
//     public void OnPointerClick(PointerEventData eventData)
//     {
//         // Check of Level then check player logic 
//         gm.CheckLevel(gm.solarGroup);
//         if (gm.currentLevel == 1)
//         {
//           if (Vector3.Distance(gm.solarGroup[0].transform.position, gm.solarGroup[1].transform.position) > starOptDistance-1 || Vector3.Distance(gm.solarGroup[0].transform.position, gm.solarGroup[1].transform.position) < starOptDistance+1)
//           {
//             gm.logTxt.text = "Objective: Place the planet in an appropriate distance\nHint: Distance is acceptable ... ";
//           }
//           else{
//             if (Vector3.Distance(gm.solarGroup[0].transform.position, gm.solarGroup[1].transform.position) < starOptDistance-1)
//             {
//               gm.logTxt.text = "Objective: Place the planet in an appropriate distance\nHint: Distance is very short ... ";
//             }
//             else if (Vector3.Distance(gm.solarGroup[0].transform.position, gm.solarGroup[1].transform.position) > starOptDistance+1)
//             {
//               gm.logTxt.text = "Objective: Place the planet in an appropriate distance\nHint: Distance is very large ... ";
//             }
//           }
//         }
// 
// 
// 
//         // construct next UI, check currentLevel, if 4 take the player for the TPP scene 
//     }
// }
