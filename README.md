# 1. Refactor Done

# 2. UML diagram of your design
   ![Cabellon_UML](https://user-images.githubusercontent.com/116715535/201474659-01c14f92-034f-42cb-9bc7-2523f2eebf3e.png)


# 3. Explain
   I will explain first my UML so first is the interface **IUserInterfaceFactory**(it has NewText() and NEwButton() methods) which houses **DarkFactory**(also has two methods the same with the base class but it can only pass the DarkText and DarkButton) and **LightFactory** (also has two methods the same with the base class but it can only pass the LightText and LightButton) next is the **Button**(which is an abstract class that has a method CreateButton() this method is also used in Dark and LightButton which has the createMethod string but these two buttons are different based on the code which shows what kind Button is Dark and what kind of Button is Light) same with **Text** also which is abstract has the CreateText() method. 
   
   InterfaceThemeRendererGenerator is an abstract class which basically is also the client wla ni siya nagrely on the concrete classes or factories specificity sa object but nagrely sa abstractions which is like sa katong IUserInterfaceFactory, Buttons, Text dri siya garely since naa man access ang kani nga classes to the other classes below nila. 
   
   And also for the code I used the Abstract Factory Method which is hint(111) it is simply since if you use abstract classes you can create mn families from certain relations pero you are not specifying their concrete classes so mo skip ka sa specific things. since thats waht the client wants. Clients does not care about the specifics which is the concrete factories they only get it from the generic interfaces or ang other abstract classes.
   
   So base on the UML to sum up. The InterfaceThemeRenderer Generator generates everything from the project but it only gets it from the base class or the interface and abstract class since it does not care about the subclasses. The InterfaceThemeRenderer also has its subclasses which I used for the program so when I make the switch case I can actually lessen my code from simply calling the two subclasses for dark and light theme. 
  
  PS. SIR WA DYUD KOY AYO MOEXPLAIN SIR. sensya
   
   
