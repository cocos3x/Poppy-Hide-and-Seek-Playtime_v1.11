namespace Analytics
{
	public struct Feature_LEVEL_STATUS
	{
		public enum ACTION_NAME
		{
			NONE,
			_start,
			_finish
		}

		public enum USE_HELP
		{
			NONE,
			_yes,
			_no
		}

		public enum EVENT_NAME
		{
			level_status
		}

		private EVENT_NAME _003CeventName_003Ek__BackingField;

		private ACTION_NAME _003Caction_name_003Ek__BackingField;

		private string _003Clevel_003Ek__BackingField;

		public USE_HELP use_help;

		

		public string level
		{
			get
			{
				return "";
			}
			set
			{
			}
		}
	}
}
