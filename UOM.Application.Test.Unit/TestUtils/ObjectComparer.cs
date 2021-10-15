using System.Text;

namespace UOM.Application.Test.Unit.TestUtils
{
    public static class ObjectComparer
    {
		public static bool Equal
			(this object oldObject, object expected)
		{
			var oType = oldObject.GetType();

			foreach (var oProperty in oType.GetProperties())
			{
				var oOldValue = oProperty.GetValue(oldObject, null);
				var oNewValue = oProperty.GetValue(expected, null);

				if (Equals(oOldValue, oNewValue))
				{
					continue;
				}

				return false;
			}

			return true;
		}
	}
}
