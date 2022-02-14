using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessToggle : MonoBehaviour
{

    public Light singleLight;
    public Image bgImg;
    public Text descriptionText;

    //original colours, store for lerping...
    public Color cSingleLight;
    public Color cBgImg;
    public Color cDescriptionText;

    public void Brighten()
    {

        singleLight.color = new Color(1, 1, 1);
        bgImg.color = new Color(1, 0.93f, 0.74f, 0.33f);
        descriptionText.color = new Color(0.37f, 0, 0.28f);

    }


    public void Darken()
    {

        singleLight.color = new Color(0.7f, 0.59f, 1);
        bgImg.color = new Color(0.1f, 0.02f, 0, 0.33f);
        descriptionText.color = new Color(1, 0.99f, 0.93f);

    }



    public void BrightenOverTime()
    {
        StopAllCoroutines();
        StartCoroutine(BrightenSequence());
    }

    public void DarkenOverTime()
    {
        StopAllCoroutines();
        StartCoroutine(DarkenSequence());
    }




    public IEnumerator BrightenSequence()
    {
        float time = 0;

        while (time < 1)
        {
            singleLight.color = Color.Lerp(new Color(0.7f, 0.59f, 1), new Color(1, 1, 1), time);
            bgImg.color = Color.Lerp(new Color(0.1f, 0.02f, 0, 0.33f), new Color(1, 0.93f, 0.74f, 0.33f), time);
            descriptionText.color = Color.Lerp(new Color(1, 0.99f, 0.93f), new Color(0.37f, 0, 0.28f), time);

            time += Time.deltaTime;
            yield return null;
        }
    }


    public IEnumerator DarkenSequence()
    {
        float time = 0;

        while (time < 1)
        {
            singleLight.color = Color.Lerp(new Color(1, 1, 1), new Color(1, 1, 1), time);
            bgImg.color = Color.Lerp(new Color(1, 0.93f, 0.74f, 0.33f), new Color(0.1f, 0.02f, 0, 0.33f), time);
            descriptionText.color = Color.Lerp(new Color(0.37f, 0, 0.28f), new Color(1, 0.99f, 0.93f), time);

            time += Time.deltaTime;
            yield return null;
        }
    }


}
