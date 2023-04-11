# LikeSpecFlow
Small demo, how to write tests in specflow style on plain c#

## Intro

While I appreciate the concept of how SpecFlow works, I have encountered some practical issues that have made it challenging to use effectively. Specifically, I have experienced the following problems:

- The need for an IDE plugin, which is not yet available for all IDEs. I have voted for Rider to support SpecFlow (https://youtrack.jetbrains.com/issue/RIDER-9750).
- Typos in step definitions can be difficult to track down and fix, leading to wasted time and effort.
- The similarities between step text definitions and step method definitions can make it difficult to keep them in sync.
- Converting all parameters from strings can result in localization errors for dates, doubles, and other types.
- It can be difficult to use my preferred FluentAssertion library in combination with SpecFlow's assertion framework.

Overall, while SpecFlow can be a useful testing framework in certain situations, its limitations and overheads may make it less suitable for C# based tests descriptions. Other alternatives, such as writing test cases in plain C# code, may provide a simpler and more efficient approach to test development.

### SpecFlow https://specflow.org/
### Builder pattern https://medium.com/@martinstm/fluent-builder-pattern-c-4ac39fafcb0b
### Usefull videos (rus) https://www.youtube.com/channel/UCHFl23Ah_l4gEUTXYUStQdQ

P.S. Feel free to contact me, discuss, suggest updates etc.

Disclaimer. Now its just a proof of concept.

## Example
### C# Code 
```
 CreateTest("Login test")
   .InitializeSelenumWith_Parameter("/nocache")
   .OpenPage("mail.ru")
   .WaitWorElement_Clickable("loginButton")
   .Type_OnControl_("Name", "Jon@mail.ru")
   .Type_OnControl_("Password", "123")
   .ClickOn_Control("Login")
   .AssertForElement_Exists("logo",  i => i.Should().BeOfType<ImageElement>().Which.LogoName.Should().BeNull());
```
### Test as text
```
Step 0:Initialize Selenum With </nocache> Parameter
Step 1:Open Page <mail.ru>
Step 2:Wait Wor Element <loginButton> Clickable
Step 3:Type <Jon@mail.ru> On Control <Name> 
Step 4:Type <123> On Control <Password> 
Step 5:Click On <Login> Control
Step 6:Assert For Element <logo> Exists
```

