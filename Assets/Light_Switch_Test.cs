using UnityEngine;
using UnityEngine.UI;

public class Light_Switch_Test : MonoBehaviour
{
    public Color color;
    private void OnMouseDown()
    {
        Debug.Log("Clicked on " + name);
        color.g += 0.1f;
        GetComponent<Light>().color = color;

        //Modifier la couleur en la stockant dans une variable temporaire
        //Color col = GetComponent<Light>().color;
        //col.g += 0.1f;
        //GetComponent<Light>().color = col;


        //1 Désactiver tout l'objet par script :
        //gameObject.SetActive(false);

        //2 Désactiver composant Light :
        //GetComponent<Light>().enabled = false;

        //3 Modifier Intensité de la lumière :
        //GetComponent<Light>().intensity = 0.5f;

        //4 modifier couleur du material :
        //GetComponent<MeshRenderer>().material.color = Color.black; //rgb (0,0,0)
        //Color.red (1,0,0)
        //GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue); //changement de couleur d'émission d'un material

        //Variable de type Color
        //    Color color = new Color(0, 0, 0); //color.black
        //    color = new Color(1f, 0, 0); //color.red
        //    color = new Color(0.5f, 0.5f, 0);
        //    color.r = 0f;
        //    color.g = 0f;
        //    color.b = 0f;
        //    GetComponent<Light>().color = color;

        //    Vector3 direction = new Vector3(1f, 0, 0); //Vecttor3.right
        //    direction = new Vector3(0f, 1f, 0f); //Vector3.up

    }
}
