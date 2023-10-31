using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Formats.Alembic.Importer;

public class AlembicPlayController : MonoBehaviour
{
    public AlembicStreamPlayer streamPlayer;                   //AlembicStream �÷��̾� ��������
   
    void Start()
    {
        Application.targetFrameRate = 60;                       //FPS ����
        QualitySettings.vSyncCount = 0;                         //vSync �ɼ� ���� (0 ��Ȱ��ȭ, 1 Ȱ��ȭ <�⺻��> ,2 ���� ���۸�)

        streamPlayer = GetComponent<AlembicStreamPlayer>();     //AlembicStreamPlayer ���۳�Ʈ ����
    }
    
    void FixedUpdate()
    {
        streamPlayer.CurrentTime += Time.deltaTime;             //������ �ð� ����
    }
}
