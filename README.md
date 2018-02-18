# Hierarchy-System
Easy solution for creating an hierarchy between items

# How to implement
### Visual Studio 2017:
1) Download the HierarchySystem.dll
2) Right click on "Dependencies" in the Project Solution Explorer.
3) Select "Add Reference"
4) Click Browse
5) Navigate to the HierarchySystem.dll you downloaded and double click it
6) Select the box and click "OK"
7) Done!

# How to use:
- You can start creating items:
```CSharp
HItem mother = new HItem();
HItem daughter = new HItem();
```
- You can set the parent of an HItem:
```CSharp
daughter.SetParent(mother);
```
- Now, mother can access her 1st child, daughter:
```CSharp
mother.GetChild(0);
```
- The child, daughter can also access her parent:
```CSharp
daughter.GetParent();
```
- Parents can even have multiple childs:
```CSharp
HItem son = new HItem();
mother.AddChild(son);
```
- Now, mother can access both childs:
```CSharp
mother.GetChild(0); // daughter
mother.GetChild(1); // son
mother.GetChilds(); // Returns a List<HItem> with all the childs
```
- A Parent can remove childs
```CSharp
mother.RemoveChild(son); // :(
```

### Extras:
- How unparent an item:
```CSharp
item.SetParent(null);
```
- How to get a Parent's child count:
```CSharp
item.childCount;
```

# Notes:
- There are examples that show the use of the Hierarchy System in the "Examples" folder.
