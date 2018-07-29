//    CANAPE Core Network Testing Library
//    Copyright (C) 2017 James Forshaw
//    Based in part on CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
using CANAPE.Net.Servers;
using CANAPE.Utils;
using System;

namespace CANAPE.Net.Templates
{
    /// <summary>
    /// Document to describe a SOCKS proxy
    /// </summary>
    public class SocksProxyTemplate : GenericProxyTemplate
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SocksProxyTemplate()
            : base()
        {
            LocalPort = 1080;
        }

        /// <summary>
        /// Create the proxy server from the document
        /// </summary>
        /// <param name="logger">The service logger</param>
        /// <returns>The proxy server</returns>
        protected override ProxyServer CreateServer(Logger logger)
        {
            return new SocksProxyServer(logger);
        }

        /// <summary>
        /// Overridden ToString method
        /// </summary>
        /// <returns>Information about the proxy</returns>
        public override string ToString()
        {
            return String.Format("SOCKS Proxy listening on port {0}", LocalPort);
        }
    }
}
