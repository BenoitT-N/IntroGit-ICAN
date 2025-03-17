using Unity.VisualScripting;
using UnityEngine;

public class Toggle_Light : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponent<Light>().enabled)
        {
            GetComponent<Light>().enabled = false;
        }
        else
        {
            GetComponent<Light>().enabled = true;
        }
    }


}
