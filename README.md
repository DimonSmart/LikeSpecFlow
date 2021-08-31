# LikeSpecFlow
Small demo, how to write tests in specflow style on plain c#

## Intro
I like the way specflow works ... in theory.
In reality I've faced several problems
- Plugin needed for IDE (not all IDE currently supported. Vote for Rider https://youtrack.jetbrains.com/issue/RIDER-9750)
- Typos in step definition lead to long error hunting
- Step text definition and step-method definition are almost the same. Ant it hard to support sync between.
- Converting all parameters from strings leads to localization errors for dates, doubles, etc.
- It is hard to combine asserts with my favorite FluentAssertion lib.

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

