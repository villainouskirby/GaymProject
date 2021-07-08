using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class GemsData
{
  [SerializeField]
  short index;
  public short Index { get {return index; } set { this.index = value;} }
  
  [SerializeField]
  short cost;
  public short Cost { get {return cost; } set { this.cost = value;} }
  
  [SerializeField]
  string name;
  public string Name { get {return name; } set { this.name = value;} }
  
  [SerializeField]
  string info;
  public string Info { get {return info; } set { this.info = value;} }
  
  [SerializeField]
  bool isunlock;
  public bool Isunlock { get {return isunlock; } set { this.isunlock = value;} }
  
}