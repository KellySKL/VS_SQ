﻿//=============================================
//           马克岚岚
//           12443056
//        数据表转实体类
//=============================================
using System; 
using System.Collections.Generic;
 
namespace makelanlan
{

public class scue_user {
public BLL.数据库  数据库;
public WBLL<scue_user> wBLL= new WBLL<scue_user>();
public WBLL sBLL= new WBLL();
private List<string> UpName = new List<string>();private List<string> UpValue = new List<string>();

private Int32 _ID;
public Int32 ID {get { return _ID; } set { _ID=value; UpName.Add("ID"); UpValue.Add(value.ToString()); }}
private String _CODE;
public String CODE {get { return _CODE; } set { _CODE=value; UpName.Add("CODE"); UpValue.Add(value.ToString()); }}
private String _USERPU;
public String USERPU {get { return _USERPU; } set { _USERPU=value; UpName.Add("USERPU"); UpValue.Add(value.ToString()); }}
private String _DATE;
public String DATE {get { return _DATE; } set { _DATE=value; UpName.Add("DATE"); UpValue.Add(value.ToString()); }}
private String _TURENAME;
public String TURENAME {get { return _TURENAME; } set { _TURENAME=value; UpName.Add("TURENAME"); UpValue.Add(value.ToString()); }}
private String _DEPT;
public String DEPT {get { return _DEPT; } set { _DEPT=value; UpName.Add("DEPT"); UpValue.Add(value.ToString()); }}
private String _MASTERNAME;
public String MASTERNAME {get { return _MASTERNAME; } set { _MASTERNAME=value; UpName.Add("MASTERNAME"); UpValue.Add(value.ToString()); }}
private String _CREATEDATE;
public String CREATEDATE {get { return _CREATEDATE; } set { _CREATEDATE=value; UpName.Add("CREATEDATE"); UpValue.Add(value.ToString()); }}
private String _DEFAULTUI;
public String DEFAULTUI {get { return _DEFAULTUI; } set { _DEFAULTUI=value; UpName.Add("DEFAULTUI"); UpValue.Add(value.ToString()); }}
private String _MAXVALUE;
public String MAXVALUE {get { return _MAXVALUE; } set { _MAXVALUE=value; UpName.Add("MAXVALUE"); UpValue.Add(value.ToString()); }}
private String _CANREADEDBYINTRODUCER;
public String CANREADEDBYINTRODUCER {get { return _CANREADEDBYINTRODUCER; } set { _CANREADEDBYINTRODUCER=value; UpName.Add("CANREADEDBYINTRODUCER"); UpValue.Add(value.ToString()); }}
private String _ISSTOP;
public String ISSTOP {get { return _ISSTOP; } set { _ISSTOP=value; UpName.Add("ISSTOP"); UpValue.Add(value.ToString()); }}
private String _POINTS;
public String POINTS {get { return _POINTS; } set { _POINTS=value; UpName.Add("POINTS"); UpValue.Add(value.ToString()); }}
private String _OPERATETIME;
public String OPERATETIME {get { return _OPERATETIME; } set { _OPERATETIME=value; UpName.Add("OPERATETIME"); UpValue.Add(value.ToString()); }}

public void _scue_user(){

}
public void Reset_scue_user(){
UpName.Clear();
 UpValue.Clear();
 
}
 public List<object> SelectObject(string where = null, string Byname = " * "){
string sql = "select " + Byname + " from scue_user where 1=1 " + where;
return BLL.SqlToObj(数据库, sql);
}
 public List<scue_user> Select(string where = null, string Byname = " * "){
string sql = "select " + Byname + " from scue_user where 1=1 " + where;
return BLL.SqlToList<scue_user>(数据库, sql);
}
 public void  SelectDoWork(string where = null, string Byname = " * "){
string sql = "select " + Byname + " from scue_user where 1=1 " + where;
wBLL.Start(数据库, sql);
}
public void Insert(){
_scue_user();
string sql=" insert into  scue_user (CODE,USERPU,DATE,TURENAME,DEPT,MASTERNAME,CREATEDATE,DEFAULTUI,MAXVALUE,CANREADEDBYINTRODUCER,ISSTOP,POINTS,OPERATETIME)VALUES('" +CODE+"','" +USERPU+"','" +DATE+"','" +TURENAME+"','" +DEPT+"','" +MASTERNAME+"','" +CREATEDATE+"','" +DEFAULTUI+"','" +MAXVALUE+"','" +CANREADEDBYINTRODUCER+"','" +ISSTOP+"','" +POINTS+"','" +OPERATETIME+"')";
BLL.SetToSql(数据库, sql);
}public void InsertDoWork(){
_scue_user();
string sql=" insert into  scue_user (CODE,USERPU,DATE,TURENAME,DEPT,MASTERNAME,CREATEDATE,DEFAULTUI,MAXVALUE,CANREADEDBYINTRODUCER,ISSTOP,POINTS,OPERATETIME)VALUES('" +CODE+"','" +USERPU+"','" +DATE+"','" +TURENAME+"','" +DEPT+"','" +MASTERNAME+"','" +CREATEDATE+"','" +DEFAULTUI+"','" +MAXVALUE+"','" +CANREADEDBYINTRODUCER+"','" +ISSTOP+"','" +POINTS+"','" +OPERATETIME+"')";
sBLL.Start(数据库, sql);
}public void Updata(string where){
string sql=" UPDATE scue_user SET ";
 for (int i = 0; i < UpName.Count; i++){
sql += UpName[i] + "=";
sql += "'" + UpValue[i] + "'" ;
if (i != (UpName.Count-1)) sql += ",";
}
sql += " where 1=1 " + where;
BLL.SetToSql(数据库, sql);
}
public void UpdataDoWork(string where){
string sql=" UPDATE scue_user SET ";
 for (int i = 0; i < UpName.Count; i++){
sql += UpName[i] + "=";
sql += "'" + UpValue[i] + "'" ;
if (i != (UpName.Count-1)) sql += ",";
}
sql += " where 1=1 " + where;
sBLL.Start(数据库, sql);
}

}



}

