Imports SyERP.DAL
Public Class 客户对帐单Base
    Function Get客户应收款By业务主管(ByVal date1 As Date, ByVal date2 As Date, ByVal where As String) As DataTable
        Dim dt As DataTable
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            dt = c.GetDataSetBySQL(" select client as 客户名称,BillMan as 业务员,max(freestr1) as 办事处,(select top 1 办事处 from puku where puku.turename=BillMan) as 业务员所在办事处,(select top 1 区域 from puku where puku.办事处=max(freestr1)) as 大区,(select top 1 区域 from puku where puku.turename=BillMan) as 业务员所在大区," +
                              "(select isnull(sum(AMOUNT),0) as amount from  SALEScukuKu a where  billdate<'" + date1 + "' and left(code,1)<>'*' and a.client=b.client and a.BillMan=b.BillMan) as 期初销售," +
                              "(select isnull(sum(AMOUNT),0) from shoujiaidangKu   where PayedDate< '" + date1 + "' and left(code,1)<>'*'  and shoujiaidangKu.name=Client and shoujiaidangKu.BillMan=b.BillMan)as 期初收款," +
                              "(select isnull(sum(AMOUNT),0) from chuna_RukuKu   where billDate< '" + date1 + "' and left(code,1)<>'*'  and chuna_RukuKu.client=b.Client and chuna_RukuKu.BillMan=b.BillMan)as 帐务调整," +
                              "(select isnull(sum(AMOUNT),0) as amount from  SALEScukuKu a where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*' and a.client=b.client and  a.BillMan=b.BillMan)-(select (case when sum(金额) is null then 0 else sum(金额) end) from  salescukuku业绩划分 a where  a.billdate>='" + date1 + "' and a.billdate<='" + date2 + "'  and a.client=b.client and  a.ToBillman=b.BillMan)-(select (case when sum(金额) is null then 0 else sum(金额) end)  from  salescukuku业绩划分 a where  a.billdate>='" + date1 + "' and a.billdate<='" + date2 + "'  and a.client=b.client and  a.FromBillman=b.BillMan and a.billtype='销售')+(select (case when sum(金额) is null then 0 else sum(金额) end)  from  salescukuku业绩划分 a where  a.billdate>='" + date1 + "' and a.billdate<='" + date2 + "'  and a.client=b.client and  a.toBillman=b.BillMan and a.billtype='销售') as 本期销售," +
                              "(select isnull(sum(AMOUNT),0) as amount from  SALEScukuKu a where  left(code,1)<>'*' and materialname='期初录入' and a.client=b.client and a.BillMan=b.BillMan  )  as 年度期初," +
  "(select isnull(sum(AMOUNT),0) as amount from  SALEScukuKu a where  left(code,1)<>'*' and materialname<>'期初录入'  and a.client=b.client and a.BillMan=b.BillMan  and billdate<='" + date2 + "'  )-(select (case when sum(金额) is null then 0 else sum(金额) end) from  salescukuku业绩划分 a where    billdate<='" + date2 + "'   and a.client=b.client and  a.FromBillman=b.BillMan and a.billtype='销售')  as 年度累计销售," +
                              "(select isnull(sum(AMOUNT),0) from shoujiaidangKu   where  PayedDate>='" + date1 + "' and PayedDate<= '" + date2 + "'  and left(code,1)<>'*'  and shoujiaidangKu.name=Client  and shoujiaidangKu.BillMan=b.BillMan)-(select (case when sum(金额) is null then 0 else sum(金额) end) from  salescukuku业绩划分 a where  a.billdate>='" + date1 + "' and a.billdate<='" + date2 + "'  and a.client=b.client and  a.ToBillman=b.BillMan)-(select (case when sum(金额) is null then 0 else sum(金额) end)  from  salescukuku业绩划分 a where  a.billdate>='" + date1 + "' and a.billdate<='" + date2 + "'  and a.client=b.client and  a.FromBillman=b.BillMan and a.billtype='回款' )+(select (case when sum(金额) is null then 0 else sum(金额) end)  from  salescukuku业绩划分 a where  a.billdate>='" + date1 + "' and a.billdate<='" + date2 + "'  and a.client=b.client and  a.TOBillman=b.BillMan and a.billtype='回款' ) as 本期收款," +
                              "(select isnull(sum(AMOUNT),0) from shoujiaidangKu   where    left(code,1)<>'*'  and shoujiaidangKu.name=Client and shoujiaidangKu.BillMan=b.BillMan and shoujiaidangKu.PayedDate<='" + date2 + "' )-(select (case when sum(金额) is null then 0 else sum(金额) end) from  salescukuku业绩划分 a where   a.billdate<='" + date2 + "'  and a.client=b.client and  a.FromBillman=b.BillMan and a.billtype='回款' ) as 年度累计收款," +
                              "(select sum(运费) from salescukuku运费 where code in (select code  from  SALEScukuKu a where  left(code,1)<>'*' and a.client=b.client and  a.BillMan=b.BillMan)) as 我方累计运费,(select sum(运费) from salescukuku运费 where code in (select code  from  SALEScukuKu a where  billdate>='" + date1 + "' and billdate<='" + date2 + "' and left(code,1)<>'*' and a.client=b.client and  a.BillMan=b.BillMan)) as 我方本期运费," +
                              "(select isnull(sum(amount),0) from billnouse10 a where left(code,1)<>'*' and a.client=b.client)-(select isnull(sum(AMOUNT),0) from shoujiaidangKu   where    left(code,1)<>'*'  and shoujiaidangKu.name=Client ) as 已开票欠款 " +
                              "  into #temp  from SALEScukuKu  b where 1=1 " & where & " group by Client,BillMan " +
                              " select row_number() over (order by 客户名称) as 序号,*  from #temp   " +
                              " drop table #temp ").Tables(0)
        End Using
        dt.Columns.Add("期初余额", System.Type.GetType("System.Decimal"), "isnull(期初销售,0)-isnull(期初收款,0)")
        dt.Columns.Add("期末余额", System.Type.GetType("System.Decimal"), "isnull(期初余额,0)+isnull(本期销售,0)-isnull(本期收款,0)")
        Dim dv As DataView = dt.DefaultView
        dv.Sort = "期初余额 DESC"
        dt = dv.ToTable
        Dim dr As DataRow = dt.NewRow
        dr("客户名称") = "合计"
        dr("期初余额") = dt.Compute("sum(期初余额)", "")
        dr("期初销售") = dt.Compute("sum(期初销售)", "")
        dr("本期销售") = dt.Compute("sum(本期销售)", "")
        dr("我方本期运费") = dt.Compute("sum(我方本期运费)", "")
        dr("年度累计销售") = dt.Compute("sum(年度累计销售)", "")
        dr("本期收款") = dt.Compute("sum(本期收款)", "")
        dr("年度期初") = dt.Compute("sum(年度期初)", "")
        dr("帐务调整") = dt.Compute("sum(帐务调整)", "")
        dr("年度累计收款") = dt.Compute("sum(年度累计收款)", "")
        dr("我方累计运费") = dt.Compute("sum(我方累计运费)", "")
        dr("已开票欠款") = dt.Compute("sum(已开票欠款)", "")
        dr("期末余额") = dt.Compute("sum(期末余额)", "")
        dt.Rows.Add(dr)
        Return dt
    End Function

    Function get业务主管(ByVal 业务员 As String) As ArrayList
        Dim arr As ArrayList
        Using c As New SQLServer(SqlStr.ConnStringBuilder.ConnectionString)
            arr = c.GetArraylistBySQL("select distinct isnull(billman,'') from salescukuku ")
        End Using
        Return arr
    End Function
End Class
