// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyNewObjectFactory myNewObjectFactory = new MyNewObjectFactory();
MyNewObject myNewObject = new MyNewObject();

myNewObject.Name = "Person";

myNewObject.Greet();

List<MyNewObject> list = new List<MyNewObject>();

for(int i = 0; i < 10; i++)
{
    MyNewObject myNewObject1 = new MyNewObject() { Name = $"Unit{i}"};
    list.Add(myNewObject1); 
}

foreach(MyNewObject item in list)
{
    item.Greet();
}

foreach(var item in list)
{
    FileSaver.Save(item);
}