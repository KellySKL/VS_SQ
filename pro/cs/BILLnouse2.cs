//=============================================
//           马克岚岚
//           12443056
//        数据表转实体类
//=============================================
using System; 
using System.Collections.Generic;
 
namespace makelanlan
{

public class BILLnouse2 {
public BLL.数据库  数据库;
public WBLL<BILLnouse2> wBLL= new WBLL<BILLnouse2>();
public WBLL sBLL= new WBLL();
private List<string> UpName = new List<string>();private List<string> UpValue = new List<string>();

private Int32 _ID;
public Int32 ID {get { return _ID; } set { _ID=value; UpName.Add("ID"); UpValue.Add(value.ToString()); }}
private String _CODE;
public String CODE {get { return _CODE; } set { _CODE=value; UpName.Add("CODE"); UpValue.Add(value.ToString()); }}
private String _BILLTYPE;
public String BILLTYPE {get { return _BILLTYPE; } set { _BILLTYPE=value; UpName.Add("BILLTYPE"); UpValue.Add(value.ToString()); }}
private System.DateTime _BILLDATE;
public System.DateTime BILLDATE {get { return _BILLDATE; } set { _BILLDATE=value; UpName.Add("BILLDATE"); UpValue.Add(value.ToString()); }}
private String _CLIENT;
public String CLIENT {get { return _CLIENT; } set { _CLIENT=value; UpName.Add("CLIENT"); UpValue.Add(value.ToString()); }}
private String _TAXTYPE;
public String TAXTYPE {get { return _TAXTYPE; } set { _TAXTYPE=value; UpName.Add("TAXTYPE"); UpValue.Add(value.ToString()); }}
private System.Decimal _TAXRATE;
public System.Decimal TAXRATE {get { return _TAXRATE; } set { _TAXRATE=value; UpName.Add("TAXRATE"); UpValue.Add(value.ToString()); }}
private String _PAYTYPE;
public String PAYTYPE {get { return _PAYTYPE; } set { _PAYTYPE=value; UpName.Add("PAYTYPE"); UpValue.Add(value.ToString()); }}
private String _BILLMAN;
public String BILLMAN {get { return _BILLMAN; } set { _BILLMAN=value; UpName.Add("BILLMAN"); UpValue.Add(value.ToString()); }}
private String _AUDITING;
public String AUDITING {get { return _AUDITING; } set { _AUDITING=value; UpName.Add("AUDITING"); UpValue.Add(value.ToString()); }}
private String _INTRODUCER;
public String INTRODUCER {get { return _INTRODUCER; } set { _INTRODUCER=value; UpName.Add("INTRODUCER"); UpValue.Add(value.ToString()); }}
private System.DateTime _INTRODUCERDATE;
public System.DateTime INTRODUCERDATE {get { return _INTRODUCERDATE; } set { _INTRODUCERDATE=value; UpName.Add("INTRODUCERDATE"); UpValue.Add(value.ToString()); }}
private System.DateTime _FINISHDATE;
public System.DateTime FINISHDATE {get { return _FINISHDATE; } set { _FINISHDATE=value; UpName.Add("FINISHDATE"); UpValue.Add(value.ToString()); }}
private String _BILLNOTE;
public String BILLNOTE {get { return _BILLNOTE; } set { _BILLNOTE=value; UpName.Add("BILLNOTE"); UpValue.Add(value.ToString()); }}
private String _STORAGENAME;
public String STORAGENAME {get { return _STORAGENAME; } set { _STORAGENAME=value; UpName.Add("STORAGENAME"); UpValue.Add(value.ToString()); }}
private String _MATERIALCODE;
public String MATERIALCODE {get { return _MATERIALCODE; } set { _MATERIALCODE=value; UpName.Add("MATERIALCODE"); UpValue.Add(value.ToString()); }}
private String _MATERIALNAME;
public String MATERIALNAME {get { return _MATERIALNAME; } set { _MATERIALNAME=value; UpName.Add("MATERIALNAME"); UpValue.Add(value.ToString()); }}
private String _SPECS;
public String SPECS {get { return _SPECS; } set { _SPECS=value; UpName.Add("SPECS"); UpValue.Add(value.ToString()); }}
private String _STORAGEWHERE;
public String STORAGEWHERE {get { return _STORAGEWHERE; } set { _STORAGEWHERE=value; UpName.Add("STORAGEWHERE"); UpValue.Add(value.ToString()); }}
private String _UNITNAME;
public String UNITNAME {get { return _UNITNAME; } set { _UNITNAME=value; UpName.Add("UNITNAME"); UpValue.Add(value.ToString()); }}
private System.Decimal _QUANTITY;
public System.Decimal QUANTITY {get { return _QUANTITY; } set { _QUANTITY=value; UpName.Add("QUANTITY"); UpValue.Add(value.ToString()); }}
private System.Decimal _ORIGPRICE;
public System.Decimal ORIGPRICE {get { return _ORIGPRICE; } set { _ORIGPRICE=value; UpName.Add("ORIGPRICE"); UpValue.Add(value.ToString()); }}
private System.Decimal _PRICE;
public System.Decimal PRICE {get { return _PRICE; } set { _PRICE=value; UpName.Add("PRICE"); UpValue.Add(value.ToString()); }}
private System.Decimal _AMOUNT;
public System.Decimal AMOUNT {get { return _AMOUNT; } set { _AMOUNT=value; UpName.Add("AMOUNT"); UpValue.Add(value.ToString()); }}
private System.Decimal _KILLBILLQTY;
public System.Decimal KILLBILLQTY {get { return _KILLBILLQTY; } set { _KILLBILLQTY=value; UpName.Add("KILLBILLQTY"); UpValue.Add(value.ToString()); }}
private System.Decimal _REFERQTY;
public System.Decimal REFERQTY {get { return _REFERQTY; } set { _REFERQTY=value; UpName.Add("REFERQTY"); UpValue.Add(value.ToString()); }}
private System.Decimal _PAYEDAMOUNT;
public System.Decimal PAYEDAMOUNT {get { return _PAYEDAMOUNT; } set { _PAYEDAMOUNT=value; UpName.Add("PAYEDAMOUNT"); UpValue.Add(value.ToString()); }}
private String _REMARK;
public String REMARK {get { return _REMARK; } set { _REMARK=value; UpName.Add("REMARK"); UpValue.Add(value.ToString()); }}
private String _BATCHNUMBER;
public String BATCHNUMBER {get { return _BATCHNUMBER; } set { _BATCHNUMBER=value; UpName.Add("BATCHNUMBER"); UpValue.Add(value.ToString()); }}
private String _REFERCODE;
public String REFERCODE {get { return _REFERCODE; } set { _REFERCODE=value; UpName.Add("REFERCODE"); UpValue.Add(value.ToString()); }}
private System.Decimal _DISCOUNT;
public System.Decimal DISCOUNT {get { return _DISCOUNT; } set { _DISCOUNT=value; UpName.Add("DISCOUNT"); UpValue.Add(value.ToString()); }}
private System.Decimal _BOXES;
public System.Decimal BOXES {get { return _BOXES; } set { _BOXES=value; UpName.Add("BOXES"); UpValue.Add(value.ToString()); }}
private String _GUSERDEF1;
public String GUSERDEF1 {get { return _GUSERDEF1; } set { _GUSERDEF1=value; UpName.Add("GUSERDEF1"); UpValue.Add(value.ToString()); }}
private String _GUSERDEF2;
public String GUSERDEF2 {get { return _GUSERDEF2; } set { _GUSERDEF2=value; UpName.Add("GUSERDEF2"); UpValue.Add(value.ToString()); }}
private String _GUSERDEF3;
public String GUSERDEF3 {get { return _GUSERDEF3; } set { _GUSERDEF3=value; UpName.Add("GUSERDEF3"); UpValue.Add(value.ToString()); }}
private String _GUSERDEF4;
public String GUSERDEF4 {get { return _GUSERDEF4; } set { _GUSERDEF4=value; UpName.Add("GUSERDEF4"); UpValue.Add(value.ToString()); }}
private String _GUSERDEF5;
public String GUSERDEF5 {get { return _GUSERDEF5; } set { _GUSERDEF5=value; UpName.Add("GUSERDEF5"); UpValue.Add(value.ToString()); }}
private String _MAXVALUE;
public String MAXVALUE {get { return _MAXVALUE; } set { _MAXVALUE=value; UpName.Add("MAXVALUE"); UpValue.Add(value.ToString()); }}
private String _FREESTR1;
public String FREESTR1 {get { return _FREESTR1; } set { _FREESTR1=value; UpName.Add("FREESTR1"); UpValue.Add(value.ToString()); }}
private String _FREESTR2;
public String FREESTR2 {get { return _FREESTR2; } set { _FREESTR2=value; UpName.Add("FREESTR2"); UpValue.Add(value.ToString()); }}
private String _FREESTR3;
public String FREESTR3 {get { return _FREESTR3; } set { _FREESTR3=value; UpName.Add("FREESTR3"); UpValue.Add(value.ToString()); }}
private String _FREESTR4;
public String FREESTR4 {get { return _FREESTR4; } set { _FREESTR4=value; UpName.Add("FREESTR4"); UpValue.Add(value.ToString()); }}
private String _FREESTR5;
public String FREESTR5 {get { return _FREESTR5; } set { _FREESTR5=value; UpName.Add("FREESTR5"); UpValue.Add(value.ToString()); }}
private String _FREESTR6;
public String FREESTR6 {get { return _FREESTR6; } set { _FREESTR6=value; UpName.Add("FREESTR6"); UpValue.Add(value.ToString()); }}
private String _FREESTR7;
public String FREESTR7 {get { return _FREESTR7; } set { _FREESTR7=value; UpName.Add("FREESTR7"); UpValue.Add(value.ToString()); }}
private String _FREESTR8;
public String FREESTR8 {get { return _FREESTR8; } set { _FREESTR8=value; UpName.Add("FREESTR8"); UpValue.Add(value.ToString()); }}
private String _FREESTR9;
public String FREESTR9 {get { return _FREESTR9; } set { _FREESTR9=value; UpName.Add("FREESTR9"); UpValue.Add(value.ToString()); }}
private String _FREESTR10;
public String FREESTR10 {get { return _FREESTR10; } set { _FREESTR10=value; UpName.Add("FREESTR10"); UpValue.Add(value.ToString()); }}
private System.DateTime _FREEDTE1;
public System.DateTime FREEDTE1 {get { return _FREEDTE1; } set { _FREEDTE1=value; UpName.Add("FREEDTE1"); UpValue.Add(value.ToString()); }}
private System.DateTime _FREEDTE2;
public System.DateTime FREEDTE2 {get { return _FREEDTE2; } set { _FREEDTE2=value; UpName.Add("FREEDTE2"); UpValue.Add(value.ToString()); }}
private System.DateTime _FREEDTE3;
public System.DateTime FREEDTE3 {get { return _FREEDTE3; } set { _FREEDTE3=value; UpName.Add("FREEDTE3"); UpValue.Add(value.ToString()); }}
private System.DateTime _FREEDTE4;
public System.DateTime FREEDTE4 {get { return _FREEDTE4; } set { _FREEDTE4=value; UpName.Add("FREEDTE4"); UpValue.Add(value.ToString()); }}
private System.DateTime _FREEDTE5;
public System.DateTime FREEDTE5 {get { return _FREEDTE5; } set { _FREEDTE5=value; UpName.Add("FREEDTE5"); UpValue.Add(value.ToString()); }}
private System.Decimal _FREENUM1;
public System.Decimal FREENUM1 {get { return _FREENUM1; } set { _FREENUM1=value; UpName.Add("FREENUM1"); UpValue.Add(value.ToString()); }}
private System.Decimal _FREENUM2;
public System.Decimal FREENUM2 {get { return _FREENUM2; } set { _FREENUM2=value; UpName.Add("FREENUM2"); UpValue.Add(value.ToString()); }}
private System.Decimal _FREENUM3;
public System.Decimal FREENUM3 {get { return _FREENUM3; } set { _FREENUM3=value; UpName.Add("FREENUM3"); UpValue.Add(value.ToString()); }}
private System.Decimal _FREENUM4;
public System.Decimal FREENUM4 {get { return _FREENUM4; } set { _FREENUM4=value; UpName.Add("FREENUM4"); UpValue.Add(value.ToString()); }}
private System.Decimal _FREENUM5;
public System.Decimal FREENUM5 {get { return _FREENUM5; } set { _FREENUM5=value; UpName.Add("FREENUM5"); UpValue.Add(value.ToString()); }}
private String _材料损耗表批号;
public String 材料损耗表批号 {get { return _材料损耗表批号; } set { _材料损耗表批号=value; UpName.Add("材料损耗表批号"); UpValue.Add(value.ToString()); }}
private String _引用单号2;
public String 引用单号2 {get { return _引用单号2; } set { _引用单号2=value; UpName.Add("引用单号2"); UpValue.Add(value.ToString()); }}

public void _BILLnouse2(){
BILLDATE=BILLDATE==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :BILLDATE ;
INTRODUCERDATE=INTRODUCERDATE==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :INTRODUCERDATE ;
FINISHDATE=FINISHDATE==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :FINISHDATE ;
FREEDTE1=FREEDTE1==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :FREEDTE1 ;
FREEDTE2=FREEDTE2==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :FREEDTE2 ;
FREEDTE3=FREEDTE3==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :FREEDTE3 ;
FREEDTE4=FREEDTE4==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :FREEDTE4 ;
FREEDTE5=FREEDTE5==DateTime.MinValue ? DateTime.Parse("1900 / 1 / 1 0:00:00") :FREEDTE5 ;

}
public void Reset_BILLnouse2(){
UpName.Clear();
 UpValue.Clear();
 
}
 public List<object> SelectObject(string where = null, string Byname = " * "){
string sql = "select " + Byname + " from BILLnouse2 where 1=1 " + where;
return BLL.SqlToObj(数据库, sql);
}
 public List<BILLnouse2> Select(string where = null, string Byname = " * "){
string sql = "select " + Byname + " from BILLnouse2 where 1=1 " + where;
return BLL.SqlToList<BILLnouse2>(数据库, sql);
}
 public void  SelectDoWork(string where = null, string Byname = " * "){
string sql = "select " + Byname + " from BILLnouse2 where 1=1 " + where;
wBLL.Start(数据库, sql);
}
public void Insert(){
_BILLnouse2();
string sql=" insert into  BILLnouse2 (CODE,BILLTYPE,BILLDATE,CLIENT,TAXTYPE,TAXRATE,PAYTYPE,BILLMAN,AUDITING,INTRODUCER,INTRODUCERDATE,FINISHDATE,BILLNOTE,STORAGENAME,MATERIALCODE,MATERIALNAME,SPECS,STORAGEWHERE,UNITNAME,QUANTITY,ORIGPRICE,PRICE,AMOUNT,KILLBILLQTY,REFERQTY,PAYEDAMOUNT,REMARK,BATCHNUMBER,REFERCODE,DISCOUNT,BOXES,GUSERDEF1,GUSERDEF2,GUSERDEF3,GUSERDEF4,GUSERDEF5,MAXVALUE,FREESTR1,FREESTR2,FREESTR3,FREESTR4,FREESTR5,FREESTR6,FREESTR7,FREESTR8,FREESTR9,FREESTR10,FREEDTE1,FREEDTE2,FREEDTE3,FREEDTE4,FREEDTE5,FREENUM1,FREENUM2,FREENUM3,FREENUM4,FREENUM5,材料损耗表批号,引用单号2)VALUES('" +CODE+"','" +BILLTYPE+"','" +BILLDATE+"','" +CLIENT+"','" +TAXTYPE+"','" +TAXRATE+"','" +PAYTYPE+"','" +BILLMAN+"','" +AUDITING+"','" +INTRODUCER+"','" +INTRODUCERDATE+"','" +FINISHDATE+"','" +BILLNOTE+"','" +STORAGENAME+"','" +MATERIALCODE+"','" +MATERIALNAME+"','" +SPECS+"','" +STORAGEWHERE+"','" +UNITNAME+"','" +QUANTITY+"','" +ORIGPRICE+"','" +PRICE+"','" +AMOUNT+"','" +KILLBILLQTY+"','" +REFERQTY+"','" +PAYEDAMOUNT+"','" +REMARK+"','" +BATCHNUMBER+"','" +REFERCODE+"','" +DISCOUNT+"','" +BOXES+"','" +GUSERDEF1+"','" +GUSERDEF2+"','" +GUSERDEF3+"','" +GUSERDEF4+"','" +GUSERDEF5+"','" +MAXVALUE+"','" +FREESTR1+"','" +FREESTR2+"','" +FREESTR3+"','" +FREESTR4+"','" +FREESTR5+"','" +FREESTR6+"','" +FREESTR7+"','" +FREESTR8+"','" +FREESTR9+"','" +FREESTR10+"','" +FREEDTE1+"','" +FREEDTE2+"','" +FREEDTE3+"','" +FREEDTE4+"','" +FREEDTE5+"','" +FREENUM1+"','" +FREENUM2+"','" +FREENUM3+"','" +FREENUM4+"','" +FREENUM5+"','" +材料损耗表批号+"','" +引用单号2+"')";
BLL.SetToSql(数据库, sql);
}public void InsertDoWork(){
_BILLnouse2();
string sql=" insert into  BILLnouse2 (CODE,BILLTYPE,BILLDATE,CLIENT,TAXTYPE,TAXRATE,PAYTYPE,BILLMAN,AUDITING,INTRODUCER,INTRODUCERDATE,FINISHDATE,BILLNOTE,STORAGENAME,MATERIALCODE,MATERIALNAME,SPECS,STORAGEWHERE,UNITNAME,QUANTITY,ORIGPRICE,PRICE,AMOUNT,KILLBILLQTY,REFERQTY,PAYEDAMOUNT,REMARK,BATCHNUMBER,REFERCODE,DISCOUNT,BOXES,GUSERDEF1,GUSERDEF2,GUSERDEF3,GUSERDEF4,GUSERDEF5,MAXVALUE,FREESTR1,FREESTR2,FREESTR3,FREESTR4,FREESTR5,FREESTR6,FREESTR7,FREESTR8,FREESTR9,FREESTR10,FREEDTE1,FREEDTE2,FREEDTE3,FREEDTE4,FREEDTE5,FREENUM1,FREENUM2,FREENUM3,FREENUM4,FREENUM5,材料损耗表批号,引用单号2)VALUES('" +CODE+"','" +BILLTYPE+"','" +BILLDATE+"','" +CLIENT+"','" +TAXTYPE+"','" +TAXRATE+"','" +PAYTYPE+"','" +BILLMAN+"','" +AUDITING+"','" +INTRODUCER+"','" +INTRODUCERDATE+"','" +FINISHDATE+"','" +BILLNOTE+"','" +STORAGENAME+"','" +MATERIALCODE+"','" +MATERIALNAME+"','" +SPECS+"','" +STORAGEWHERE+"','" +UNITNAME+"','" +QUANTITY+"','" +ORIGPRICE+"','" +PRICE+"','" +AMOUNT+"','" +KILLBILLQTY+"','" +REFERQTY+"','" +PAYEDAMOUNT+"','" +REMARK+"','" +BATCHNUMBER+"','" +REFERCODE+"','" +DISCOUNT+"','" +BOXES+"','" +GUSERDEF1+"','" +GUSERDEF2+"','" +GUSERDEF3+"','" +GUSERDEF4+"','" +GUSERDEF5+"','" +MAXVALUE+"','" +FREESTR1+"','" +FREESTR2+"','" +FREESTR3+"','" +FREESTR4+"','" +FREESTR5+"','" +FREESTR6+"','" +FREESTR7+"','" +FREESTR8+"','" +FREESTR9+"','" +FREESTR10+"','" +FREEDTE1+"','" +FREEDTE2+"','" +FREEDTE3+"','" +FREEDTE4+"','" +FREEDTE5+"','" +FREENUM1+"','" +FREENUM2+"','" +FREENUM3+"','" +FREENUM4+"','" +FREENUM5+"','" +材料损耗表批号+"','" +引用单号2+"')";
sBLL.Start(数据库, sql);
}public void Updata(string where){
string sql=" UPDATE BILLnouse2 SET ";
 for (int i = 0; i < UpName.Count; i++){
sql += UpName[i] + "=";
sql += "'" + UpValue[i] + "'" ;
if (i != (UpName.Count-1)) sql += ",";
}
sql += " where 1=1 " + where;
BLL.SetToSql(数据库, sql);
}
public void UpdataDoWork(string where){
string sql=" UPDATE BILLnouse2 SET ";
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

