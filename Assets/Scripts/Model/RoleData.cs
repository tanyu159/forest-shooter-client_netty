﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleData  {
    private RoleColor _roleColor;
    private GameObject _rolePrefab;
    private GameObject _arrowPrefab;
    
    public RoleColor RoleColor
    {
        get
        {
            return _roleColor;
        }

      
    }
    public GameObject RolePrefab
    {
        get
        {
            return _rolePrefab;
        }

       
    }
    public GameObject ArrowPrefab
    {
        get
        {
            return _arrowPrefab;
        }

       
    }
    
    /// <summary>
    /// 角色数据模型
    /// </summary>
    /// <param name="roleType">角色类型</param>
    /// <param name="rolePrefabPath">角色预制体路径</param>
    /// <param name="arrowPrefabPath">该角色箭的预制体路径</param>
    /// <param name="effectPrefab">该角色箭的命中特效预制体路径</param>
    public RoleData(RoleColor roleColor, string rolePrefabPath, string arrowPrefabPath)
    {
        _roleColor = roleColor;
        _rolePrefab = Resources.Load(rolePrefabPath) as GameObject;
        _arrowPrefab = Resources.Load(arrowPrefabPath) as GameObject;
        
    }
}
