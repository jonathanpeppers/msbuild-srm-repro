# msbuild-srm-repro

To see the problem:

```
$ msbuild msbuild-srm-repro.sln /v:minimal /restore
Microsoft (R) Build Engine version 16.0.42-preview+g804bde742b for Mono
Copyright (C) Microsoft Corporation. All rights reserved.

  task -> /Users/jonathanpeppers/Desktop/Git/msbuild-srm-repro/task/bin/Debug/task.dll
/Users/jonathanpeppers/Desktop/Git/msbuild-srm-repro/task/task.csproj(42,5): error MSB4018: The "LogAssemblyName" task failed unexpectedly.
/Users/jonathanpeppers/Desktop/Git/msbuild-srm-repro/task/task.csproj(42,5): error MSB4018: System.MissingMethodException: Method not found: System.Reflection.AssemblyName System.Reflection.Metadata.AssemblyDefinition.GetAssemblyName()
/Users/jonathanpeppers/Desktop/Git/msbuild-srm-repro/task/task.csproj(42,5): error MSB4018:   at Microsoft.Build.BackEnd.TaskExecutionHost.Microsoft.Build.BackEnd.ITaskExecutionHost.Execute () [0x00029] in <1c1ea286ad81486b85647b7901984451>:0
/Users/jonathanpeppers/Desktop/Git/msbuild-srm-repro/task/task.csproj(42,5): error MSB4018:   at Microsoft.Build.BackEnd.TaskBuilder.ExecuteInstantiatedTask (Microsoft.Build.BackEnd.ITaskExecutionHost taskExecutionHost, Microsoft.Build.BackEnd.Logging.TaskLoggingContext taskLoggingContext, Microsoft.Build.BackEnd.TaskHost taskHost, Microsoft.Build.BackEnd.ItemBucket bucket, Microsoft.Build.BackEnd.TaskExecutionMode howToExecuteTask) [0x00212] in <1c1ea286ad81486b85647b7901984451>:0
```

My mono version:
```
$ mono -V
Mono JIT compiler version 5.20.0.217 (2018-10/2b6f395180b Mon Feb 18 16:32:04 PST 2019)
Copyright (C) 2002-2014 Novell, Inc, Xamarin Inc and Contributors. www.mono-project.com
	TLS:
	SIGSEGV:       altstack
	Notification:  kqueue
	Architecture:  amd64
	Disabled:      none
	Misc:          softdebug
	Interpreter:   yes
	LLVM:          yes(600)
	Suspend:       hybrid
	GC:            sgen (concurrent by default)
```
