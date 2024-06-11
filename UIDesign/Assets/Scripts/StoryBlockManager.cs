using UnityEngine;

public class StoryBlockManager : MonoBehaviour
{
    #region Singleton
    private static StoryBlockManager instance;
    public static StoryBlockManager Instance { get { return instance; } }
    #endregion
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
