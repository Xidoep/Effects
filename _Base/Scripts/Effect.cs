using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XS_Utils;

[CreateAssetMenu(menuName = "Xido Studio/Effect/Effect")]
public class Effect : ScriptableObject
{
    [SerializeField] GameObject effect;
    [SerializeField] float lifeTime = 5;

    public void Play(Vector3 position, Vector3 normal) => Play(position, normal.ToQuaternion());
    public void Play(Vector3 position, Quaternion rotation) 
    {
        effect.InstantiatePool().transform.SetTransform(position, rotation).gameObject.SetActive(false,lifeTime);
    } 
}
