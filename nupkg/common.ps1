# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of projects
$projects = (

    "src/EasyAbp.Abp.TencentCloud.CAM",
    "src/EasyAbp.Abp.TencentCloud.CloudLive",
    "src/EasyAbp.Abp.TencentCloud.CloudMonitor",
    "src/EasyAbp.Abp.TencentCloud.Common",
    "src/EasyAbp.Abp.TencentCloud.COS"
)