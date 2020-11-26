using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEditor;
using UnityEngine;
public static class PackageEditor{
    private static string targetPackage;
    private static AddRequest request;
    private static EmbedRequest eRequest;
    private static ListRequest LRequest;
    [MenuItem("Window/Add Packages")]
    public static void Add(){
        request = Client.Add("com.unity.textmeshpro");
        EditorApplication.update += AddProgress;
    }
    [MenuItem("Window/List Package")]
    public static void List(){
        LRequest = Client.List();
        EditorApplication.update += ListProgress;
    }
    [MenuItem("Window/Embed Package")]
    public static void GetPackageName(){
        LRequest = Client.List();
        EditorApplication.update += LProgress;
    }
    private static void AddProgress(){
        if(request.IsCompleted){
            if(request.Status == StatusCode.Success){
                Debug.Log("Installed: "+request.Result.packageId);
            }else if(request.Status >= StatusCode.Failure){
                Debug.Log(request.Error.message);
            }
            EditorApplication.update -= AddProgress;
        }
    }
    private static void ListProgress(){
        if(LRequest.IsCompleted){
            if(LRequest.Status == StatusCode.Success){
                foreach(var package in LRequest.Result){
                    Debug.Log("Package name: "+package.name);
                }
            }else if(LRequest.Status >= StatusCode.Failure){
                Debug.Log(LRequest.Error.message);
            }
            EditorApplication.update -= ListProgress;
        }
    }
    private static void LProgress(){
        if(LRequest.IsCompleted){
            if(LRequest.Status == StatusCode.Success){
                foreach(var package in LRequest.Result){
                    if(package.isDirectDependency && package.source
                       != PackageSource.BuiltIn && package.source
                       != PackageSource.Embedded){
                           targetPackage = package.name;
                           break;
                       }
                }
            }else{
                Debug.Log(LRequest.Error.message);
            }
            EditorApplication.update -= LProgress;
            Embed(targetPackage);
        }
    }
    private static void Embed(string inTarget){
        Debug.Log("Embed('"+inTarget+"') called");
        eRequest = Client.Embed(inTarget);
        EditorApplication.update += Progress;
    }
    private static void Progress(){
        if(eRequest.IsCompleted){
            if(eRequest.Status == StatusCode.Success){
                Debug.Log("Embeded: "+eRequest.Result.packageId);
            }else if(eRequest.Status >= StatusCode.Failure){
                Debug.Log(eRequest.Error.message);
            }
            EditorApplication.update -= Progress;
        }
    }
}