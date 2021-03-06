﻿// <auto-generated />

namespace DotNetOpenAuth.Loggers {
	using System;
	using System.Diagnostics;
	using System.Security;
	using System.Security.Permissions;

	internal class TraceLogger : ILog {
		private TraceSwitch traceSwitch;

		internal TraceLogger(string name) {
			traceSwitch = new TraceSwitch(name, name + " Trace Switch");
		}

		#region ILog Properties

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public bool IsDebugEnabled {
			get { return this.traceSwitch.TraceVerbose; }
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public bool IsInfoEnabled {
			get { return this.traceSwitch.TraceInfo; }
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public bool IsWarnEnabled {
			get { return this.traceSwitch.TraceWarning; }
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public bool IsErrorEnabled {
			get { return this.traceSwitch.TraceError; }
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public bool IsFatalEnabled {
			get { return this.traceSwitch.TraceError; }
		}

		#endregion

		private static bool IsSufficientPermissionGranted {
			get {
				PermissionSet permissions = new PermissionSet(PermissionState.None);
				permissions.AddPermission(new KeyContainerPermission(PermissionState.Unrestricted));
				permissions.AddPermission(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess));
				permissions.AddPermission(new RegistryPermission(PermissionState.Unrestricted));
				permissions.AddPermission(new SecurityPermission(SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.ControlThread));
				var file = new FileIOPermission(PermissionState.None);
				file.AllFiles = FileIOPermissionAccess.PathDiscovery | FileIOPermissionAccess.Read;
				permissions.AddPermission(file);
				try {
					permissions.Demand();
					return true;
				} catch (SecurityException) {
					return false;
				}
			}
		}

		#region ILog Methods

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Debug(object message) {
			if (this.IsDebugEnabled) {
				Trace.TraceInformation(message.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Debug(object message, Exception exception) {
			if (this.IsDebugEnabled) {
				Trace.TraceInformation(message + ": " + exception.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void DebugFormat(string format, params object[] args) {
			if (this.IsDebugEnabled) {
				Trace.TraceInformation(format, args);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void DebugFormat(string format, object arg0) {
			if (this.IsDebugEnabled) {
				Trace.TraceInformation(format, arg0);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void DebugFormat(string format, object arg0, object arg1) {
			if (this.IsDebugEnabled) {
				Trace.TraceInformation(format, arg0, arg1);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void DebugFormat(string format, object arg0, object arg1, object arg2) {
			if (this.IsDebugEnabled) {
				Trace.TraceInformation(format, arg0, arg1, arg2);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Info(object message) {
			if (this.IsInfoEnabled) {
				Trace.TraceInformation(message.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Info(object message, Exception exception) {
			if (this.IsInfoEnabled) {
				Trace.TraceInformation(message + ": " + exception.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void InfoFormat(string format, params object[] args) {
			if (this.IsInfoEnabled) {
				Trace.TraceInformation(format, args);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void InfoFormat(string format, object arg0) {
			if (this.IsInfoEnabled) {
				Trace.TraceInformation(format, arg0);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void InfoFormat(string format, object arg0, object arg1) {
			if (this.IsInfoEnabled) {
				Trace.TraceInformation(format, arg0, arg1);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void InfoFormat(string format, object arg0, object arg1, object arg2) {
			if (this.IsInfoEnabled) {
				Trace.TraceInformation(format, arg0, arg1, arg2);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Warn(object message) {
			if (this.IsWarnEnabled) {
				Trace.TraceWarning(message.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Warn(object message, Exception exception) {
			if (this.IsWarnEnabled) {
				Trace.TraceWarning(message + ": " + exception.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void WarnFormat(string format, params object[] args) {
			if (this.IsWarnEnabled) {
				Trace.TraceWarning(format, args);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void WarnFormat(string format, object arg0) {
			if (this.IsWarnEnabled) {
				Trace.TraceWarning(format, arg0);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void WarnFormat(string format, object arg0, object arg1) {
			if (this.IsWarnEnabled) {
				Trace.TraceWarning(format, arg0, arg1);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void WarnFormat(string format, object arg0, object arg1, object arg2) {
			if (this.IsWarnEnabled) {
				Trace.TraceWarning(format, arg0, arg1, arg2);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Error(object message) {
			if (this.IsErrorEnabled) {
				Trace.TraceError(message.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Error(object message, Exception exception) {
			if (this.IsErrorEnabled) {
				Trace.TraceError(message + ": " + exception.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void ErrorFormat(string format, params object[] args) {
			if (this.IsErrorEnabled) {
				Trace.TraceError(format, args);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void ErrorFormat(string format, object arg0) {
			if (this.IsErrorEnabled) {
				Trace.TraceError(format, arg0);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void ErrorFormat(string format, object arg0, object arg1) {
			if (this.IsErrorEnabled) {
				Trace.TraceError(format, arg0, arg1);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void ErrorFormat(string format, object arg0, object arg1, object arg2) {
			if (this.IsErrorEnabled) {
				Trace.TraceError(format, arg0, arg1, arg2);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Fatal(object message) {
			if (this.IsFatalEnabled) {
				Trace.TraceError(message.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void Fatal(object message, Exception exception) {
			if (this.IsFatalEnabled) {
				Trace.TraceError(message + ": " + exception.ToString());
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void FatalFormat(string format, params object[] args) {
			if (this.IsFatalEnabled) {
				Trace.TraceError(format, args);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void FatalFormat(string format, object arg0) {
			if (this.IsFatalEnabled) {
				Trace.TraceError(format, arg0);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void FatalFormat(string format, object arg0, object arg1) {
			if (this.IsFatalEnabled) {
				Trace.TraceError(format, arg0, arg1);
			}
		}

		/// <summary>
		/// See <see cref="ILog"/>.
		/// </summary>
		public void FatalFormat(string format, object arg0, object arg1, object arg2) {
			if (this.IsFatalEnabled) {
				Trace.TraceError(format, arg0, arg1, arg2);
			}
		}

		#endregion

		/// <summary>
		/// Returns a new logger that uses the <see cref="System.Diagnostics.Trace"/> class 
		/// if sufficient CAS permissions are granted to use it, otherwise returns false.
		/// </summary>
		/// <returns>The created <see cref="ILog"/> instance.</returns>
		internal static ILog Initialize(string name) {
			return IsSufficientPermissionGranted ? new TraceLogger(name) : null;
		}
	}
}
