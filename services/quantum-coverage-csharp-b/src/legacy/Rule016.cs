using System;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
namespace Arq.Lab.Coverage;
public static class Rule016 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0465-csharp
        // evidence_anchor: SslClientAuthenticationOptions, EnabledSslProtocols, SslProtocols
        // regex_sample: TLSv1
        // keywords: SslClientAuthenticationOptions | SslServerAuthenticationOptions | EnabledSslProtocols | SslProtocols.Tls
        var options = new SslClientAuthenticationOptions { EnabledSslProtocols = SslProtocols.Tls | SslProtocols.Tls11 };
    }
}
