using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    static Managers Instance { get { Init(); return s_instance; } }


    public InputManager _input =new InputManager();
    void Start()
    {
        Init(); 
    }

    public static InputManager Input { get { return Instance._input; } }
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go==null)
            {
                go = new GameObject { name = "@Managers" };
            }
            DontDestroyOnLoad(go);  
            s_instance = go.AddComponent<Managers>();
        }
    }
}
