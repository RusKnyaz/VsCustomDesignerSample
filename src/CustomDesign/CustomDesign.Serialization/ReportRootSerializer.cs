using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using CustomDesign.Control;

namespace CustomDesign.Serialization
{
    public class ReportRootSerializer : CodeDomSerializer
    {
        public ReportRootSerializer()
        {
            Log.Write("ReportRootSerializer ctor");
        }

		public override object Deserialize(IDesignerSerializationManager manager, object codeObject)
		{
			CodeDomSerializer serializer = GetSerializer(manager);
			if (serializer == null)
				return null;

			var obj1 = serializer.Deserialize(manager, codeObject);


			return obj1;
		}

		private CodeDomSerializer GetSerializer(IDesignerSerializationManager manager)
		{
			var attribute = TypeDescriptor.GetAttributes(typeof(System.ComponentModel.Component))[typeof(RootDesignerSerializerAttribute)] as RootDesignerSerializerAttribute;
			if (attribute == null)
				return null;

			IDesignerHost host = manager.GetService(typeof(IDesignerHost)) as IDesignerHost;
			if (host == null)
				return null;

			Type type = host.GetType(attribute.SerializerTypeName);
			if (type == null)
				return null;

			return Activator.CreateInstance(type) as CodeDomSerializer;
		}

		public override object Serialize(IDesignerSerializationManager manager, object value)
		{
			CodeDomSerializer serializer1 = GetSerializer(manager);
			if (serializer1 == null)
				return null;

			return serializer1.Serialize(manager, value);
		}
    }
}
