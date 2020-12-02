using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.IO;

public class ScreenShotHandler : MonoBehaviour
{
    public Camera myCamera;

    public int resWidth = 3550;
    public int resHeight = 3300;
    public int photoNumber;

    public bool takeHiResShot = false;

    public Image img1,img2,img3,img4;

    private Image imagen;

    public void Start()
    {
        //Debug.Log(Application.persistentDataPath);
    }

    public static string ScreenShotName(int width, int height, int photoNumber)
    {
        return string.Format("{0}/screen_{1}x{2}_{3}.png",
            Application.persistentDataPath,
            width, height, photoNumber);
    }

    public void TakeHiResShot()
    {
        takeHiResShot = true;
    }


    private void LateUpdate()
    {
        if (takeHiResShot)
        {
            ScreenShot();
        }
    }

    [ContextMenu("ScreenShot")]

    void ScreenShot()
    {
        photoNumber = photoNumber + 1;

        if (photoNumber == 1)
            imagen = img1;
        if (photoNumber == 2)
            imagen = img2;
        if (photoNumber == 3)
            imagen = img3;
        if (photoNumber == 4)
            imagen = img4;

        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        myCamera.targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
        myCamera.Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        screenShot.Apply();
        //
        Sprite sprite = Sprite.Create(screenShot, new Rect(0, 0, screenShot.width, screenShot.height), new Vector2(.5f, .5f));
        imagen.sprite = sprite;
        //
        myCamera.targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);
        byte[] bytes = screenShot.EncodeToPNG();

        string filename = ScreenShotName(resWidth, resHeight, photoNumber);
        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("Took screenshot to: {0}", filename));
        takeHiResShot = false;


        if (photoNumber == 4)
        {
            photoNumber = 0;
        }
    }
}
