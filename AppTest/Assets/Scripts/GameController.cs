using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject moleculePrefab;
    public GameObject capsulePrefab;

    Vector3 startPosition = new Vector3(0, 0, 0);

    public void OnButtonCube()
    {
        if (cubePrefab != null)
        {
            bool isActive = cubePrefab.activeSelf;
            cubePrefab.SetActive(!isActive);
            moleculePrefab.SetActive(false);
            capsulePrefab.SetActive(false);
            cubePrefab.transform.position = startPosition;
            cubePrefab.transform.rotation = Quaternion.identity;
            Camera.main.fieldOfView = 60;
        }
    }

    public void OnButtonMolecule()
    {
        if (moleculePrefab != null)
        {
            bool isActive = moleculePrefab.activeSelf;
            moleculePrefab.SetActive(!isActive);
            cubePrefab.SetActive(false);
            capsulePrefab.SetActive(false);
            moleculePrefab.transform.position = startPosition;
            moleculePrefab.transform.rotation = Quaternion.identity;
            Camera.main.fieldOfView = 60;
        }
    }

    public void OnButtonCapsule()
    {
        if (capsulePrefab != null)
        {
            bool isActive = capsulePrefab.activeSelf;
            capsulePrefab.SetActive(!isActive);
            cubePrefab.SetActive(false);
            moleculePrefab.SetActive(false);
            capsulePrefab.transform.position = startPosition;
            capsulePrefab.transform.rotation = Quaternion.identity;
            Camera.main.fieldOfView = 60;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
