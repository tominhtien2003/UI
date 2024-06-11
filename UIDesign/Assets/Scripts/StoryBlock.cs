using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryBlock : MonoBehaviour
{
    [SerializeField] private SOStoryBlock currentStoryBlock;

    private TextMeshProUGUI titleText;
    private TextMeshProUGUI contentText;

    private void Awake()
    {
        titleText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        contentText = transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        UpdateStoryBlock();
    }
    public void OptionLeft()
    {
        if (currentStoryBlock.storyBlockOption1 == null)
        {
            Debug.Log("EndLeft!");
            return;
        }
        currentStoryBlock = currentStoryBlock.storyBlockOption1;

        UpdateStoryBlock();
    }
    public void OptionRight()
    {
        if (currentStoryBlock.storyBlockOption2 == null)
        {
            Debug.Log("EndRight!");
            return;
        }
        currentStoryBlock = currentStoryBlock.storyBlockOption2;

        UpdateStoryBlock();
    }
    private void UpdateStoryBlock()
    {
        titleText.text = currentStoryBlock.title;

        contentText.text = currentStoryBlock.content;
    }
}
