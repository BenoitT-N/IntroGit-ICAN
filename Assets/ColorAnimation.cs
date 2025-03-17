using Unity.VisualScripting;
using UnityEngine;

public class ColorAnimation : MonoBehaviour
{
    public Color color;
    void Start()
    {
        GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        GetComponent<Light>().intensity = 0f;
    }


    void Update()
    {
        //GetComponent<MeshRenderer>().material.color += new Color(0f,0.2f,0f) * Time.deltaTime; //rgb (0,0,0)
        //GetComponent<MeshRenderer>().material.color = Color.green;
        GetComponent<Light>().intensity += 0.2f * Time.deltaTime;
        GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", color += new Color(0f,0.2f,0f) * Time.deltaTime);

        if (GetComponent<Light>().intensity >= 2f)
        {
            GetComponent<Light>().intensity = 0f;
            //GetComponent<MeshRenderer>().material.color = Color.black;
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                }

    }

}
