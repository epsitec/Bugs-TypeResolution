# Bugs-TypeResolution

This project demonstrates an issue with `System.GetType` not throwing `System.IO.FileLoadException`
when the test is started through the _CodeRush_ user interface in Visual Studio 2013.

When run through Microsoft's _Test Explorer_, the test passes.


```

Testing started:

Searching for tests...
Total tests: 1, filtered: 1

Should_Throw_SystemIOFileLoadException has failed:
  Xunit.Sdk.ThrowsException: Assert.Throws() Failure
  Expected: typeof(System.IO.FileLoadException)
  Actual:   (No exception was thrown)
  at Xunit.Assert.Throws(Type exceptionType, Exception exception) in c:\TeamCity\buildAgent\work\74856245f07a90f0\src\xunit.assert\Asserts\ExceptionAsserts.cs:line 138
  at Xunit.Assert.Throws[T](Func`1 testCode) in c:\TeamCity\buildAgent\work\74856245f07a90f0\src\xunit.assert\Asserts\ExceptionAsserts.cs:line 35
  at Epsitec.Lydia.Broken.Should_Throw_SystemIOFileLoadException() in s:\git\tool\Test\Broken.cs:line 20

Passed: 0, Failed: 1, Ignored: 0
Duration : 0.8025457282157

```