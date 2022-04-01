using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Xido Studio/Effect/Environment")]
public class EffectEnvironment : ScriptableObject
{
    [SerializeField] Effect small;
    [SerializeField] Effect big;

    public Effect Small => small;
    public Effect Big => big;
}
