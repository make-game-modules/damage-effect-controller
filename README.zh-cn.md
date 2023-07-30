# 角色受伤特效控制器

这个项目提供了一个 Unity 脚本，用于管理角色受伤时的粒子特效。当角色受伤时，可以通过调用 "TriggerDamageEffect" 方法产生特效，当不需要产生特效时，可以调用 "StopDamageEffect" 方法停止特效。

## 如何安装

在你的 Unity 项目中，使用 Git 在任意位置克隆本仓库即可。

## 如何使用

1. 将 `DamageEffectController` 脚本挂载到角色对象上。
2. 在需要的时候调用 `TriggerDamageEffect` 方法启动特效。
3. 在不需要特效的时候调用 `StopDamageEffect` 方法来停止特效。

## 参数设置

- `damageEffect`： 受伤特效的粒子系统组件引用。

## 运行原理

该脚本提供了两个公开方法 `TriggerDamageEffect` 和 `StopDamageEffect`，可以分别启动和停止受伤特效。

## 版权信息

本项目采用 MIT 开源许可证，欢迎任何人对项目的改进和使用。

## 其他

如果你有任何关于这个项目的问题或建议，欢迎通过 issue 或者 pull request 提交给我们。
