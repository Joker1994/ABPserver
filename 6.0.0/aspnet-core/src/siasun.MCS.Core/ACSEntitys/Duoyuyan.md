

# 配置52ABP-PRO的多语言
 
 
**请注意：**
- 从52ABP-PRO 2.5.0的版本开始默认采用json配置多语言
- 属性名和字段不能重复否则框架会验证失败，需要你删除重复的键名

## Json的配置方法如下

在MCS.Core类库中，找到路径为 Localization->SourceFiles->Json文件夹下的对应文件

### 中文本地化的内容Chinese localized content

找到Json文件夹下的MCS-zh-Hans.json文件，复制以下代码进入即可。

> 请注意防止键名重复，产生异常

```json
                    //的多语言配置==>中文
"C_ID": "C_ID",
"C_LogTime": "C_LogTime",
"C_ErrorCode": "C_ErrorCode",
"C_DeviceID": "C_DeviceID",
"C_DeviceType": "C_DeviceType",
"C_DeviceDesc": "C_DeviceDesc",
"C_Type": "C_Type",
"C_Reason": "C_Reason",
"C_Measure": "C_Measure",
"C_RestoreTime": "C_RestoreTime",
"C_TimeStamp": "C_TimeStamp",
"C_Sw01": "C_Sw01",
"C_Sw02": "C_Sw02",
"C_Sw03": "C_Sw03",
"C_Sw04": "C_Sw04",
"C_Sw05": "C_Sw05",
					                     
                    "TB_AlarmLogEntity": "",
                    "ManageTB_AlarmLogEntity": "管理",
                    "QueryTB_AlarmLogEntity": "查询",
                    "CreateTB_AlarmLogEntity": "添加",
                    "EditTB_AlarmLogEntity": "编辑",
                    "DeleteTB_AlarmLogEntity": "删除",
                    "BatchDeleteTB_AlarmLogEntity": "批量删除",
                    "ExportTB_AlarmLogEntity": "导出",
                    "TB_AlarmLogEntityList": "列表",
                     //的多语言配置==End
                    


```


### 英语本地化的内容English localized content
找到Json文件夹下的MCS.json文件，复制以下代码进入即可。
```json
             //的多语言配置==>英文
"C_ID": "C_ID",
"C_LogTime": "C_LogTime",
"C_ErrorCode": "C_ErrorCode",
"C_DeviceID": "C_DeviceID",
"C_DeviceType": "C_DeviceType",
"C_DeviceDesc": "C_DeviceDesc",
"C_Type": "C_Type",
"C_Reason": "C_Reason",
"C_Measure": "C_Measure",
"C_RestoreTime": "C_RestoreTime",
"C_TimeStamp": "C_TimeStamp",
"C_Sw01": "C_Sw01",
"C_Sw02": "C_Sw02",
"C_Sw03": "C_Sw03",
"C_Sw04": "C_Sw04",
"C_Sw05": "C_Sw05",
					                     
                    "TB_AlarmLogEntity": "TB_AlarmLogEntity",
                    "ManageTB_AlarmLogEntity": "ManageTB_AlarmLogEntity",
                    "QueryTB_AlarmLogEntity": "QueryTB_AlarmLogEntity",
                    "CreateTB_AlarmLogEntity": "CreateTB_AlarmLogEntity",
                    "EditTB_AlarmLogEntity": "EditTB_AlarmLogEntity",
                    "DeleteTB_AlarmLogEntity": "DeleteTB_AlarmLogEntity",
                    "BatchDeleteTB_AlarmLogEntity": "BatchDeleteTB_AlarmLogEntity",
                    "ExportTB_AlarmLogEntity": "ExportTB_AlarmLogEntity",
                    "TB_AlarmLogEntityList": "TB_AlarmLogEntityList",
                     //的多语言配置==End
                    




```