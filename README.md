# EndlessTaskAsync
C# 不終止的非同步事件 ex:多個while(true)常駐。

主要使用以下的模板去製作常駐程式

```csharp
var endlessTask = Task.Run(async () =>
    {
        while (true)
        {
          // Todo
        }
    });
```
