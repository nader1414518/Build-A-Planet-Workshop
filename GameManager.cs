using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
  public GameObject planetDemoObj;
  public List<GameObject> solarGroup;
  int rotScale = 0;
  [HideInInspector]
  public int currentLevel;
  public GameObject paramSlider;
  public Text paramTxt;
  public Text logTxt;
  public Text statusTxt;
  public List<GameObject> toolboxBtns;
  float planetTemp = 10;
  float orbSpeed = 50;
  public CameraController camCtrl;
  public Star star1;
  public Star star2;
  public Star star3;
  public Planet planet;
  public GameObject planet1;
  public GameObject planet2;
  public GameObject planet3;
  public float starTemp = 0;
  public List<GameObject> toBeDeleted;
  float c = 0.0f;
  public Text paramTxt1;
  public GameObject paramSlider1;
  public GameObject paramPanel;
  public Star mainStar;
  public float optDist;
  public GameObject hintPanel;
  public Text hintTxt;
  public GameObject AtmospherePanel;
  public GameObject GeospherePanel;
  public GameObject oxygenSlider;
  public GameObject co2Slider;
  public GameObject nitrogenSlider;
  public GameObject othersSlider;
  public GameObject solidIronSlider;
  public GameObject moltenIronSlider;
  public GameObject moltenNickelSlider;
  public bool bIsReady = false;
  public bool bIsAtmosphereDone = false;
  public bool bIsGeosphereDone = false;
  public bool MoveForOnce = false;
  // public int planetCount = 0;
  List<GameObject> densePlanets;
  bool bIsDoneForOnce = false;
  public GameObject enemyPrefab;
  public List<GameObject> Enemies;
  int enemiesCount = 10;
  int availableEnemies = 0;

  void AddEnemy () {
    GameObject enemyObj = GameObject.Instantiate<GameObject> (enemyPrefab);
    Enemies.Add (enemyObj);
  }

  public void CreateStar1 () {
    if (star1 && camCtrl) {
      GameObject starObj = GameObject.Instantiate<GameObject> (star1.model);
      starObj.transform.position = new Vector3 (0, 0, 0);
      camCtrl.targets.Add (starObj.transform);
      solarGroup.Add (starObj);
      // Set the temperature for the Star 
      for (int i = 0; i < toolboxBtns.Count; i++) {
        if (toolboxBtns[i].gameObject.tag == "StarBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "PlanetBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = true;
        }
      }
    }
  }

  public void CreateStar2 () {
    if (star2 && camCtrl) {
      GameObject starObj = GameObject.Instantiate<GameObject> (star2.model);
      starObj.transform.position = new Vector3 (0, 0, 0);
      camCtrl.targets.Add (starObj.transform);
      solarGroup.Add (starObj);
      // Set the temperature for the Star 
      for (int i = 0; i < toolboxBtns.Count; i++) {
        if (toolboxBtns[i].gameObject.tag == "StarBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "PlanetBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = true;
        }
      }
    }
  }

  public void CreateStar3 () {
    if (star3 && camCtrl) {
      GameObject starObj = GameObject.Instantiate<GameObject> (star3.model);
      starObj.transform.position = new Vector3 (0, 0, 0);
      camCtrl.targets.Add (starObj.transform);
      solarGroup.Add (starObj);
      // Set the temperature for the Star 
      for (int i = 0; i < toolboxBtns.Count; i++) {
        if (toolboxBtns[i].gameObject.tag == "StarBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "PlanetBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = true;
        }
      }
    }
  }

  public void CreatePlanet1 () {
    if (planet1 && camCtrl) {
      GameObject planetObj = GameObject.Instantiate<GameObject> (planet1);
      planetObj.transform.position = new Vector3 (-3, -0.5f, -5);
      camCtrl.targets.Add (planetObj.transform);
      solarGroup.Add (planetObj);
      for (int i = 0; i < toolboxBtns.Count; i++) {
        if (toolboxBtns[i].gameObject.tag == "StarBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "PlanetBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "VolcanoBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = true;
        } else if (toolboxBtns[i].gameObject.tag == "GasBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        }
      }
    }
  }

  public void CreatePlanet2 () {
    if (planet2 && camCtrl) {
      GameObject planetObj = GameObject.Instantiate<GameObject> (planet2);
      planetObj.transform.position = new Vector3 (-3, -0.5f, -5);
      camCtrl.targets.Add (planetObj.transform);
      solarGroup.Add (planetObj);
      for (int i = 0; i < toolboxBtns.Count; i++) {
        if (toolboxBtns[i].gameObject.tag == "StarBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "PlanetBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "VolcanoBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = true;
        } else if (toolboxBtns[i].gameObject.tag == "GasBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        }
      }
    }
  }

  public void CreatePlanet3 () {
    if (planet3 && camCtrl) {
      GameObject planetObj = GameObject.Instantiate<GameObject> (planet3);
      planetObj.transform.position = new Vector3 (-3, -0.5f, -5);
      camCtrl.targets.Add (planetObj.transform);
      solarGroup.Add (planetObj);
      for (int i = 0; i < toolboxBtns.Count; i++) {
        if (toolboxBtns[i].gameObject.tag == "StarBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "PlanetBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        } else if (toolboxBtns[i].gameObject.tag == "VolcanoBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = true;
        } else if (toolboxBtns[i].gameObject.tag == "GasBtn") {
          toolboxBtns[i].GetComponent<Button> ().interactable = false;
        }
      }
    }
  }

  // public void CheckLevel(List<GameObject> solarGroup)
  // {
  //   for (int i = 0; i < solarGroup.Count; i++)
  //   {
  //     if (solarGroup[i].gameObject.tag == "Star")
  //     {
  //       currentLevel = 1;
  //     }
  //     else if (solarGroup[i].gameObject.tag == "Planet")
  //     {
  //       currentLevel = 2;
  //     }
  //     else if (solarGroup[i].gameObject.tag == "GasCloud")
  //     {
  //       currentLevel = 3;
  //     }
  //   }
  // }

  // public void LoadLevel(int currentLevel)
  // {
  //     if (currentLevel == 1)
  //     {
  //         if (solarGroup.Count >= 2)
  //         {
  //           // Modify the Slider to the needs 
  //           paramTxt.text = "Distance";
  //           float starDistance = Vector3.Distance(solarGroup[0].transform.position, solarGroup[1].transform.position);
  //           paramSlider.GetComponent<Slider>().value = starDistance/10;
  //           for (int i = 0; i < toolboxBtns.Count; i++)
  //           {
  //             if (toolboxBtns[i].gameObject.tag == "StarBtn" || toolboxBtns[i].gameObject.tag == "PlanetBtn")
  //             {
  //               toolboxBtns[i].GetComponent<Button>().interactable = false;
  //             }
  //           }
  //           logTxt.text = "Objective: Place the planet in an appropriate distance\nHint: Press Next Button when ready.";
  //           statusTxt.text = "Status: \nTemperature: " + planetTemp + "\nOrbital Speed: " + orbSpeed;
  //         }
  //     }
  //     else if (currentLevel == 2)
  //     {
  //       for (int i = 0; i < toolboxBtns.Count; i++)
  //       {
  //         if (toolboxBtns[i].gameObject.tag == "VolcanoBtn" || toolboxBtns[i].gameObject.tag == "GasBtn")
  //         {
  //           toolboxBtns[i].GetComponent<Button>().interactable = true;
  //         }
  //         else{
  //           toolboxBtns[i].GetComponent<Button>().interactable = false;
  //         }
  //       }
  //     }
  // }

  // Start is called before the first frame update
  void Start () {
    Application.targetFrameRate = 300;
    for (int i = 0; i < enemiesCount; i++) {
      if (enemyPrefab) {
        AddEnemy ();
        availableEnemies++;
      }
    }
    for (int i = 0; i < toBeDeleted.Count; i++) {
      toBeDeleted[i].SetActive (false);
    }
    Scene scene = SceneManager.GetActiveScene ();
    if (scene.name == "GodView") {
      currentLevel = 1;
    }
    //else if (scene.name == "MainMenu")
    //{
    //    currentLevel = 0;
    //}
    for (int i = 0; i < toolboxBtns.Count; i++) {
      if (toolboxBtns[i].gameObject.tag == "StarBtn") {
        toolboxBtns[i].GetComponent<Button> ().interactable = true;
      } else {
        toolboxBtns[i].GetComponent<Button> ().interactable = false;
      }
    }
    if (logTxt) {
      logTxt.text = "Objective: Use the toolBox to place A Star\nHint: (Avaialable Hints)";
    }
    if (statusTxt) {
      statusTxt.text = "Status:";
    }
    // CheckLevel(solarGroup);
    // LoadLevel(currentLevel);
    if (paramPanel) {
      paramPanel.SetActive (false);
    }
    if (hintPanel) {
      hintPanel.SetActive (false);
    }
    if (GeospherePanel && AtmospherePanel) {
      GeospherePanel.SetActive (false);
      AtmospherePanel.SetActive (false);
    }
    // if (DenseModeBtn)
    // {
    //   DenseModeBtn.SetActive(false);
    // }
  }

  public void GoToNextSphereStage () {
    if (bIsReady && !(MoveForOnce)) {
      for (int i = 0; i < solarGroup.Count; i++) {
        GameObject.Destroy (solarGroup[i].gameObject);
      }
      solarGroup.Clear ();
      if (GeospherePanel && AtmospherePanel) {
        GeospherePanel.SetActive (true);
        AtmospherePanel.SetActive (true);
      }
      if (paramPanel) {
        paramPanel.SetActive (false);
      }
      if (hintPanel) {
        hintPanel.SetActive (false);
      }
      GameObject planetObj = GameObject.Instantiate<GameObject> (planet.model);
      planetObj.transform.position = new Vector3 (0, 0, 0);
      planetObj.transform.localScale = new Vector3 (8, 8, 8);
      camCtrl.targets.Add (planetObj.transform);
      MoveForOnce = true;
    }
    if (bIsAtmosphereDone && bIsGeosphereDone) {
      // Move to Test Level 
      SceneManager.LoadScene ("TPP", LoadSceneMode.Single);
    }
  }

  public void ValidateRatiosAtmosphere () {
    // Atmosphere Assignment 
    if (oxygenSlider) {
      planet.atmosphere.o2 = oxygenSlider.GetComponent<Slider> ().value;
    }
    if (co2Slider) {
      planet.atmosphere.co2 = co2Slider.GetComponent<Slider> ().value;
    }
    if (nitrogenSlider) {
      planet.atmosphere.nitrogen = nitrogenSlider.GetComponent<Slider> ().value;
    }
    if (othersSlider) {
      planet.atmosphere.others = othersSlider.GetComponent<Slider> ().value;
    }

    // Check Conditions 
    if (planet.atmosphere.o2 < 0.1f || planet.atmosphere.o2 > 0.3f) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong O2 Ratio .... ";
      }
    }
    if (planet.atmosphere.co2 < 0.03 || planet.atmosphere.co2 > 0.1) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong CO2 Ratio .... ";
      }
    }
    if (planet.atmosphere.nitrogen < 0.85f || planet.atmosphere.nitrogen > 0.65f) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong Nitrogen Ratio .... ";
      }
    }
    if (planet.atmosphere.others > 0.1f) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong gas combination ... ";
      }
    }

    bIsAtmosphereDone = true;
    AtmospherePanel.SetActive (false);
  }

  public void ValidateRatiosGeosphere () {
    bIsGeosphereDone = true;
    GeospherePanel.SetActive (false);
    // Geosphere Assignment
    if (solidIronSlider) {
      planet.geosphere.solidIron = solidIronSlider.GetComponent<Slider> ().value;
    }
    if (moltenIronSlider) {
      planet.geosphere.moltenIron = moltenIronSlider.GetComponent<Slider> ().value;
    }
    if (moltenNickelSlider) {
      planet.geosphere.moltenNickel = moltenNickelSlider.GetComponent<Slider> ().value;
    }

    if (planet.geosphere.solidIron < 1.0f) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong Solid Iron ratio ... ";
      }
    }
    if (planet.geosphere.moltenIron < 0.95f || planet.geosphere.moltenIron > 0.7f) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong Molten Iron ratio ... ";
      }
    }
    if (planet.geosphere.moltenNickel < 0.04f || planet.geosphere.moltenNickel > 0.2f) {
      if (hintPanel) {
        hintPanel.SetActive (true);
        hintTxt.text = "Warning .. Wrong Molten Nickel ratio ... ";
      }
    }
  }

  public void DenseMode () {
    for (int i = 0; i < 4; i++) {
      GameObject planetObj = GameObject.Instantiate<GameObject> (planet.model);
      densePlanets.Add (planetObj);
      if (i % 2 == 0) {
        densePlanets[i].transform.position = new Vector3 (solarGroup[1].transform.position.x + 3, 0, 0);
      } else {
        densePlanets[i].transform.position = new Vector3 (0, 0, solarGroup[1].transform.position.z + 3);
      }
    }
  }

  // Update is called once per frame
  void Update () {
    // if (planetDemoObj)
    // {
    //     rotScale++;
    //     planetDemoObj.transform.rotation = Quaternion.Euler(0, rotScale, 0);
    // }
    // if (solarGroup.Count >= 2)
    // {
    //   solarGroup[1].transform.position = new Vector3(paramSlider.GetComponent<Slider>().value*10, solarGroup[1].transform.position.y, solarGroup[1].transform.position.z);
    // }
    // 
    // // Updating the UI
    // if (statusTxt)
    // {
    //   statusTxt.text = "Status: \nTemp: " + planetTemp + "\nOrbital Speed: " + orbSpeed;
    // }

    if (enemyPrefab && (availableEnemies < enemiesCount))
    {
      AddEnemy();
      availableEnemies++;
    }

    if (solarGroup.Count == 1 && !(bIsDoneForOnce)) {
      DenseMode ();
      bIsDoneForOnce = true;
    }
    if (solarGroup.Count == 3) {
      // solarGroup[1].transform.RotateAround(solarGroup[0].transform.position, Vector3.up, 30*Time.deltaTime);
      // solarGroup[2].transform.RotateAround(solarGroup[1].transform.position, Vector3.up, 15*Time.deltaTime);
      c = c + 1.0f;
      solarGroup[1].transform.rotation = Quaternion.Euler (0, c, 0);

      // Update UI
      if (paramTxt1 && paramSlider1) {
        paramPanel.SetActive (true);
        hintPanel.SetActive (true);
        paramTxt1.text = "Distance";
        solarGroup[1].transform.position = new Vector3 (paramSlider1.GetComponent<Slider> ().value * 20, 0, 0);
        if (paramSlider1) {
          if (mainStar.Temp == 1000) {
            optDist = 0.2f;
            if (hintPanel) {
              if (paramSlider1.GetComponent<Slider> ().value > 0.25f) {
                hintTxt.text = "HINT: too large ... ";
                bIsReady = false;
              } else if (paramSlider1.GetComponent<Slider> ().value < 0.15f) {
                hintTxt.text = "HINT: too small ... ";
                bIsReady = false;
              } else if (paramSlider1.GetComponent<Slider> ().value >= 0.15f && paramSlider1.GetComponent<Slider> ().value <= 0.25f) {
                hintTxt.text = "HINT: Distance appropriate ... ";
                bIsReady = true;
              }
            }
          } else if (mainStar.Temp == 4000) {
            optDist = 0.75f;
            if (hintPanel) {
              if (paramSlider1.GetComponent<Slider> ().value > 0.8f) {
                hintTxt.text = "HINT: too large ... ";
                bIsReady = false;
              } else if (paramSlider1.GetComponent<Slider> ().value < 0.7f) {
                hintTxt.text = "HINT: too small ... ";
                bIsReady = false;
              } else if (paramSlider1.GetComponent<Slider> ().value >= 0.7f && paramSlider1.GetComponent<Slider> ().value <= 0.8f) {
                hintTxt.text = "HINT: Distance appropriate ... ";
                bIsReady = true;
              }
            }
          } else if (mainStar.Temp == 9000) {
            optDist = 0.85f;
            if (hintPanel) {
              if (paramSlider1.GetComponent<Slider> ().value > 0.9f) {
                hintTxt.text = "HINT: too large ... ";
                bIsReady = false;
              } else if (paramSlider1.GetComponent<Slider> ().value < 0.8f) {
                hintTxt.text = "HINT: too small ... ";
                bIsReady = false;
              } else if (paramSlider1.GetComponent<Slider> ().value >= 0.8f && paramSlider1.GetComponent<Slider> ().value <= 0.9f) {
                hintTxt.text = "HINT: Distance appropriate ... ";
                bIsReady = true;
              }
            }
          }
        }
        solarGroup[1].transform.RotateAround (solarGroup[0].transform.position, Vector3.up, 20 * Time.deltaTime);
        // solarGroup[2].transform.RotateAround(solarGroup[0].transform.position, Vector3.up, 30*Time.deltaTime);
      }
    }
  }
}