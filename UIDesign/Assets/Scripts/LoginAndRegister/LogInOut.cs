using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LogInOut : MonoBehaviour
{
    [SerializeField] Selectable firstInput;

    private void Start()
    {
        firstInput.Select();
    }

    private void Update()
    {
        // Kiểm tra nếu Tab được nhấn
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Lấy đối tượng hiện tại được chọn
            GameObject current = EventSystem.current.currentSelectedGameObject;

            if (current != null)
            {
                Debug.Log(current.name);
                // Kiểm tra nếu Shift đang được giữ
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Selectable previous = current.GetComponent<Selectable>().FindSelectableOnUp();
                    if (previous != null)
                    {
                        previous.Select();
                    }
                }
                else
                {
                    Selectable next = current.GetComponent<Selectable>().FindSelectableOnDown();
                    if (next != null)
                    {
                        next.Select();
                    }
                }
            }
        }
    }
}
