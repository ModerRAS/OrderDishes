# OrderDishes
捋需求

## 界面设计
1. 基本的用户管理
    1. 手动设定物业帐号密码
	1. 手动设定管理员帐号密码
	1. 每个人的帐号需要自行注册，使用邀请码方式注册
1. 点菜界面
    1. 有一个日期选择框
	1. 有一个早中晚饭的分界线
	1. 分界线中间有一些卡片，卡片里有图片有文字，可以点选
	1. 一个简化点菜界面，选一段日期，设定为这几天三顿饭全选
1. 订单界面，用来打饭
1. 做菜界面，用来看这顿饭每个菜要做多少
1. 提供每周菜谱界面
	1. 上传菜谱按键
	1. 下载菜谱按键，提供一个菜谱模板，将本周菜谱填入后上传。
1. 维护菜品
    1. 一个列表，列表中有每一个传过菜谱的菜名，对应菜名的图片，和替换图片的功能
1. 统计界面
    1. 统计每顿饭每个菜的选择量
	1. 统计每日流水等

## 逻辑设计
### 点菜
### 传菜谱
### 修改选菜
### 开始做菜
1. 开始做菜后本顿饭选择的菜将无法更改
## 数据库设计
使用Redis作为数据库，并且只用其中一个数据库
要做以下键值对和Set
### 食物相关
#### 基础
Guid -> 单个食物(Food)
食堂名称-食物列表 -> 食物的列表(Guid)
#### 索引
食堂名称-单个食物名称 -> Guid


### 菜单相关
#### 基础
Guid -> 菜单(Menu)
食堂名称-日期-早中晚饭 -> Guid

### 用户相关
//Guid -> 用户(User)
//用户名 -> Guid
#### 基础
用户列表 -> 用户列表的实际内容(用户名)
#### 索引
用户-用户名

### 订单相关
#### 基础
Guid -> 订单(Order)
#### 索引
食堂名称-日期-用户-早中晚饭 -> Guid
食堂名称-月订单表-月份 -> 订单列表(Guid)
### 食堂相关
#### 基础
食堂列表 -> 食堂列表实际内容(食堂名称)
//Guid -> 食堂
#### 索引
食堂-食堂名
//食堂名称 -> Guid
