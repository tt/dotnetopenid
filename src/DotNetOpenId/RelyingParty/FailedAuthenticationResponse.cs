﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DotNetOpenId.RelyingParty {
	[DebuggerDisplay("{Exception.Message}")]
	class FailedAuthenticationResponse : IAuthenticationResponse {
		public FailedAuthenticationResponse(Exception exception) {
			Exception = exception;
		}

		#region IAuthenticationResponse Members

		public T GetExtension<T>() where T : DotNetOpenId.Extensions.IExtensionResponse, new() {
			return default(T);
		}

		public DotNetOpenId.Extensions.IExtensionResponse GetExtension(Type extensionType) {
			return null;
		}

		public Identifier ClaimedIdentifier {
			get { return null; }
		}

		public string FriendlyIdentifierForDisplay {
			get { return null; }
		}

		public AuthenticationStatus Status {
			get { return AuthenticationStatus.Failed; }
		}

		public Exception Exception { get; private set; }

		#endregion
	}
}
