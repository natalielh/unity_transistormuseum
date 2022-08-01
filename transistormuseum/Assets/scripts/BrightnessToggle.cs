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
        //descriptionText.color = new Color(0.37f, 0, 0.28f);
        descriptionText.color = new Color(0.349f, 0.028f, 0.166f);

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
        cSingleLight = singleLight.color;
        cBgImg = bgImg.color;
        cDescriptionText = descriptionText.color;

        float time = 0;

        while (time < 1)
        {
            singleLight.color = Color.Lerp(cSingleLight, new Color(1, 1, 1), time);
            bgImg.color = Color.Lerp(cBgImg, new Color(1, 0.93f, 0.74f, 0.33f), time);
            //descriptionText.color = Color.Lerp(cDescriptionText, new Color(0.37f, 0, 0.28f), time);
            descriptionText.color = Color.Lerp(cDescriptionText, new Color(0.349f, 0.028f, 0.166f), time);

            time += Time.deltaTime;
            yield return null;
        }
    }


    public IEnumerator DarkenSequence()
    {
        cSingleLight = singleLight.color;
        cBgImg = bgImg.color;
        cDescriptionText = descriptionText.color;

        float time = 0;

        while (time < 1)
        {
            singleLight.color = Color.Lerp(cSingleLight, new Color(0.34f, 0.17f, 0.64f), time);
            bgImg.color = Color.Lerp(cBgImg, new Color(0.1f, 0.02f, 0, 0.33f), time);
            descriptionText.color = Color.Lerp(cDescriptionText, new Color(1, 0.99f, 0.93f), time);


            time += Time.deltaTime;
            yield return null;
        }
    }


}