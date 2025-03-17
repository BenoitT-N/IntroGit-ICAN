using UnityEngine;

public class ToggleLight_ChangeMaterial : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponent<Light>().enabled)
        {
            GetComponent<Light>().enabled = false;
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
        }
        else
        {
            GetComponent<Light>().enabled = true;
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.yellow);
        }
    }






}
