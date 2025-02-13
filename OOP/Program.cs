using OOP;
using OOP.Human;

Human Aston = new Human("Aston", "Star", "Blue", 36);
Aston.Introduce();
Human AstonWithoutAge = new Human("Aston", "Star", "Blue");

AstonWithoutAge.Introduce();


Box box = new Box();
/* Старый способ писать геттеры и сеттеры
 box.SetWidth(34);
Console.WriteLine(box.GetWidth());
*/
box.DIisplayInfo();