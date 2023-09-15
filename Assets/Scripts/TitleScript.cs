using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;

public class TitleScript : MonoBehaviour
{
    public RectTransform mainMenu, titleScreen, signupMenu, levelUpMenu;
    public float uiTransitionSpeed;

    // Start is called before the first frame update
    void Start()
    {
        titleScreen.DOAnchorPos(Vector2.zero, uiTransitionSpeed).SetEase(Ease.InCirc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        titleScreen.DOAnchorPos(new Vector2(0,1920), uiTransitionSpeed).SetEase(Ease.InOutQuad);
        mainMenu.DOAnchorPos(Vector2.zero, uiTransitionSpeed).SetEase(Ease.InOutQuad);
    }

    public void SignUpMenu()
    {
        Debug.Log(50);
        Sequence sequence = DOTween.Sequence();

        sequence.Append(signupMenu.DOAnchorPos(Vector2.zero, 0).SetEase(Ease.Flash));
        sequence.Append(signupMenu.DOScale(Vector2.zero, 0));
        sequence.AppendInterval(1);
        sequence.Append(signupMenu.DOScale(Vector2.one, 0));

    }

    public void CloseSignUp()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(signupMenu.DOScale(Vector2.zero, 0.5f));
        sequence.Append(signupMenu.DOAnchorPos(new Vector2 (-1080,0), uiTransitionSpeed));
        sequence.Append(signupMenu.DOScale(Vector2.one, 0));
    }
}
