using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGLPIAPI
{
    class Ticket
    {
		private int _id;

		public int id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string name
		{
			get { return _name; }
			set { _name = value; }
		}

		private DateTime? _date;

		public DateTime? date
		{
			get { return _date; }
			set { _date = value; }
		}

		private DateTime? _closedate;

		public DateTime? closedate
		{
			get { return _closedate; }
			set { _closedate = value; }
		}

		private DateTime? _solvedate;

		public DateTime? solvedate
		{
			get { return _solvedate; }
			set { _solvedate = value; }
		}

		private DateTime? _date_mod;

		public DateTime? date_mod
		{
			get { return _date_mod; }
			set { _date_mod = value; }
		}

		private int _status;

		public int status
		{
			get { return _status; }
			set { _status = value; }
		}

		private string _content;

		public string content
		{
			get { return _content; }
			set { _content = value; }
		}

		private int _urgency;

		public int urgency
		{
			get { return _urgency; }
			set { _urgency = value; }
		}

		private int _impact;

		public int impact
		{
			get { return _impact; }
			set { _impact = value; }
		}

		private int _priority;

		public int priority
		{
			get { return _priority; }
			set { _priority = value; }
		}

		private DateTime? _time_to_resolve;

		public DateTime? time_to_resolve
		{
			get { return _time_to_resolve; }
			set { _time_to_resolve = value; }
		}

		private DateTime? _date_creation;

		public DateTime? date_creation
		{
			get { return _date_creation; }
			set { _date_creation = value; }
		}





	}
}
