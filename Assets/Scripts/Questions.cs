using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    [SerializeField]
    Question[] question;

    struct Question
    {
        public string name;
        public string description;
        public string id;
    }
}
