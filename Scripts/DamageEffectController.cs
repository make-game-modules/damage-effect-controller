using UnityEngine;
/// <summary>
/// DamageEffectController ����һ��������Ч�����������ڹ����ɫ����ʱ������Ч����
/// �����ṩ��������������������ɫ����ʱ�����Ե��� "TriggerDamageEffect" ����������Ч��������Ҫ������Чʱ�����Ե��� "StopDamageEffect" ����ֹͣ��Ч��
/// ����Խ��˽ű����ص��κν�ɫ�����ϣ��Ա��ڽ�ɫ����ʱ�Զ�������Ч��
/// </summary>
public class DamageEffectController : MonoBehaviour
{
    // �ñ����洢����ϵͳ���������
    public ParticleSystem damageEffect;

    /// <summary>
    /// Awake �����ڶ���ʵ����ʱ�� Unity �Զ����ã����ڳ�ʼ���ű���
    /// �ڴ˺����У����ǻ�ȡ���洢����ϵͳ��������á�
    /// </summary>
    private void Awake()
    {
        damageEffect = GetComponentInChildren<ParticleSystem>();
    }

    /// <summary>
    /// TriggerDamageEffect ��һ���������������ڴ���������Ч��
    /// ����ɫ����ʱ������Ե��ô˷�����������Ѫ����Ч����
    /// </summary>
    public void TriggerDamageEffect()
    {
        // ���ȣ�ȷ������ϵͳ���ڷ�����״̬
        if (damageEffect.isPlaying)
        {
            return;
        }

        Debug.Log("TriggerDamageEffect");

        // Ȼ����������ϵͳ
        damageEffect.Play();
    }

    /// <summary>
    /// StopDamageEffect ��һ����������������ֹͣ������Ч��
    /// ��������Ҫ��ʾ��Чʱ������Ե��ô˷�����ֹͣ��Ѫ����Ч����
    /// </summary>
    public void StopDamageEffect()
    {
        // ֹͣ����ϵͳ
        damageEffect.Stop();
    }
}
