using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Linq;
using CustomDesign.Control;

namespace CustomDesign.Design
{
    public class ReportDesigner : ComponentDesigner, IRootDesigner
    {
        ReportDesignerView _mainView;

        public ReportDesigner()
        {
            Log.Write("ReportDesigner ctor");
            _mainView = new ReportDesignerView();
            
        }

        
        public ViewTechnology[] SupportedTechnologies { get; } = { ViewTechnology.Default };

        public object GetView(ViewTechnology technology)
        {
            if (technology != ViewTechnology.Default)
                throw new ArgumentException("technology");

            // Note that we store off a single instance of the
            // view.  Don't always create a new object here, because
            // it is possible that someone will call this multiple times.
            //
            _mainView.SetComponent(Component);

            return _mainView;
        }

        protected override void PreFilterProperties(IDictionary properties)
        {
            Log.Write("PreFilterProperties: " + string.Join(", ", properties.Keys.Cast<string>()));
            base.PreFilterProperties(properties);
            Log.Write("PreFilterProperties: " + string.Join(", ", properties.Keys.Cast<string>()));
        }

        protected override void PostFilterProperties(IDictionary properties)
        {
            Log.Write("PostFilterProperties: " + string.Join(", ", properties.Keys.Cast<string>()));
            base.PostFilterProperties(properties);
            Log.Write("PostFilterProperties: " + string.Join(", ", properties.Keys.Cast<string>()));
        }
    }
}
