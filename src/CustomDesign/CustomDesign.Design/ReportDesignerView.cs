using System.ComponentModel;
using System.Windows.Forms;
using CustomDesign.Control;

namespace CustomDesign.Design
{
    public partial class ReportDesignerView : UserControl
    {
        public ReportDesignerView()
        {
            InitializeComponent();
        }

        public void SetComponent(IComponent component)
        {
            if(component is Report report)
            {
                this.textBox1.Text = report.Name;
            }
        }
    }
}
