using UnityEngine;
using System.Collections;
using System.Reflection;
public abstract class IGameHotFixInterface
{
    public abstract void Start();
    public abstract bool Update(float dt);
    public abstract void OnDestroy();
    public abstract void OnApplicationQuit();
    public abstract object OnMono2GameDll(string func, params object[] data);
}

