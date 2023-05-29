using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBoxController : MonoBehaviour
{
    public GameObject cube;
    public int noOfBox;

    private void Start()
    {
        CreateColorBox();
    }

    private void CreateColorBox()
    {
        int x = noOfBox/3;
        int y = noOfBox / 3;
        int z = noOfBox / 3;

        int xBox = 0;
        int yBox = 0;
        int zBox = 0;
        // ----- calculation 

        Debug.Log($"Value of X is {x} and Y is {y} and Z is {z}");

        for (int i = 0; i < noOfBox; i++)
        {
            if ((i+1) % 3 == 1)
            {
                GameObject box = Instantiate(cube, transform);
                box.name = i.ToString();
                box.transform.position = new Vector3(xBox + 1, yBox, zBox);
                xBox++;
            }else if ((i + 1) % 3 == 2)
            {
                GameObject box = Instantiate(cube, transform);
                box.name = i.ToString();
                box.transform.position = new Vector3(xBox, yBox + 1, zBox);
                yBox++;
            }
            else if ((i + 1) % 3 == 0)
            {
                GameObject box = Instantiate(cube, transform);
                box.name = i.ToString();
                box.transform.position = new Vector3(xBox, yBox, zBox + 1);
                zBox++;
            }
        }
    }
}
