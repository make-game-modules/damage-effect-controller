using UnityEngine;
/// <summary>
/// DamageEffectController 类是一个受伤特效控制器，用于管理角色受伤时的粒子效果。
/// 此类提供了两个公开方法，当角色受伤时，可以调用 "TriggerDamageEffect" 方法产生特效，当不需要产生特效时，可以调用 "StopDamageEffect" 方法停止特效。
/// 你可以将此脚本挂载到任何角色对象上，以便在角色受伤时自动产生特效。
/// </summary>
public class DamageEffectController : MonoBehaviour
{
    // 该变量存储粒子系统组件的引用
    public ParticleSystem damageEffect;

    /// <summary>
    /// Awake 函数在对象实例化时被 Unity 自动调用，用于初始化脚本。
    /// 在此函数中，我们获取并存储粒子系统组件的引用。
    /// </summary>
    private void Awake()
    {
        damageEffect = GetComponentInChildren<ParticleSystem>();
    }

    /// <summary>
    /// TriggerDamageEffect 是一个公开方法，用于触发受伤特效。
    /// 当角色受伤时，你可以调用此方法来产生喷血粒子效果。
    /// </summary>
    public void TriggerDamageEffect()
    {
        // 首先，确保粒子系统处于非运行状态
        if (damageEffect.isPlaying)
        {
            return;
        }

        Debug.Log("TriggerDamageEffect");

        // 然后，启动粒子系统
        damageEffect.Play();
    }

    /// <summary>
    /// StopDamageEffect 是一个公开方法，用于停止受伤特效。
    /// 当不再需要显示特效时，你可以调用此方法来停止喷血粒子效果。
    /// </summary>
    public void StopDamageEffect()
    {
        // 停止粒子系统
        damageEffect.Stop();
    }
}
