# Abp.TencentCloud

[![NuGet](https://img.shields.io/nuget/v/EasyAbp.Abp.TencentCloud.Common.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.TencentCloud.Common)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.Abp.TencentCloud.Common.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.TencentCloud.Common)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/Abp.TencentCloud?style=social)](https://www.github.com/EasyAbp/Abp.TencentCloud)

专门为 ABP vNext 封装的腾讯云 SDK 模块。

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/How-To.md#add-nuget-packages))

    * EasyAbp.Abp.TencentCloud.XXX

1. Add `DependsOn(typeof(AbpTencentCloudXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/How-To.md#add-module-dependencies))

## Usage

1. 添加想要使用的模块 NuGet 包。
2. 在启动模块或其他模块上，使用 `[DependsOn]` 标签来依赖显式模块。
3. 通过 `Configure<AbpTencentCloudCommonOptions>()` 方法配置你的腾讯云相关参数。
4. 通过 `Configure<AbpTencentCloudXXXOptions>()` 方法配置对应模块的特殊参数。
5. 注入 `ITencentCloudApiRequester` 用于发送请求，其中 Request 和 Response 取决于对应模块提供的类型。

> 注意:
>
> 如果目前仓库没有实现的 Requset 或 Response，你也可以直接继承 `CommonRequest` 类型与 `CommonResponse` 类型。我们也希望大家参与完善本模块的其他功能。