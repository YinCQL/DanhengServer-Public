# Danheng Server

**__此项目正在开发中！__**

<p align="center">
<a href="https://visualstudio.com"><img src="https://img.shields.io/badge/Visual%20Studio-000000.svg?style=for-the-badge&logo=visual-studio&logoColor=white" /></a>
<a href="https://dotnet.microsoft.com/"><img src="https://img.shields.io/badge/.NET-000000.svg?style=for-the-badge&logo=.NET&logoColor=white" /></a>
<a href="https://www.gnu.org/"><img src="https://img.shields.io/badge/GNU-000000.svg?style=for-the-badge&logo=GNU&logoColor=white" /></a>
</p>
<p align="center">
  <a href="https://discord.gg/xRtZsmHBVj"><img src="https://img.shields.io/badge/Discord%20Server-000000.svg?style=for-the-badge&logo=Discord&logoColor=white" /></a>
</p>

[EN](../README.md) | [简中](README_zh-CN.md) | [繁中](README_zh-TW.md) | [JP](README_ja-JP.md)

## 💡功能

- [√] **商店**
- [√] **编队**
- [√] **抽卡** - 自定义概率: )
- [√] **战斗** - 场景技能中有一些错误
- [√] **场景** - 行走模拟器、交互、正确加载实体
- [√] **基本的角色培养** - 一些小bug，影响体验不大
- [√] **任务** - 某些任务中可能存在一些错误，贝洛伯格主线任务已全数完成，剩余内容正在制作中或是尚未测试，适用于星与穹
- [√] **朋友**
- [√] **忘却之庭 & 虚构叙事**
- [√] **模拟宇宙**

- [ ] **更多**  - Coming soon...

当新版本之「某动漫游戏」发布时，某些功能将不会在第一时间支援，请持续关注我们的提交内容。 自从2.3版本起，我们建立了适用于Beta版本的私人分支，将在准备完成后第一时间合并至主仓库。

## 🍗使用&安装

### 快速启动

1. 在 [Action](https://github.com/EggLink/DanhengServer-Public/actions) 下载可执行文件
2. 打开下载完成的 `DanhengServer.zip` 解压至任意文件夹 __*最好是英文路径*__

> (可选) 在源代码的WebServer文件夹中下载 `certificate.p12` 使得以HTTPS模式启动 让你的传输更安全: )

3. 下载Resources[https://github.com/Dimbreath/StarRailData](https://github.com/Dimbreath/StarRailData)并解压到同目录下`Resources`，然后前往[https://github.com/EggLinks/DanhengServer-Resources](https://github.com/EggLinks/DanhengServer-Resources) 下载后覆盖Config到 `Resources/Config` ,其他的还是用Dimbreath项目的，在项目下载Config并解压到同目录下`Config`
4. 运行GameServer.exe
5. 运行代理 启动游戏 链接，享受！

### 构建

DanhengServer 使用 .NET Framework 构建

**前置：**

- [.NET](https://dotnet.microsoft.com/)
- [Git](https://git-scm.com/downloads)

##### Windows

```shell
git clone --recurse-submodules https://github.com/EggLink/DanhengServer-Public.git
cd DanhengServer
.\dotnet build # 编译
```
##### Linux （Ubuntu 20.04）
```shell
# 添加 Microsoft 包存储库
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

# 安装 .NET SDK
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-8.0
```

- 编译并运行环境
```shell
git clone --recurse-submodules https://github.com/EggLink/DanhengServer-Public.git
cd DanhengServer
.\dotnet build # 编译
./Gameserver
```
**向 Microsoft 显示其他系统版本**
- [微软教程](https://dotnet.microsoft.com/zh-cn/download/dotnet/thank-you/sdk-8.0.204-linux-x64-binaries)

## ❓帮助

- 支持安卓系统
- 100040119（无法自动完成）（使用 /mission finish 100040119 进行修复）
- 
## 🔗接口说明
[EN](MuipAPI.md) | [简中](MuipAPI_zh-CN.md) | [繁中](MuipAPI_zh-TW.md) | [JP](MuipAPI_ja-JP.md)

## ❕️故障排除

获取常见问题的解决方案或寻求帮助，请加入[我们的Discord服务器](https://discord.gg/xRtZsmHBVj)

## 🙌鸣谢

- Weedwacker - 提供 kcp 实现
- [SqlSugar](https://github.com/donet5/SqlSugar) - 提供 ORM
- [LunarCore](https://github.com/Melledy/LunarCore) - 一些数据结构和算法
