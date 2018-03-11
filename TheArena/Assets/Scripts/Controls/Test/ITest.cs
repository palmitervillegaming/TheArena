using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITest {

    string SceneName
    {
        get; set;
    }

    void Run();
}
