using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using CustomDesign.Control;


namespace CustomDesign.Serialization
{
    public class ReportSerializer : CodeDomSerializer
    {
        public ReportSerializer()
        {
            Log.Write("ReportSerializer ctor");
        }

        public override object Deserialize(IDesignerSerializationManager manager, object codeObject)
        {
            var serializer = GetBaseSerializer(manager);
            object returnObj = serializer.Deserialize(manager, codeObject);
            return returnObj;
        }

		public override object Serialize(IDesignerSerializationManager manager, object value)
		{
			CodeDomSerializer serializer = GetBaseSerializer(manager);
			object returnObj = serializer.Serialize(manager, value);

					return returnObj;
		}

		private CodeDomSerializer GetBaseSerializer(IDesignerSerializationManager manager)
		{
			return (CodeDomSerializer)manager.GetSerializer(typeof(Component), typeof(CodeDomSerializer));
		}
	}
}
