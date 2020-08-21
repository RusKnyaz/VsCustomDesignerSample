using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace CustomDesign.Control
{

    //This is necessary to show our designer for your component.
    [Designer("CustomDesign.Design.ReportDesigner, CustomDesign.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=8512ac17f5f7745e", typeof(IRootDesigner))]
    
    //This is not necessary to show designer but you can use it to override your component serialization.
    //[DesignerSerializer("CustomDesign.Serialization.ReportSerializer, CustomDesign.Serialization, Version= 1.0.0.0, Culture= neutral, PublicKeyToken= 8512ac17f5f7745e", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]
    //[RootDesignerSerializer("CustomDesign.Serialization.ReportRootSerializer, CustomDesign.Serialization, Version= 1.0.0.0, Culture= neutral, PublicKeyToken= 8512ac17f5f7745e", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design", true)]


    [ToolboxItem(false)]
    
    //DesignerCategory attribute is necessary to show 'View Designer' menu item in VS.
    [DesignerCategory("Component")]
    public class Report : IComponent
    {
        [Browsable(true)]
        [Description("The name of the report.")]
        [DisplayName("Name")]
        [Category("General")]
        public string Name { get; set; }


        public Report()
        {
            Log.Write("Report ctor");
        }
        public ISite Site { get; set; }

        public event EventHandler Disposed;

        public void Dispose()
        {
            Disposed?.Invoke(this, EventArgs.Empty);
        }
    }
}
