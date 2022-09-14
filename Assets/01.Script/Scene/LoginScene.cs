using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        sceneType = Define.Scene.Login;
    }
    public override void Clear()
    {
        print("LoginScene Clear!");
    }
}
