using System;
using System.Net;
namespace Arq.Lab.Coverage;
public static class Rule006 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0404-csharp
        // evidence_anchor: ServicePointManager.SecurityProtocol
        // regex_sample: SSLv3
        // keywords: ServicePointManager | SecurityProtocol | Ssl3 | SecurityProtocolType
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
    }
}
