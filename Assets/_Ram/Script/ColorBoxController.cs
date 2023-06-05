using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBoxController : MonoBehaviour
{
    public GameObject cube;
    public int noOfBox = 4;

    public List<Color> colors = new List<Color>();

    private void Start()
    {
        CreateColorCubes();
    }


    private void CreateColorCubes()
    {
        int row = noOfBox / 2;
        int column = noOfBox / 2;
        int topRow = noOfBox / 2;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int r = 0; r < topRow; r++)
                {
                    GameObject _box = Instantiate(cube,transform);
                    _box.transform.position = new Vector3(i, j, r);
                    Color _color = colors[Random.Range(0, colors.Count)];
                    _box.GetComponent<MeshRenderer>().material.color = _color;
                    _box.name = ColorUtility.ToHtmlStringRGBA(_color).ToString();
                }
            }
        }
    }
}
