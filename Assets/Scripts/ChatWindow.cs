using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChatWindow : MonoBehaviour
{
    [SerializeField]
    public GameObject messageContent;

    [SerializeField]
    public GameObject userContent;

    [SerializeField]
    public Text globalChatPrefab;

    [SerializeField]
    public InputField messageInputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            var input = messageInputField.GetComponent<InputField>();
            AddMessage(input.text);
            input.text = string.Empty;
        }
    }

    public void AddMessage(string message)
    {
        Text text = Instantiate(globalChatPrefab, globalChatPrefab.transform.position, globalChatPrefab.transform.rotation) as Text;
        text.transform.SetParent(messageContent.transform, false);
        text.text = message;
    }
}
