﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetOpenId.RelyingParty {
	internal class IndirectMessageRequest : IEncodable {
		public IndirectMessageRequest(Uri receivingUrl, IDictionary<string, string> fields) {
			if (receivingUrl == null) throw new ArgumentNullException("receivingUrl");
			if (fields == null) throw new ArgumentNullException("fields");
			RedirectUrl = receivingUrl;
			EncodedFields = fields;

			Logger.DebugFormat("Preparing indirect message:{0}{1}", Environment.NewLine,
				fields.DeferredToString());
		}

		#region IEncodable Members

		public EncodingType EncodingType { get { return EncodingType.IndirectMessage ; } }
		public IDictionary<string, string> EncodedFields { get; private set; }
		public Uri RedirectUrl { get; private set; }
		public Protocol Protocol {
			get { throw new NotImplementedException(); }
		}

		#endregion
	}
}
