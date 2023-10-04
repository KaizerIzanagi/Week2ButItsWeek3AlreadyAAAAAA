using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIScript : MonoBehaviour
{
    public Image image_1;
    public float duration;
    public float fadeDuration;
    public Vector3 targetRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(image_1.transform.DOLocalRotate(-targetRotation, duration).SetEase(Ease.Linear));
        sequence.Append(image_1.transform.DOLocalRotate(Vector3.zero, duration).SetEase(Ease.Linear));
    }

    public void Fade()
    {
        /*Color originalColor = image_1.color;
        image_1.color = new Color();*/
        image_1.DOFade(0, fadeDuration);
    }

    public void Vent()
    {
        //Sequence sequence = DOTween.Sequence();

        /*
        //First TASK/Append
        sequence.Append(image_1.transform.DOLocalMoveY(750, duration));
        //Delay For 2nd TASK
        sequence.AppendInterval(0);
        //2nd Task
        sequence.Append(image_1.transform.DOLocalRotate(targetRotation, duration).SetEase(Ease.Linear));
        //Delay for 3rd TASK
        sequence.AppendInterval(0);
        //3rd TASK
        sequence.Append(image_1.DOFade(0, fadeDuration));
        */

        image_1.transform.DOScale(Vector3.zero, duration);
    }

    public void Eject()
    {
        image_1.transform.DOLocalRotate(targetRotation, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
        image_1.transform.DOLocalMoveY(750, duration);
        image_1.transform.DOScale(Vector3.zero, duration);
        image_1.DOFade(0, fadeDuration);
    }

    public void FromAbove()
    {
        image_1.transform.DOLocalMoveY(750, duration);
        image_1.transform.DOScale(Vector3.zero, duration);
        image_1.DOFade(0, fadeDuration);
    }

    public void Flicker()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(image_1.DOFade(0, 0.2f));
        sequence.Append(image_1.DOFade(5, 0.1f));
        sequence.Append(image_1.DOFade(0, 0.3f));
        sequence.Append(image_1.DOFade(5, 0.2f));
    }

    public void FromBelow()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(image_1.transform.DOLocalMoveY(20, 0.2f));
        sequence.Append(image_1.transform.DOLocalMoveY(-1920, duration));
        
    }

    public void Pulse()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(image_1.transform.DOScale(4.8f, 0.1f));
        sequence.Append(image_1.DOFade(0.7f, 0.2f));
        sequence.Append(image_1.transform.DOScale(5, 0.1f));
        sequence.Append(image_1.DOFade(1, 0.2f));
    }
}
