using UnityEngine;
using UnityEngine.EventSystems;

public class Setting : MonoBehaviour 
{
    [SerializeField] private LeanTweenType tweenType;
    private void Start()
    {
        transform.localScale = Vector3.zero;
    }
    public void Open()
    {
        LeanTween.scale(gameObject, Vector3.one, 0.8f);
    }
    public void Close()
    {
        LeanTween.scale(gameObject, Vector3.zero, 1f).setEase(tweenType);
    }
    private void Update()
    {
        
    }
}
