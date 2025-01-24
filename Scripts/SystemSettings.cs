using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class SystemSettings : MonoBehaviour
{

    public static Vector3 resolutionInWorldPoints;

    public static float minPointX, maxPointX, minPointY, maxPointY;


    void Awake()
    {
        float aspectRatio = (float)Screen.width / Screen.height;

        resolutionInWorldPoints = Camera.main.ScreenToWorldPoint(new Vector3(Screen.height, Screen.height, Camera.main.nearClipPlane));

        minPointX = -Camera.main.orthographicSize * aspectRatio;
        maxPointX = Camera.main.orthographicSize * aspectRatio;

        minPointY = -Camera.main.orthographicSize;
        maxPointY = Camera.main.orthographicSize;

    }

    public void ApllicationQuit() => Application.Quit();



    private void OnDestroy()
    {
        resolutionInWorldPoints = Vector3.zero;
        minPointX = 0;
        maxPointX = 0;
    }



}
