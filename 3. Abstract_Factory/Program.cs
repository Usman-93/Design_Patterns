using _3._Abstract_Factory.Desktop;
using _3._Abstract_Factory.Factory;
using _3._Abstract_Factory.Laptop;

IFactory macFactory = PCAbstractFactory.createFactory("Mac");
IFactory WindowsFactory = PCAbstractFactory.createFactory("Windows");

ILaptop macLatop = macFactory.createLaptop();
IDesktop macDesktop = macFactory.createDesktop();

ILaptop windowsLatop = WindowsFactory.createLaptop();
IDesktop windowsDesktop = WindowsFactory.createDesktop();


macLatop.turnOn();
macLatop.turnOff();
macLatop.carryInBagPack();




