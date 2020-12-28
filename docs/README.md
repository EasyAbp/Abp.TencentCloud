# Abp.TencentCloud

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FEasyAbp%2FAbp.TencentCloud%2Fmaster%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/EasyAbp.Abp.TencentCloud.Common.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.TencentCloud.Common)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.Abp.TencentCloud.Common.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.Abp.TencentCloud.Common)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/Abp.TencentCloud?style=social)](https://www.github.com/EasyAbp/Abp.TencentCloud)

专门为 ABP vNext 封装的腾讯云 SDK 模块。

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * EasyAbp.Abp.TencentCloud.Xxx

1. Add `DependsOn(typeof(AbpTencentCloudXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-module-dependencies))

## Usage

1. 通过 `Configure<AbpTencentCloudCommonOptions>()` 方法配置你的腾讯云相关参数。

1. 通过 `Configure<AbpTencentCloudXXXOptions>()` 方法配置对应模块的特殊参数。

1. 注入 `ITencentCloudApiRequester` 用于发送请求，其中 Request 和 Response 取决于对应模块提供的类型。

> 注意:
>
> 如果目前仓库没有实现的 Requset 或 Response，你也可以直接继承 `CommonRequest` 类型与 `CommonResponse` 类型。我们也希望大家参与完善本模块的其他功能。