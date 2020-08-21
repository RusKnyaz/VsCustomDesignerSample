# About


## CustomDesign solution
This is a sample that demonstrates how to create your own component and link it with the custom designer to be designed in Visual Studio.

### Projects

CustomDesign.Control - contains custom component 'Report'
CustomDesign.Design - contains designer for the 'Report' component.
CustomDesign.Serialization - contains custom CodeDom serializers for the 'Report' component.

Major. It is necessary to split control/design/serialization on several projects. I could not achieve the result using single assembly for all.