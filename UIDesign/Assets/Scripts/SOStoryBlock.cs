using UnityEngine;

[CreateAssetMenu(fileName = "New Story Block")]
public class SOStoryBlock : ScriptableObject
{
    public string title;

    public string content;

    public SOStoryBlock storyBlockOption1;

    public SOStoryBlock storyBlockOption2;
}
