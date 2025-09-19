using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneControlMono : MonoBehaviour                                       //������ʾ���ϲ�ͬ�㼶��Ӧ����Scene�Ĵ򿪹ر�
{
    [Header("Control Scene")]
    [SerializeField] private SceneField Monitor;
    [SerializeField] private SceneField Blog;
    [SerializeField] private SceneField DistributePanal;
    [SerializeField] private SceneField DataSubscene;

    public bool test;
    void Start()
    {
        test = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!test)
        {
            SceneManager.LoadSceneAsync(Blog, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(Blog);
            test = true;
        }
    }
    public void LoadBlogScene()
    {
        SceneManager.LoadSceneAsync(Blog, LoadSceneMode.Additive);
    }
}