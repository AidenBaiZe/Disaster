using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneControlMono : MonoBehaviour                                       //������ʾ���ϲ�ͬ�㼶��Ӧ����Scene�Ĵ򿪹ر�
{
    [Header("Control Scene")]
    [SerializeField] private SceneField Monitor;
    [SerializeField] private SceneField BlogScene;
    [SerializeField] private SceneField DistributePanal;
    [SerializeField] private SceneField DeskScene;

    public bool test;
    void Start()
    {
        SceneManager.LoadSceneAsync(DeskScene, LoadSceneMode.Additive);
        test = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!test)
        {
            SceneManager.LoadSceneAsync(BlogScene, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(BlogScene);
            test = true;
        }
    }
    public void LoadBlogScene()
    {
        SceneManager.LoadSceneAsync(BlogScene, LoadSceneMode.Additive);
    }
    
    public void UnloadBlogScene()
    {
        SceneManager.UnloadSceneAsync(BlogScene);
    }
    public void UnloadDeskScene()
    {
        SceneManager.UnloadSceneAsync(DeskScene);
    }
    public void loadDeskScene()
    {
        SceneManager.LoadSceneAsync(DeskScene, LoadSceneMode.Additive);
    }
}